# MindboxAreaFinder
Библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам

#Интерфейсы
## IFigure
Интерфейс, описывающий общие параметры всех фигур, вроде площади, периметра и т.п.
## IFigureByPoints
Интерфейс, описывающий фигуры, которые задаются списком последовательности точек.
## IFigureBySides
Интерфейс, описывающий фигуры, которые задаются списком длин сторон.

#Фигуры
## Circle
Простой круг, на данный момент можно найти лишь его площадь.
## Polygon
Произвольный многоугольник, заданный точками, можно найти его площадь формулой Гаусса.
## Triangle
Произвольный треугольник, заданный длинами его сторон, можно найти его площадь и проверить, является ли он правильным.

##Тесты
# CircleTests
Тесты кругов
# PolygonTests
Тесты многоугольников
# TriangleTests
Тесты треугольников
