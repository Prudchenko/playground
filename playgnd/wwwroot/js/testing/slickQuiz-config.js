// Setup your quiz text and questions here

// NOTE: pay attention to commas, IE struggles with those bad boys

var quizJSON = {
    "info": {
        "name":    "Тест для примера",
        "main":    "<p>Описание теста в начале. Какой-то текст здесь.</p>",
        "results": "<h5>По окончанию теста</h5><p>Описание теста в конце. Информация для пользователя о прохождении теста и сохранении его результатов.</p>",
        "level1":  "",
        "level2":  "",
        "level3":  "",
        "level4":  "",
        "level5":  "" // no comma here
    },
    "questions": [
        { // Question 1 - Multiple Choice, Single True Answer
            "q": "What number is the letter A in the English alphabet?",
            "a": [
                {"option": "8",      "correct": false},
                {"option": "14",     "correct": false},
                {"option": "1",      "correct": true},
                {"option": "23",     "correct": false} // no comma here
            ],
            "correct": "<p><span>Ответ верный</span></p>",
            "incorrect": "<p><span>Ответ неверный</span> It's the first letter of the alphabet. Did you actually <em>go</em> to kindergarden?</p>" // no comma here
        },
        { // Question 2 - Multiple Choice, Multiple True Answers, Select Any
            "q": "Which of the following best represents your preferred breakfast?",
            "a": [
                {"option": "Bacon and eggs axaxaxaxaxax",               "correct": false},
                {"option": "Fruit, oatmeal, and yogurt",   "correct": true},
                {"option": "Leftover pizza",               "correct": false},
                {"option": "Eggs, fruit, toast, and milk", "correct": true} // no comma here
            ],
            "select_any": true,
            "correct": "<p><span>Ответ верный</span></p>",
            "incorrect": "<p><span>Ответ неверный</span> You might want to reconsider your options.</p>" // no comma here
        },
        { // Question 3 - Multiple Choice, Multiple True Answers, Select All
            "q": "Where are you right now? Select ALL that apply.",
            "a": [
                {"option": "Planet Earth",           "correct": true},
                {"option": "Pluto",                  "correct": false},
                {"option": "At a computing device",  "correct": true},
                {"option": "The Milky Way",          "correct": true} // no comma here
            ],
            "correct": "<p><span>Ответ верный</span></p>",
            "incorrect": "<p><span>Ответ неверный</span> You're actually on Planet Earth, in The Milky Way, At a computer. But nice try.</p>" // no comma here
        },
        { // Question 4
            "q": "How many inches of rain does Michigan get on average per year?",
            "a": [
                {"option": "149",    "correct": false},
                {"option": "32",     "correct": true},
                {"option": "3",      "correct": false},
                {"option": "1291",   "correct": false} // no comma here
            ],
            "correct": "<p><span>Ответ верный</span></p>",
            "incorrect": "<p><span>Ответ неверный.</span> Sorry. You lose. It actually rains approximately 32 inches a year in Michigan.</p>" // no comma here
        },
        { // Question 5
            "q": "Is Earth bigger than a basketball?",
            "a": [
                {"option": "Yes",    "correct": true},
                {"option": "No",     "correct": false} // no comma here
            ],
            "correct": "<p><span>Ответ верный</span></p>",
            "incorrect": "<p><span>Ответ неверный</span> What planet Earth are <em>you</em> living on?!?</p>" // no comma here
        } // no comma here
    ]
};
