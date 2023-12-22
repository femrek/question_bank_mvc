# web_assignment_2023

- Controller
  - Home
    - GET Index -> returns home index view
  - Question
    - GET Index -> returns question index view
    - GET Viewer -> returns question viewer view
    - GET Editor -> returns question editor view
    - POST Editor -> validates and saves the data recived from the request


- View
  - Home
    - Index -> shows three button (1. add question, 2. show random question, 3. list all questions)
  - Question
    - Index -> list all questions
    - Editor -> create new question
    - Viewer -> show single question
