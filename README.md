# ORM домашней библиотеки
## Запросы для проверки:
GET
- /api/author - список всех авторов из БД.
- /api/author/{id} - автор определенного id.
- /api/book - список всех книг библиотеки.
- /api/book/{id} - книга определенного id.
- /api/book/title/{str} - поски книги по названию.
- /api/author/for-book/{id} - список авторов книги по её id.

POST
- /api/author - добавление нового автора в БД.

DELETE 
- /api/author/{id} - удаление автора по id.
