# First-Quarter-Final-Test
Итоговая контрольная работа по основному блоку РАЗРАБОТЧИК (1я четверть обучения GeekBrains)

Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


Описание решения:
1.	Запрос у пользователя ввода строки с элементами, разделенными пробелами
2.	Создание массива строк (inputArray) из введённых пользователем элементов
3.	Создание нового массива (filteredArray) для хранения отфильтрованных по условию задачи элементов.
4.	Проход по каждому элементу массива inputArray и проверка условия: длина элемента меньше, либо равна 3 символам
5.	Если условие выполняется, элемент добавляется в массив filteredArray
6.	Вывод в консоль элементов из массива filteredArray
