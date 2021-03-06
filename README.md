# Автоматизированная автомойка
## `Содержание`
[Введение](#введение)

1 [Описание предметной области](#по)

1.1 [Указание на проблематику](#проблематика) 

1.2 [Формулировка задачи](#формулировка_задачи)

2  [Существующие решения проблемы](#решения_проблемы)

3 [Разработка](#разработка)

3.1 [Проектирование системы](#проектирование)

3.2 [Реализация системы](#реализация)

4 [Тестирование](#тестирование)

[Заключение](#заключение)

[Список литературы](#литература)

***
## Введение <a name ="введение"></a>
Темой проекта является "Автоматизированная Автомойка", позволяет дистанционно выбрать услугис Автомойки и оплатить их. Сегодня это особенно важно, ведь клиенту не придётся лишний раз выходить из автомобиля и контактировать с другими людьми. Это позволяет обеспечить удобство и безопасность для клиента. На сегодняшний день данная информационная система является как никогда актульной в связи с эпидемией коронавируса.
***
## 1 Описание предметной области <a name ="по"></a>
Покупатель, заинтересованный в услугах мойки, заходит на сайт и выбирает нужные ему услуги. Он может посмотреть название, описание, цену, тип и рейтинг. Далее он может оплатить их и после завершения процесса мойки поставить свою оценку. Оператор мойки дожидается подтверждения оплаты услуг, запускает робот-мойщика и следит за процессом мойки.
***
  ### 1.1 Указание на проблематику <a name ="проблематика"></a>
В последнее время число заболеваемых коронавирусом постоянно увеличивается. Любые контакты с посторонними людьми подвергают людей опасности. На традиционных мойках клиенты контактируют с кассирами, мойщиками, менеджерами и т.д. Также, часто клиенты традиционных автомоек продолжительное время дожидаются своей очереди, автоматизированная мойка позволяет кратно сократить время ожидания за счёт юолее быстрого и не менее качественного выполнения услуг. Представленная информационная система позволяет удобно выбрать необходимые услуги и оплатить их не выходя из автомобиля, а также дистанционно следить за процессом мойки, чтобы они не подвергали опасности своё здоровье.
***
  ### 1.2 Формулировка задачи <a name ="формулировка_задачи"></a>
  Целью проекта является создание сайта автоматизированной мойки, предоставляющий пользователям удобный и информативный выбор услуг.
  
  Задачи:
  1. Возможность выбрать услуги
  2. Возможность оплатить выбранные услуги
  3. Возможность дистанционно отследить процесс мойки
  4. Возможность оценить качество работы
  ***
## 2 Существующие решения проблемы <a name ="решения_проблемы"></a>
ROBOTCARWASH - новаторы на рынке автоматических роботизированных бесконтактных моек, компания предлагает своим клиентам инновационные решения, включающие высокоэффективное оборудование, чистящие средства, запасные части, а также превосходный сервис и ряд перспективных цифровых продуктов.
Преимущество автомоек – высокая скорость обслуживания и бюджетная стоимость: помыть машину самостоятельно стоит в среднем в два-три раза дешевле, чем на обычной мойке. Это и обеспечивает новой услуге рост популярности.
Автомобилисту, приехавшему на автомойку, достаточно загнать машину на моечный пост, внести деньги в терминал, выбрать операции на аппарате и приступить к мытью авто с помощью копья высокого давления. Оператор может подсказать, как помыть машину дешевле, быстрее и качественнее.
Каждый пост самообслуживания оборудован автоматом со стандартным набором опций:
подача воды под высоким давлением;
активная пена – подготавливает поверхность к мойке;
мытье с шампунем – эффективно удаляет загрязнения;
ополаскивание – удаление моющих средств и остатков загрязнений;
жидкий воск – нанесение полимерных веществ с водоотталкивающими свойствами, облегчающими очищение кузова при последующих мойках;
осмотическая вода – не оставляет разводов при высыхании.
На стандартную мойку машины без излишеств в среднем уходит 100 руб., сюда входит предварительная мойка водой под давлением, нанесение активной пены, ее смывка и финишное ополаскивание.
Кроме основных, автомат снабжен дополнительными опциями: мойка дисков, колес и колесных арок, мойка щеткой с пеной; турбо-пена с усиленным моющим эффектом. Переключение выбранных режимов происходит автоматически.
Контроллеры установлены на каждом посту самообслуживания, они контролируют прием купюр и монет, считывание платежных карт, выбор программ.
Практически у всех роботизированных автомоек вендинговый принцип работы. 
***
## 3 Разработка <a name ="разработка"></a>
***
## 3.1 Проектирование системы <a name ="проектирование"></a>
Разработка информационной системы начинается с построения USE-CASE диаграммы (Диаграмма вариантов использования) , которая состоит из участников и прецендетов.

Участник - это множество логически связанных ролей, исполняемых при взаимодействии с прецедентами или сущностями (система, подсистема или класс). Участником может быть человек или другая система, подсистема или класс, которые представляют нечто вне сущности. Графически участник изображается “человечком”.

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.
![Screenshot_1](https://user-images.githubusercontent.com/92502524/152893509-899315db-2a83-4c26-90f3-b3851ea55f86.png)

На основе USE-CASE диаграммы разрабатвается DFD диаграмма, которая наглядно отображает течение информации в пределах системы.
![Screenshot_2](https://user-images.githubusercontent.com/92502524/152893543-91792d33-33e9-42bd-8572-8753441dbe2e.png)

На основе DFD диаграммы проектируется схема «сущность-связь» (ER-диаграмма), где показано, как разные «сущности» (люди, объекты, концепции и так далее) связаны между собой внутри системы.
![Screenshot_3](https://user-images.githubusercontent.com/92502524/153966650-e2b45eb5-19ad-4c7f-a736-91c8b9430753.png)

***
## 3.2 Реализация системы <a name ="реализация"></a>
***
## 4 Тестирование <a name ="тестирование"></a>
***
## Заключение <a name ="заключение"></a>
Таким образом, разработанная информационная система смогла справиться с некоторыми задачами, поставленными в пункте 1.2. В перспективе предполагается привязаться проект к базе данных, добавить методы для увеличения спектра возможностей работы на сайте.
***
## Список используемой литературы <a name ="литература"></a>
[1] - https://leisuwash.ru/ (дата обращения: 05.12.2021).

[2] - https://itnan.ru/post.php?c=1&p=340064 (дата обращения: 01.12.2021).

[3] - https://www.lucidchart.com/pages/ru/erd (дата обращения: 01.12.2021).

[4] - https://robotcarwash.ru/ (дата обращения: 09.12.2021).

[5] - https://aip.com.ru/article/Avtomoyki_samoobslujivaniya (дата обращения: 10.12.2021).

