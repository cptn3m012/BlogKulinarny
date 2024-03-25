# Culinary Blog Project

## Introduction

The Culinary Blog Project is a web application designed to serve as a dynamic platform for culinary enthusiasts. It integrates functionalities for users to register, login, and engage with a curated collection of recipes through comments and ratings. This interactive platform not only allows for the sharing and discovery of culinary art but also incorporates an admin panel for effective content management and moderation, ensuring a high-quality experience for all users. Built on the MVC architecture with technologies like Entity Framework Core and Bootstrap, this project is a testament to modern web application development practices, offering a seamless, user-friendly interface for both culinary enthusiasts and administrators.

## Clone and install
To get started with the Culinary Blog Project on your local machine, follow these steps:
1. **Clone the repository**
```bash
git clone https://github.com/yourusername/culinary-blog-project.git
cd culinary-blog-project
```
2. **Install dependencies**
   
Ensure you have .NET Core SDK and SQL Server Management Studio installed on your machine. Then, navigate to the project directory and install the required dependencies.
```bash
dotnet restore
```
3. **Set up the database**
   
Configure your SQL Server connection parameters in the appsettings.json file and apply migrations to set up your database.
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. **Run the application**
   
Start the application with the following command. It will be accessible on your local development server.
```bash
dotnet run
```
Visit http://localhost:5000 in your web browser to view the application.

## Features

- **Registration and Login**: Allows users to create a new account and log in to the application.
- **Recipe Browsing**: Users can access a list of culinary recipes displayed on the homepage after logging in.
- **Recipe Management**: Logged-in users can add, edit, and delete their recipes.
- **User Interaction**: Users can add comments to recipes, express their opinions, and rate them.
- **Account Management**: Registered users can manage their personal data from the user panel.
- **Admin Panel**: Enables administrators to manage content, moderate comments, approve new users, and edit or delete recipes.

## Technologies Used
* MVC Architecture: Separates the application logic, UI, and input control, facilitating easy management and maintenance.
* Entity Framework Core: For object-relational mapping, enabling efficient data access and manipulation.
* Bootstrap: Provides a responsive design, ensuring the application is accessible on various devices.
* NET Core SDK: Offers a development platform for creating high-performance web applications.


<h2>Contributors</h2>
<ul>
    <li><a href="https://github.com/cptn3m012">cptn3m012</a></li>
    <li><a href="https://github.com/Desi451">Desi451</a></li>
    <li><a href="https://github.com/trimplexx">trimplexx</a></li>
    <li><a href="https://github.com/BubbleWaffle">BubbleWaffle</a></li>
    <li><a href="https://github.com/Maffias">Maffias</a></li>
  
</ul>

## License
This project is open-sourced under the MIT License.

