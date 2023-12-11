# web_assignment_2023

- Controller
  - Home
    - GET Index -> returns home index view
    - // get random question -> finds a random question and routes the question viewer view
  - Question
    - GET Index -> returns question index view
    - GET Editor -> returns question editor view
    - GET Viewer -> returns question viewer view
    - // post submit editor form -> validates and saves the data recived from the request
    

- View
  - Home
    - Index -> shows three button (1. add question, 2. show random question, 3. list all questions)
  - Question
    - Index -> list all questions
    - Editor -> create new question
    - Viewer -> show single question
