Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
Для начала выводится сообщение-приглашение пользователю, где указывается, что он должен ввести число, которое означается количество элементов массива, которое он будет позже вводить.

Первый метод CreateStringArray отвечает за то, чтобы пользователю выводилось сообщение-приглашение, чтобы он ввел элементы массива в консоль.После чего этот метод заносит введенные элементы в массив array.

Метод CountArray отвечает за то, чтобы посчитать количество элементов массива, которое удовлетворяет нашим условиям (а именно длина строки меньше 3 символов). Вводится переменная count, которая изначально равно нулю,. Затем при цикле, перебирающему весь массив, вводится необходимое нам условие, и если условие соблюдается, счетчик count увеличивается на 1. Это необходимо сделать для того, чтобы знать размер нового массива, который создастся в следующем методе и куда будут переноситься нужные нам значения.

Метод ShowArray отвечает за перенос нужных данных из первоначального массива в новый массив, а затем выводит новый массив на экран. Сначала создается новый массив с размером, который мы узнали в прошлом методе. Далее мы добавляем переменную j, которая отвечает за индекс элемента нового массива, и присваиваем ей нулевое значимое, чтобы массив заполняла с самого начала. Далее мы перебираем первоначальный массив с нужным нам условием, и если элемент подходит под наши требования, то он копируется в новый массив, и повышается индекс для возможной записи следующего элемента. В конце метода программа выводит на экран новый массив с уже интересующими нас элементами.

В конце кода мы запускаем все 3 метода с необходимыми для них входными данными.
