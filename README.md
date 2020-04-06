# How to save or cancel the edited DataForm data in Xamarin.Forms (SfDataForm) ?

You can save or cancel the [DataObject](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.SfDataForm~DataObject.html?) in Xamarin.Forms [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started?) by storing the dataobject.

You can refer the following article.

https://www.syncfusion.com/kb/11312/how-to-save-or-cancel-the-edited-dataform-data-in-xamarin-forms-sfdataform

**C#**

Raise the property change event to store the DataObject.
```c#
private void DataForm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
{
    if(e.PropertyName == "DataObject")
    formModel = dataForm.DataObject as DataFormModel;
}
```
**C#**

Cancel will reset the DataObject with stored dataobject.
``` c#
private void OnCancel(object sender, EventArgs e)
{
    dataForm.DataObject = formModel;
    foreach (var property in dataForm.DataObject.GetType().GetProperties())
    {
        dataForm.UpdateEditor(property.Name);
    }
}
```
**C#**

Saves the edited data by using [Commit](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.SfDataForm~Commit.html?) method.
``` c#
private void OnSaved(object sender, EventArgs e)
{
    dataForm.Validate();
    dataForm.Commit();
    formModel = dataForm.DataObject as DataFormModel;
}
```
