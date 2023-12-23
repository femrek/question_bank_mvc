# Question Bank
Question Bank is a .Net MVC applicaiton that allows users to create and solve multiple choice questions with four options. Morever, the user can see the list of added questions. Also, user can view a random question as well as picking a question by selecting from the questions list.

## Project Terminology
- **Question:** refers to question that includes title, content and options.
- **Viewer:** the page for presenting a question.
- **Editor:** the form page for adding new questions.

## Project Architecture
- Endpoints
  - / 
    - Home Page.
  - /AllQuestions
    - Page for listing all questions added so far.
  - /Question/{id?}
    - Page for viewing a question with given id. If id is not given, shows a random question.
  - /AddNewQuestion
    - A form page for adding a new question.

- Controllers
  - Home
    - GET Index
      - Returns home index view
  - Question
    - GET Index
      - Returns question index view
    - GET Viewer
      - Returns question viewer view
    - GET Editor
      - Returns question editor view
    - POST Editor
      - Validates and saves the data recived from the request

- Views
  - Home
    - Index
      - Shows three buttons (1. add question, 2. show random question, 3. list all questions).
  - Question
    - Index
      - List all questions.
    - Editor
      - Create new question.
    - Viewer
      - Show single question.

- Models
  - QuestionModel
    - Keeps a singular question data. This is used for storing questions in database as well.

## Used Technologies
The project developed around .NET core 7 framework as an MVC application.

- UI
  - bootstrap 5
- Database
  - SQLite 3

