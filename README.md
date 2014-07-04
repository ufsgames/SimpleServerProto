SimpleServerProto
=================

Протокол общения сервера с клиентами для тестового задания



Необходимо написать сервер, управляющий раздачей печенек. Общение клиента с сервером происходит по имеющемуся протоколу (необходимо скачать проект из данного репозитория, собрать библиотеку и добавить в свой проект). Данные хранить в любой встраиваемой БД (например, sqlite). Предусмотреть логирование.

Сценарий работы сервера:
1. считываются настройки сервера из файла server_settings.xml;
2. сервер биндится на указанные ip и порт;
3. сервер слушает входящие команды от клиентов и обрабатывает их.

При соединении клиент присылает команду **RequestAuthorization**. Если в базе есть указанный логин, проверяется правильность связки логин/пароль. Если всё правильно, берётся информация из базы. Если такого логина в базе нет - регистрируется новый (с указанными в команде параметрами). В зависимости от этих условий сервер посылает ответ (**ResponseAuthorization**). В команде указано, сколько у юзера денег и какие печеньки он уже купил ранее.
После авторизации клиент сразу же получает список имеющихся на сервере печенек с указанием их стоимости (**ResponseCookieList**) и потом может купить некоторое количество печенек (**RequestBuyCookie**). В ответ на запрос покупки присылается команда **ResponseBuyCookie**.

В случае, если запрашиваемое действие сделать невозможно (не подходит пароль, недостаточно денег) заполнять соответствующие поля Error и ErrorMessage в командах-ответах.

Результат работы залить на github либо bitbucket. Плюсом будет отображение этапов работы (коммит хотя бы раз в день, а лучше - после каждой выполненной фичи), а не один коммит с итоговым результатом задания.
