using System.Collections.Generic;
using Blazares.IOServiceDuplicates.Engine.DeleteDuplicates;
using Blazares.IOServiceDuplicates.Engine.FilesFinder;
using Blazares.IOServiceDuplicates.Engine.Hashers;
using Blazares.IOServiceDuplicates.Engine.Models;

namespace Blazares.Gallery.Engine.SeekFiles
{
    public class Seeker
    {
        public List<string> GetFilesByPath(string path, string []extensions)
        {
            IFilesSeeker filesSeeker = new FilesSeeker();
            return filesSeeker.ByPathAndExtensions(path, extensions);
        }
        
        public List<GeneralFileModel> DeleteDuplicateFiles(string [] files)
        {
            GenerateFiles gf = new GenerateFiles ();
            var allFiles=gf.StringsToModels (files);
            
            return new FileModelDeleteDuplicates(new FileHasherMd5()).Run(allFiles);
        }
    }
}