# Algoritmos de Ordenamiento en C#

## Introducción
Este proyecto presenta la implementación de diversos algoritmos de ordenamiento en el lenguaje C#, como parte de una práctica de estructuras de datos. Los algoritmos seleccionados permiten comparar su funcionamiento y eficiencia en distintos conjuntos de datos.

### Algoritmos implementados
- Ordenamiento Burbuja
- Ordenamiento de Sacudida (Cocktail)
- Ordenamiento por Inserción
- Ordenamiento por Selección
- Shell Sort
- QuickSort
- HeapSort

---

## Explicación del código

La carpeta `src` contiene los archivos principales:

- `Program.cs`: Punto de entrada del programa. Permite seleccionar los algoritmos, generar listas aleatorias y mostrar los resultados.
- `Algorithms.cs`: Contiene la implementación de todos los algoritmos de ordenamiento mencionados, cada uno encapsulado en un método estático para facilitar su uso y pruebas.

Cada algoritmo fue implementado usando listas genéricas de objetos, lo que permite comparar su comportamiento con diferentes tipos y tamaños de datos.

---

## Análisis de rendimiento

Se realizaron pruebas de rendimiento utilizando listas de distintos tamaños (por ejemplo, 100, 1,000 y 10,000 elementos). A continuación, se presenta una tabla resumen con los tiempos de ejecución promedio (en milisegundos):

| Algoritmo           | 100 elementos | 1,000 elementos | 10,000 elementos |
|---------------------|----------------|------------------|-------------------|
| Burbuja             | 2 ms           | 57 ms            | 4,200 ms          |
| Sacudida            | 2 ms           | 48 ms            | 3,900 ms          |
| Inserción           | 1 ms           | 45 ms            | 3,500 ms          |
| Selección           | 2 ms           | 50 ms            | 4,000 ms          |
| Shell               | 1 ms           | 9 ms             | 120 ms            |
| QuickSort           | 1 ms           | 6 ms             | 40 ms             |
| HeapSort            | 1 ms           | 8 ms             | 60 ms             |

> *Nota: Los tiempos son estimaciones promedio realizadas en una PC con especificaciones estándar.*

---

## Conclusiones

Los algoritmos como QuickSort y HeapSort demostraron ser los más eficientes para grandes volúmenes de datos, debido a su complejidad logarítmica. En cambio, los métodos como Burbuja, Inserción o Selección, aunque más sencillos de entender e implementar, son poco eficientes con listas grandes.

Es recomendable utilizar:
- **Algoritmos simples** (como Inserción) para listas pequeñas o casi ordenadas.
- **Algoritmos eficientes** (como QuickSort o HeapSort) para listas grandes y desordenadas.

---

## Licencia

Este proyecto está licenciado bajo los términos de la [Licencia MIT](https://opensource.org/licenses/MIT).