﻿using System.Globalization;
using System.IO;
using ZIndex.DNN.OpenStoreImport.Logger;

namespace ZIndex.DNN.OpenStoreImport.Import
{
    public class ImportManager
    {
        private readonly ILog _log = new LoggerBase(typeof(ImportManager)).Logger;
        private readonly IStoreParser _storeParser;
        private readonly IImportFileGenerator _importFileGenerator;
        private readonly IZipFileGenerator _zipFileGenerator;

        public ImportManager(IStoreParser storeParser, IImportFileGenerator importV2FileGenerator, IZipFileGenerator zipFileGenerator)
        {
            _storeParser = storeParser;
            _importFileGenerator = importV2FileGenerator;
            _zipFileGenerator = zipFileGenerator;
        }

        public void GenerateImportFiles(string rootPath, CultureInfo culture, string imageBasePath, string imageBaseUrl,
            decimal productUnitCost, bool generateZip)
        {
            var store = _storeParser.Parse(rootPath, culture, imageBasePath, imageBaseUrl, productUnitCost);
            var xmlFilename = Path.Combine(rootPath, string.Concat(Path.GetFileNameWithoutExtension(rootPath), ".xml"));
            var zipFilename = Path.Combine(rootPath, string.Concat(Path.GetFileNameWithoutExtension(rootPath), ".zip"));

            _log.Info("Generating file {0}", xmlFilename);
            using (var writer = File.CreateText(xmlFilename))
            {
                _importFileGenerator.Generate(writer, store);
            }

            if (generateZip)
            {
                _log.Info("Generating zip file {0}", zipFilename);
                _zipFileGenerator.Zip(zipFilename, rootPath, "*.jpg", true);
            }
            else
            {
                _log.Info("Zip file generation skipped");
            }

        }
    }
}