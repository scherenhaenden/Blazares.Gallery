using System.Collections.Generic;
using System.IO;
using Blazares.Gallery.Engine.SeekFiles;
using Blazares.IOServiceDuplicates.Engine.Models;

namespace Blazares.Gallery.Engine.Features
{
    public class UserActions
    {
        public void DeleteDuplicateByPath(string path, string [] extensions)
        {
            var seeker = new Seeker();
            var filesFound = seeker.GetFilesByPath(path, extensions);
            seeker.DeleteDuplicateFiles(filesFound.ToArray());
        }


        public void RenameFiles(List<GeneralFileModel> Files)
        {
            foreach (var VARIABLE in Files)
            {
                
            }
        }


        public string NewFileName(GeneralFileModel file)
        {
            string NewName=file.DateCreation.ToString("yyyy_MM_dd_HH_mm_ss");
            string NewNameFullname=file.DateCreation.ToString("yyyy_MM_dd_HH_mm_ss");
            string filename=file.FileName;
            string directoryname=file.PathOfFile;
            string Extension=Path.GetExtension(file.FullPathOfFile).ToLower();

            return NewName + Extension;
        }
    }
}