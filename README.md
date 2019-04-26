# Bibliotheca

Design of a system for old fashioned libraries from the times when internet access was limited and there were no user accounts for clients. App is supposed to be running on one computer placed behind a desk inside one particular library and used by library employees.

## Business rules

### Users

#### Employee
* Every employee has his own user account - login is required every time before using the app. When leaving workplace -> log off.
* Employee can:
  * Add/Remove client
  * Add/remove item
  * Change contact info of himself and every client.
  * Create/Cancel/Finish reservations.
  * Create/Finish borrows and set *expired borrows* to *finished* state.

#### Admin
* Admin is simply employee with additional rights:
  * Add/Remove employee.
  * Give admin rights to other employees.

#### Client
Client is just passive part of the system since real clients has no access to the app.
