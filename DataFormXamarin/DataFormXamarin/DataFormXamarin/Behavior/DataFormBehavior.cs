using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        Button save;
        Button cancel;
        DataFormModel formModel;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.SourceProvider = new SourceProviderExt();
            dataForm.RegisterEditor("Fruits", "DropDown");
            dataForm.PropertyChanged += DataForm_PropertyChanged;
            formModel = dataForm.DataObject as DataFormModel;
            save = bindable.FindByName<Button>("save");
            save.Clicked += OnSaved;
            cancel = bindable.FindByName<Button>("cancel");
            cancel.Clicked += OnCancel;
        }

        private void DataForm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "DataObject")
            formModel = dataForm.DataObject as DataFormModel;
        }

        //On cancel
        private void OnCancel(object sender, EventArgs e)
        {
            dataForm.DataObject = formModel;
            foreach (var property in dataForm.DataObject.GetType().GetProperties())
            {
                dataForm.UpdateEditor(property.Name);
            }
        }
        //On save
        private void OnSaved(object sender, EventArgs e)
        {
            dataForm.Validate();
            dataForm.Commit();
            formModel = dataForm.DataObject as DataFormModel;
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            save.Clicked -= OnSaved;
            cancel.Clicked -= OnCancel;
            dataForm.PropertyChanged -= DataForm_PropertyChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}