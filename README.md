# Address Book
## Created by Olena Kuchko

### Description
An app that allows user to create and store contact information such as contact's name, phone number and address. Also user can add groups to address book and link contacts to this groups. User also is able to clear whole address book or just delete particular contact.

### Installation
1. Download or clone the repository from https://github.com/LenaKuchko/address-book.git.
2. Using PowerShell (for Windows), navigate to the directory in which you downloaded project, then run dnx kestrel to run server.
3. In your Web-browser enter - localhost:5004.
4. If you want to work with program code install Mono (http://www.mono-project.com/download/) and Nancy framework (http://nancyfx.org/).
5. Using IDE of your choice to open code.

### Known Bugs
No strict rules for phone Number input.
If user created an empty contact he is not able to delete it.

### Specifications

| Behavior | Input | Output |
|----------|-------|--------|
| App starts | localhost:5004 | Display "index.cshtml" |
| App allows user to create new group | "Family"| Create new group named "Family" and display it in select control |
| App allows user to create new contact| "Leo" | Create new contact with name "Leo" and display it |
| App return user to home page | Click event ok "Home" link | Display "index.cshtml" |
| App allows user to clear Address Book | Click event "Clear Address Book" button | App delete all contacts and display to user confirmation "There is no contacts in the AddressBook" |
| App allows user to delete particular contact | Click event on "Delete this contact" button |App delete contact and return user to home page |
| App allows user to find contact | select group "By Name", "Leo"| App display information about contact with name "Leo"|


#### License
This project is licensed under the MIT License.
Copyright (c) 2017  Olena Kuchko
