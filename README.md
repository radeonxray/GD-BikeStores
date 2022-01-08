#### Hello and welcome to the BikeStore!

As our new Jr. Full Stack Developer for this exciting and hip new company, we want you to lay the foundation for our new internal website so we can better manage our business!

We have taken the liberty of creating this mini-startup-project using *.Net Framework 4.7.2* and supplied you with our SQL Database (Based on a *SQL 2019 Server*), and we have also already created an **EntityModel** of the Database called *BikeStoresEntity* in this project.
You should only thefor need to setup your SQL Database (online or local, your choice) with the provided database (Found in the Database-folder, both as SQL Scripts and as a backup that you can easily restore) and connect it with this project to get started! You'll find the Connection-string in the **Web.config-file**.
And if you are curious, we have gone with a *Database-first strategy*.

To start with, we need 5 new pages:
* Products
* Orders
* Customers
* Staff
* Stores

All pages should be accessible from the navigation bar.

Each page presents its own individual challenges (and they get more detailed and convoluted, the deeper you get into them, and some might even cross with each other!), so there is plenty of work to get done!


 ***A few final details***
Unless otherwise stated in the objective, you are free to do UI/design wise whatever you feel like (Just promise us not to make us dizzy, please! We have been bike riding through the Seirra Mountains recently...)

Please keep in mind that we do not expect you to finish all the objectives or even single pages. We are looking for your work style, structuring, problem solving skills, documentation, maintainability and thoughts on each objective.

Whether you want to stick only to using the EntityFramework for interacting with the database, or perhaps want to use raw SQL queries, something third, or a mix of different approaches, that is also totally up to you.

Feel free to also come up with your own ideas, additions, features and functions to the system!

***Have fun (: !***

---

* **Products-page**
     **1: Display and list products with the following information:**
                 -Product ID
                - Product Name
                - Brand Name
                - Category Name
                - Model Year
                - List Price

    **2: Add the following data to be displayed on the right side of the previous objective:**
                - Quantity of the product

    **3: If the product is in-stock, make it possible to see what stores have the product in-stock and how many.**

     **4: Add the following data to be displayed on the right side of the previous objective:**
                - Make a clickable URL-link named "Orders", that when clicked takes the user to the "Orders"-page and displays all the orders that have that product in it/them.

    **5: Make it possible to increase/decrease the quantity of products in each store**

     **6: Make it possible to search for products and display them, based on:**
        - Product ID
        - Product Name
        - Brand Name
        - Category Name
        - Model Year
        - Price Range (Minimum - Highest)
        - In Stock

    **6: Make it possible to add new products!**
        - Product ID should be assigned automatically by the system
        - Product Name, Brand Name, Category Name, Model Year and List Price are mandatory fields and cannot be left empty when saved

     **7: Make it possible to Edit a product**
        - Product ID cannot be edited
        - Product Name, Brand Name, Category Name, Model Year and List Price are mandatory fields and cannot be left empty when saved

---

   * **Orders-page**
         **1: Display and list all orders, with the following information:**
            - Order ID
            - Customer ID
            - Customer Name
            - Order Status (1 = Pending; 2 = Processing; 3 = Rejected; 4 = Completed)
            - Order Date
            - Required Date
            - Shipped date
            - Store Name
            - Staff Last name + First Name

        **2: Make it possible to create new orders**

        **3: Make it possible to Edit orders**
            - Only orders of status 1(pending) can be edited

        **4: Display and list all orders (and their details) for a specific customer**

        **5: Display and show all order by a specific staff member**

        **6: Show all orders by aspecific store**

        **7: Make it possible to display and list orders, filtered by Dates**

      **8: Bonus: Initials (See "Staff"-pages assignments  )**
        - Replace the "Staff Last name + First Name" with the staff members initials

---

 * **Customers-page**
        **1: Display and list all customers, with the following information:**
            - CustomerID
            - First Name
            - Last Name
            - Phone
            - Email
            - Street
            - City
            - State
            - ZipCode

    **2: Make it possible to search for and display customers**

    **3: On the right side of the information in Objective-1, create a field named "Show Orders", that when clicked, takes the user to the Orders-page and shows all the orders for that specific customer**

    **4: Make it possible to add new customers**

    **5: Make it possible to edit customers**

    **6: Make it possible to delete or anonymize customers**

---
  * **Staff-Page**
        **1: Display and list all the staff members with the following data:**
            - Staff ID
            - First Name
            - Last Name
            - Email
            - PhoneNumber

    **2: Add the following data to be displayed and listed on the right side of the previous objective:**
        - Active status of the staff
        - Name of the Store the staff is working at
        - The initials of the staffs Manager
            - If the staff has no manager, the value should be either "Founder" or "Owner"
            - Each managerid is corrensponding to a staff id

    **3: Make it possible to search for and display/list specific staff, based on:**
        - Staff ID
        - First Name
        - Last Name
        - Email
        - PhoneNumber
        - Store Name
        - Manager

    **4: On the right side of the previous objective:**
        - Create a url-link named "Show Orders" that when clicked takes the user to the "Orders"-page and shows
        all the orders that the staff member is attached to.
            - Bonus: Instead of "Show Orders", the URL link should directly state how many orders the the staff
            member has done ("when clicked"-function should not be changed)
                - Ex: "20 Orders"

    **5: On the "Store Name"-element on the staff member:**
        - If clicked, the user should be nagivated to the "Stores"-page and only be presented with that
        stores information.
        - If the user hoovers the mouse of the element, the stores address and phonenumber should be displayed

    **6: Make it possible to create new staff members**
        - Staff ID should be automatically assigned by the system
        - First Name, Last Name, Email and Phone Number, store number, manager_id should be mandatory
        information/fields

    **7: Make it possible to edit a staff member!**
        - Staff ID cannot be edited
        - First Name, Last Name, Email and Phone Number, store number, manager_id cannot be left or saved empty

    **8: Make it possible to delete or anonymize staffers**
        - If a staff member is deleted, their records of orders etc. must not be deleted or in any way altered!

    **9: BONUS**
        - Make it possible to add "Initials" to each Staff member
            - Initials should be 3-4 Chars long.
            - Cannot be empty or null

---
 * **Stores-page**
     **1: Display and list all stores with the following information:**
        - Store ID
        - Store Name
        - PhoneNumber
        - Email
        - Street
        - City
        - State
        - Zip Code

    **2: On the right side of the prevoius objective:**
        - Display a clickable URL link titled "Store Staff", that when clicked, takes the user to the "Staff"-page and only displays the staff for that store
            - Bonus: Instead of being titled "Store Staff", the link should tell how many staff members are employed at the store ("When clicked"-function should not be changed)
                - Ex: "3 Staffers"

    **3: On the right side of the previous objective:**
        - Display a clickable URL link titled "Inventory", that when clicked, takes the user to the "Products"-page and only shows/displays/list the products that are actually in stock in for that specific store.

    **3: Make it possible to add new stores!**
        - Store_id should be assigned automatically by the system
        - Store name, phone, email, street, city, state, zip code should be mandatory

    **4: Make it possible to edit a store!**
        - Store_id should not be editable
        - Store name, phone, email, street, city, state, zip code cannot be left or saved empty

    **5: Make it possible to delete/remove a store!**
        - If a store gets closed, we cannot just throw, give away for free, discard or write off their remaining inventory!
        - How the remaining inventory gets distrubted and to what stores, that is up to you!

---

We look forward to see your work and progress in the very near future!

**Best Regards**

*The Bike Store Management*

---

**Hand-in:**

**Github:**
Upload your solution to Github and send a link to the repo to Kewin (kp@mentordanmark.dk) and Christian (cheo@mentordanmark.dk)

**Zip:**
You can also zip your solution and send the project as an attachment to Kewin (kp@mentordanmark.dk) and Christian (cheo@mentordanmark.dk)

If yo have made any additions, edits or changes to the actual Database, then please remember to also include the queries in your hand-in, so we can run them on our version (Do not send us your entire database, we only want the queries that apply the changes).  
