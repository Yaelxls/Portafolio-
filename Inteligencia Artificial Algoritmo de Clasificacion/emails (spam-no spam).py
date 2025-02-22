# Para la manipulación y análisis de datos, permite trabajar con estructuras de datos como DataFrames (en este caso para cargar el archivo csv).
import pandas as pd  
# Para visualizaciones gráficas y mapas de calor en Python.
import matplotlib.pyplot as plt  
# Para manejar advertencias; permite ignorar o mostrar advertencias durante la ejecución del código.
import warnings  
# Función que divide un conjunto de datos en conjuntos de entrenamiento y prueba.
from sklearn.model_selection import train_test_split 
# Implementación del clasificador Naive Bayes multinomial, utilizado para problemas de clasificación, especialmente en texto. 
from sklearn.naive_bayes import MultinomialNB  
# Para evaluar el rendimiento de modelos de clasificación.
from sklearn.metrics import confusion_matrix, ConfusionMatrixDisplay # confusion_matrix: crea una matriz que muestra las predicciones correctas e incorrectas.
# Implementación del clasificador Naive Bayes Gaussian
from sklearn.naive_bayes import GaussianNB
# Se utiliza para medir el rendimiento de un modelo de clasificación. Esta función calcula la precisión (accuracy) del modelo, es decir, el porcentaje de predicciones correctas que el modelo hizo en comparación con el total de predicciones.
from sklearn.metrics import accuracy_score
# Implemnetacion del clasificador de bosque aleatorio.   
from sklearn.ensemble import RandomForestClassifier
# Implementar clasificador SVC
from sklearn.svm import SVC
# Para desactivar la aparición de advertencias (warnings) en el código.
warnings.filterwarnings("ignore")

# 1. Cargar el archivo y poder leerlo
datos = pd.read_csv('emails.csv')

# 2. Verificar la estructura del dataset
print(datos.info())
#   Mostrar las 5 primeras filas del archivo
print(datos.head())
#   Mostrar la descripcion del archivo
print(datos.describe) 
#   Revisar valores faltantes
print(datos.isnull().sum())  

X = datos.iloc[:,1:3001]  # Las características del conjunto de datos
Y = datos.iloc[:,-1].values  # La etiqueta de clase (spam o no spam)

entrenamiento_tamaño = 0.3 # 30% de los datos van destinados al entrenamiento
# Dividir el conjunto de datos en entrenamiento (70%) y prueba (30%)
X_entrenamiento, X_prueba, Y_entrenamiento, Y_prueba = train_test_split(X, Y, test_size = entrenamiento_tamaño)

# Función para evaluar el modelo
def evaluar_modelo(modelo, nombre_modelo):
    
    # Entrenar el modelo (X y Y)
    modelo.fit(X_entrenamiento, Y_entrenamiento)

    # Hacer predicciones
    Y_predicho = modelo.predict(X_prueba)

    # Calcular la precisión (accuracy)
    precision = accuracy_score(Y_prueba, Y_predicho)
    print(f"Precisión de {nombre_modelo}: {precision:.4f}")

    # Calcular y mostrar la matriz de confusión
    matriz_confusion = confusion_matrix(Y_prueba, Y_predicho) # Calcula la matriz de confusion que muestra cuantas veces el modelo acerto o fallo
    # Crea una visualización de la matriz usando las etiquetas de clases (spam/no spam)
    visualizacion_matriz = ConfusionMatrixDisplay(confusion_matrix=matriz_confusion, display_labels=modelo.classes_) 
    # Dibuja la grafica en tonos de rojo para resaltar la informacion de la matriz de confusion en pantalla
    visualizacion_matriz.plot(cmap=plt.cm.Reds, values_format='d') # Formato de color de los clasificadores
    plt.xlabel('predecibles') 
    plt.ylabel('verdaderas') 
    plt.title(f'Matriz de Confusión de {nombre_modelo}') #  Titulo de los clasificadores
    plt.show() # Muestra los clasificadores
    # Devuelve el grado de presicion de cada modelos

# Diccionario de los modelos a utilizar
modelos = {
    "Gaussiana Naive Bayes": GaussianNB(),
    "Multinomial Naive Bayes": MultinomialNB(),
    "Bosque Aleatorio": RandomForestClassifier(),
    "SVC": SVC(),
}

# Evaluar todos los modelos
for nombre, modelo in modelos.items():
    evaluar_modelo(modelo, nombre)

# Contar correos spam y no spam
correos_spam = sum(datos['spam']) # Cuenta los correos Spam
correos_no_spam = len(datos) - correos_spam # Resta el total de los correos totales - los correos No-Spam
total_correos = len(datos) # Cuenta el total de los correos
print("\nCorreos spam:", correos_spam) # Imprime Los correos Spam
print("Correos no spam:", correos_no_spam) # Imprime los correos No-Spam
print("Total de correos:", total_correos) # Imprime el total de los correos