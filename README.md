# Warehouse Management System

The application is a Visual Basic .NET-based inventory management system designed to facilitate warehouse management and inventory tracking. It provides a user-friendly interface that allows users to view, edit, and manage inventory data, as well as monitor movement history within the warehouse.

## Requirements

- .NET Framework 4.7.2 or higher
- ODBC driver for connecting to the local ERP (Galileo) database.

## Functionality

- Inventory Management: Users can view and edit inventory data, such as product codes, quantities, and locations, using DataGridViews.
- Movement History: The application maintains a record of all movements within the warehouse, enabling users to track the history of inventory items.
- Filtering and Searching: Users can filter and search for specific inventory items based on criteria like product codes and locations, streamlining data access.
- Backup and Restore: The application includes functionality to create database backups and restore data if needed.
- ERP connection allow users to quickly compare the status of wareheose with comparison to data in ERP system

## Usage

1. Run the application.
2. Using password open application in the EDIT mode or without password in PREVIEW mode.
3. PREVIEW mode allow users only to see all the warehouse data including movements history.
4. EDIT mode allow users to add, remove, change, move, modify, inventory and many other options needed for a regular warehouse work. 

## Known Issues

- There might be connectivity issues if the ODBC drivers are not properly installed.
- The application may crash or show unexpected behavior if there are issues with the database connections.
- Some database-specific configurations might cause errors or unexpected results.

## Disclaimer

This project was build especially for a internal company use and it will not work in any other application since it is based on dedicated company software.

## Screenshots
![MAG1](https://github.com/swietlikm/Warehouse_management_system/assets/121583766/6bb58f1c-ffc5-4b83-9963-73abb0e09fe6)
![MAG2](https://github.com/swietlikm/Warehouse_management_system/assets/121583766/8f4baf8e-893e-472a-bf61-ba1d54fcc1fe)
![MAG3](https://github.com/swietlikm/Warehouse_management_system/assets/121583766/d60b3e5b-d4b9-4ca7-ad8b-235d9b958273)
![MAG4](https://github.com/swietlikm/Warehouse_management_system/assets/121583766/a136f63a-f3c2-4758-9dab-43675fb8b9a7)
![MAG5](https://github.com/swietlikm/Warehouse_management_system/assets/121583766/cf5c26ee-7d95-4a63-9a5d-c52273590a3e)
![MAG6](https://github.com/swietlikm/Warehouse_management_system/assets/121583766/cf2af5a9-8110-4961-8804-73bf9ccd5dfc)

