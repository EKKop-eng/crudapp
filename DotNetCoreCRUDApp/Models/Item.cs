<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Items List</title>
</head>
<body>
    <h1>Items List</h1>

    <!-- Link to add a new item -->
    <a href="/Home/Add">Add New Item</a>

    <!-- List of items from the database -->
    <ul>
        <!-- Loop through the items and display them -->
        <li>Item 1 <a href="/Home/Delete/1">Delete</a></li>
        <li>Item 2 <a href="/Home/Delete/2">Delete</a></li>
        <li>Item 3 <a href="/Home/Delete/3">Delete</a></li>
    </ul>
</body>
</html>
