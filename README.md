# OpenStoreImport User guide
## File and folder structure
Let’s say you’ve a root folder – called ‘Root’ – containing subfolders and pictures:
![Folders](docFolder.png "Folders")

The root folder name will be used as the name of the root category when imported in the store.
The subfolders will be used as the name of subcategories in the store.
The pictures will be used as product in the store. The picture filename is used as the product and model name, the picture is used as the image of the product.
## The import tool
Start the import tool:
![Import Tool Main Window](docMainWindow.png "Import Tool Main Window")

Fill or select the root folder, and click “Generate”
Two files are generated:
* Root.xml: The Open Store import file containing the definitions of all the categories and products
* Root.zip: a zip file containing all the pictures
## Open Store import
Import those two files using the Open Store Import module:
![Open Store Backoffice Import screen](docOpenStoreImportModule.png "Open Store Backoffice Import screen")

All the Products are created, for instance here the pictures 0.jpg, 1.jpg, 111.jpg:
![Open Store Backoffice Catalog screen](docOpenStoreCatalog.png "Open Store Backoffice Catalog screen")

And are associated with their corresponding category, for instance the picture 111 from the subfolder Path11:
![Open Store Backoffice Product screen](docOpenStoreProduct.png "Open Store Backoffice Product screen")


