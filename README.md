**Задача:** 

*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*.

**Решение задачи**:

1. Создаём запрос пользователю - "укажите количество элементов в создаваемом массиве";
2. Введённый пользователем текст преобразуем в число;
3. Массив будет заполняться пользователем с клавиатруы. Прописываем метод для заполнения массива (тип метода - string);
4. Вызываем данный метод для заполнения массива, добавляем команду для вывода заполненного массива на экран;
5. Прописываем метод по подсчёту количества элементов массива длиной 3 и менее символов (тип метода - integer). 
6. Создаём пустой массив типа string, длина которого определется результатом вызова метода, описанного в предыдущем пункте;
7. Прописываем метод по заполнению созданного пустого массива элементами длиной 3 и менее символов из массива, заполненного пользователем, и выводу данного массива на экран. Метод принимает на вход два созданных массива. Тип метода - void.
8. Прописываем команду, которой будет вызываться метод, описанный в предыдущем пункте.