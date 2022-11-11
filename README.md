# Итоговая проверочная работа

## *Задача:*

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## *Решение:*
1. Формируем первоначальный массив строк с клавиатуры с помощью метода *Console.ReadLine* и разбивем строки на подстроки, используя мотод *String.Split*.
2. Создаем второй строчный массив, в методе *CreatArray*, который будет формироваться из элементов - строк с длиной меньше либо равной 3-м символам. Формирование массива будет происходить в цикле *for* с проверкой оператора *if* на заданное условие. Одновременно переменная *count* будет осуществлять подсчёт количества элементов массива, подходящих под заданное условие.
3. Выведем элементы третьего массива в консоль с помощью метода *PrintArray*.

Графическое представление метода представлено в виде блок-схемы в файле *scheme.png*.

Реализация алгоритма по пути *Task/Program.cs*.