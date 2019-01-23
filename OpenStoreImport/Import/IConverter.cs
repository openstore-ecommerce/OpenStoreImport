﻿using System.Collections.Generic;
using NBrightDNN;
using ZIndex.DNN.OpenStoreImport.Model.Store;

namespace ZIndex.DNN.OpenStoreImport.Import
{
    public interface IConverter
    {
        /// <summary>
        /// To the image path.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <param name="store">The store.</param>
        /// <returns></returns>
        string ToImagePath(Product product, Store store);

        /// <summary>
        /// To the image base URL.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <param name="imageBaseUrl">The image base URL.</param>
        /// <returns></returns>
        string ToImageBaseUrl(Product product, string imageBaseUrl);

        List<NBrightInfo> CreateCategoryElements(Category category, Store store);
        List<NBrightInfo> CreateProductElements(Product product, Store store);
    }
}