using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageColorizer {
  public partial class Form1 : Form {

    private FileInfo _imageFile;
    private Bitmap _image;
    private bool _imageIsSelected;

    private Color _selectedColor;

    private static readonly string[] _supportedFileTypes = new[] { ".jpg", ".jpeg", ".jpe", ".jfif", ".png" };

    public Form1() {
      this.InitializeComponent();
    }

    private void btnSelectImage_Click(object sender, EventArgs e) {
      var dialog = new OpenFileDialog {
        Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
      };

      if (dialog.ShowDialog() != DialogResult.OK)
        return;

      this._SelectImage(dialog.FileName);
    }


    private void tbPath_KeyUp(object sender, KeyEventArgs e) {   
      var path = this.tbPath.Text;
      var fittingTypeFound = false;

      foreach (var fileType in _supportedFileTypes) {
        if (path.EndsWith(fileType)) {
          fittingTypeFound = true;
          break;
        }
      }

      if (fittingTypeFound == false) {
        this.pbImagePreview.Image = null;
        return;
      }

      this._SelectImage(path);
    }

    private void _SelectImage(string path) {
      this._imageFile = new FileInfo(path);

      Bitmap bitmap;
      try {
        bitmap = new Bitmap(path);
      } catch (Exception) {
        this.pbImagePreview.Image = null;
        return;
      }

      this._image = new Bitmap(path);
      this._imageIsSelected = true;

      this.pbImagePreview.Image = this._image;
      this.tbPath.Text = path;

      if (this._selectedColor != null)
        this._ChangeColor(this._selectedColor);
    }

    private void btnSelectColor_Click(object sender, EventArgs e) {
      if (!this._imageIsSelected) {
        MessageBox.Show("Please Select an Image first!");
        return;
      }

      var dialog = new ColorDialog();

      if (dialog.ShowDialog() != DialogResult.OK)
        return;

      var color = dialog.Color;
      this.tbColorCode.Text = _HexConverter(color);
      this._ChangeColor(color);
    }

    private void tbColorCode_KeyUp(object sender, KeyEventArgs e) {
      Color color;
      try {
        color = ColorTranslator.FromHtml(this.tbColorCode.Text);
      } catch (Exception) {
        return;
      }

      if (!this._imageIsSelected)
        return;

      this._ChangeColor(color);
    }

    private void _ChangeColor(Color color) {
      this._selectedColor = color; 
      _ColorizeImage(this._image, color);
      this.pbImagePreview.Image = this._image;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      var copy = CopyImage(this._image);
      this._image.Dispose();
      try {
        copy.Save(this._imageFile.FullName);
      } catch {
        copy.Save(this._imageFile.FullName + "1");
      }
    }

    private static void _ColorizeImage(Bitmap image, Color color) {
      var width = image.Width;
      var height = image.Height;

      for (var y = 0; y < height; ++y)
        for (var x = 0; x < width; ++x) {
          var pixel = image.GetPixel(x, y);
          var newColor = Color.FromArgb(pixel.A, color.R, color.G, color.B);
          image.SetPixel(x, y, newColor);
        }
    }

    private static Bitmap CopyImage(Bitmap image) {
      var width = image.Width;
      var height = image.Height;
      var newImage = new Bitmap(width, height);

      for (var y = 0; y < height; ++y)
        for (var x = 0; x < width; ++x) {
          newImage.SetPixel(x, y, image.GetPixel(x, y));
        }

      return newImage;
    }

    private static string _HexConverter(Color c) => "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
  }
}
