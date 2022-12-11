# Выбор специализации.
## Контрольная работа.

Программа состоит из трех функциональных блоков:

1. Блок ввода исходного массива. Сначала пользователю предлагается ввести количество строк - элементов массива. При некорректном вводе выполняется обработка исключения. Далее циклически предлагается ввести сами строки.

2. Создается результирующий массив с количеством элементов как у исходного и выполняется цикл обработки исходного массива. На каждом шаге цикла проверяется длина строки - i-го элемента массива и если её длина  меньше или равна трем символам, то строка копируется в результирующий массив. Количество шагов цикла равно количеству элементов исходного массива. По завершении цикла осуществляется удаление пустых элементов результирующего массива.

3. Выполняется вывод на экран содержимого результирующего массива. Каждая строка - элемент массива выводится в двойных кавычках, строки разделяются запятыми.

Каждый функуиональный блок программы реализован в виде метода, вызываемого в процессе выполнения.
Основной метод - CheckAndCopy. 

Блок-схема - в файле bs.png

Thanks, GeekBrains!