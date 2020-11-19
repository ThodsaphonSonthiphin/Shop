using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.ViewModels
{
    public class PhotoViewModel
    {
        #region Constructor

        public PhotoViewModel(IWebHostEnvironment webHostEnvironment)
        {
            this._iWebHostEnvironment = webHostEnvironment;
        }

        #endregion

        #region Feild

        private IWebHostEnvironment _iWebHostEnvironment;

        private IFormFile _uploadPhoto;
        private Image _photoForShow;

        private string _photoPath;

        #endregion

        #region Property

        [BindNever]
        public string PhotoPath
        {
            get { return this._photoPath;}
            private set { this._photoPath = value; }

        }

        [BindNever]
        public Image PhotoForShow
        {
            get { return _photoForShow;}
            set
            {
                this._photoForShow = value;
            }
        }

        [Required]
        public IFormFile UploadPhoto
        {
            get { return _uploadPhoto; }

            set
            {
                _uploadPhoto = value;
                this.GeneratePhotoPath();
            }

        }

        #endregion

        #region method
        /// <summary>
        /// this method converts file from wwwroot/photo to image for showing in view
        /// </summary>
        /// <param name="path">path of photo file</param>
        public void ConvertPhotoFromPathToFile(string path)
        {
            this._photoForShow = Image.FromFile(_photoPath);
        }
        /// <summary>
        /// private for generate path
        /// </summary>
        private void GeneratePhotoPath()
        {
            string rootpaht = _iWebHostEnvironment.WebRootPath;

            string[] paths = new string[] {rootpaht, "Photo",this._uploadPhoto.FileName};
            
            this.PhotoPath = Path.Combine(paths);
        }

        public void SavePhotoTopath()
        {
            FileStream phoFileStream = File.Create(_photoPath);
            
            _uploadPhoto.CopyTo(phoFileStream);
            
        }

        #endregion
    }
}
