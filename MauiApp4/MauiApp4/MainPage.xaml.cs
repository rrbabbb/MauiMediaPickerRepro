namespace MauiApp4
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private async void OnOldApiClicked(object? sender, EventArgs e)
    {
      var photo = await MediaPicker.PickPhotoAsync();
      if (photo is not null)
      {
        ImportedImage.Source = ImageSource.FromFile(photo.FullPath);
      }
    }

    private async void OnNewApiClicked(object? sender, EventArgs e)
    {
      var photos = await MediaPicker.PickPhotosAsync();
      if (photos is not null)
      {
        var photo = photos.FirstOrDefault();
        if (photo is not null)
        {
          ImportedImage.Source = ImageSource.FromFile(photo.FullPath);
        }
      }
    }
  }
}
