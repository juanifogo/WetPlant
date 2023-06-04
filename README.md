<p align="center"> <img src=https://github.com/juanifogo/WetPlantFinaPlis/assets/83310328/86655725-0476-4d30-adbd-c43559a39de4 alt="logo" width="500" height=auto> </p>

# WetPlant 

### Version final del proyecto curricular realizado en 2021/2022 como parte de la materia Proyecto del tercer año la Escuela Secundaria ORT Sede Belgrano, oritentacion TIC. Luego fue presentado en la exposición anual de TIC Experience.

El objetivo del proyecto es monitorear varios parametros que afecten la salud de una planta, y compensarlos cuando no se leen valores optimos. Para esto es necesario un sistema que implemente estas funciones electronicamente.

Este repositorio contiene el codigo fuente que utilizaria tanto un Arduino Uno para implementar estas funciones, como la aplicacion de escritorio para Windows con la que se visualizan los valores medidos por el sistema.

En el proyecto contribuyeron:
 - Juan Ignacio F.        - 4° TIC A 2022
 - Joaquim Rodrigo DS. G. - 4° TIC A 2022
 - Francisco Ezequiel M.  - 4° TIC A 2022
 - Max Z.                 - 4° TIC A 2022
 - Joaquin Francisco O.   - 4° TIC A 2022
 - Lucas Felipe C.        - 4° TIC A 2022
 - Tomás S.               - 3° TIC C 2022

Gracias especiales a los profesores de TIC:
 - Rubén K.
 - Carolina K.
 - Ivo Gabriel D.
 - Ignacio P.
 - Paula S.

## Esquematico del circuito
![Diagrama_WetPlant](https://github.com/juanifogo/WetPlantFinaPlis/assets/83310328/eef8f785-b639-4b6a-ab0f-eef90e0a3f8f)

## Diseño del PCB
![wetPlantPCB_Final](https://github.com/juanifogo/WetPlantFinaPlis/assets/83310328/d2c0da3e-b80d-4c63-b47c-591c7daa3163)

Este PCB es un shield para el Arduino Uno, tiene conectados 3 relés con sus respectivos diodos de protección y transistores para activarlos, como también agujeros para soldar los 3 sensores utilizados. También tiene [pines dobles](https://site.gravitech.us/Components/8Fx1L-254mm/8Fx1L-254mm_2R.jpg) para poder conectar de un lado el Arduino Uno y del otro cualquir otro componente que se quiera agregar. Adicionalmente a los reles se les conectan los actuadores que son conmutados en base a los valores medidos por los sensores, estos son una lampara, un ventilador, y una bomba de agua.

## Diseño de la carcasa

![Fogo (1)_page-0001](https://github.com/juanifogo/WetPlantFinaPlis/assets/83310328/aa8c2d34-7b8a-4b09-9cc1-d7862123a2c5)

[Link](https://drive.google.com/file/d/1dOaow93cEQARyGtKCdBopkmLWp9JD1bc/view?usp=sharing) al diseño en illustrator de la carcasa


## Materiales usados
- DHT22 Sensor [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-916742646-modulo-sensor-humedad-relativa-y-temperatura-dht22-arduino-_JM#position=4&search_layout=stack&type=item&tracking_id=27fb12bd-3605-4093-9601-93e2ea8fd124)
- Sensor de humedad de tierra [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-759326593-sensor-humedad-suelo-arduino-modulo-higrometro-tierra-_JM#position=8&search_layout=stack&type=item&tracking_id=542d736d-af95-4325-8ef1-eb0bf36172ac)
- LDR (Light Dependent Resistor) [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-916299762-modulo-sensor-de-luz-con-ldr-fotoresistor-arduino-hobb-_JM#is_advertising=true&position=1&search_layout=stack&type=pad&tracking_id=ac9b6894-34fb-4147-9481-91e54c491f66&is_advertising=true&ad_domain=VQCATCORE_LST&ad_position=1&ad_click_id=MmU4M2I0ZTItMGNkNC00MjI4LTk0NmEtNDFiZmY4ODUxMTk4)
- Lampara de 12v de auto [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-883776432-lampara-12v-5w-posicion-1-polo-x10-_JM#position=23&search_layout=stack&type=item&tracking_id=9c16d91f-fd35-41bd-9ccf-e8ed0c0e661b)
- Bomba de agua [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-785142289-bomba-agua-rs-360sh-motor-3-12v-itytarg-_JM#position=21&search_layout=stack&type=item&tracking_id=bab0cf4e-e94d-4224-96a5-f38957025731)
- Ventilador de PC [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-935964895-ventilador-12v-5010-50x50x10mm-impresora-3d-_JM#position=5&search_layout=stack&type=item&tracking_id=735aea56-b071-41aa-8112-1a4043321e56)
- Arduino Uno [Link Mercado Libre](https://articulo.mercadolibre.com.ar/MLA-1363350191-placa-arduino-uno-r3-smd-atmega328-ch340-robotica-usb-cable-_JM#position=5&search_layout=grid&type=item&tracking_id=aee7d7d0-c067-4ec3-9e1c-bf1e12d00ec9)

Tambien se usaron materiales genericos como fuentes de alimentacion de 12v o 5v para los actuadores, un cable USB Tipo A - USB Tipo B para subir el codigo al rduino Uno y comunicarlo con la aplicación de escritorio, un contenedor para el agua de la bomba, una maceta, tornillos y tuercas para sostener la placa en su lugar, y cables dupont para conectar los sensores desde la placa hasta la maceta.

### Foto de la versión final del dispositivo

![wetplantTICXP](https://github.com/juanifogo/WetPlantFinaPlis/assets/83310328/6fda243c-21c2-4293-9800-a6f2446cfa9c)

## Mejoras a futuro

Este proyecto actualmente no esta siendo desarrollado, pero de serlo, estas son las mejoras que se sugieren.
 - Implementacion de una lampara UV apta para el crecimiento de plantas
 - Implementacion de una valvula que funcione como gotero en vez de una bomba de agua, ya que esta ultima larga el agua con demasiada presion.
 - Implementacion del monitoreo remoto de los sensores.
 - Implementaciond en un regulado ajustable al tipo de planta.
 - Implementacion de un sistema de alimentacion más sofisticado, que pueda no depender de la red electrica sino baterías.
 - Medición del pH de la tierra. 
