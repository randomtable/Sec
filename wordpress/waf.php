<?php
$_REQUEST = str_ireplace("select", "", $_REQUEST);
$_REQUEST = str_ireplace("update", "", $_REQUEST);
$_REQUEST = str_ireplace("insert", "", $_REQUEST);
$_REQUEST = str_ireplace("delete", "", $_REQUEST);
$_REQUEST = str_ireplace("embed", "", $_REQUEST);
$_REQUEST = str_ireplace("objectClass", "", $_REQUEST);
$_REQUEST = str_ireplace("trace", "", $_REQUEST);
$_REQUEST = str_ireplace("..", "", $_REQUEST);
$_GET = str_ireplace("select", "", $_GET);
$_GET = str_ireplace("update", "", $_GET);
$_GET = str_ireplace("insert", "", $_GET);
$_GET = str_ireplace("delete", "", $_GET);
$_GET = str_ireplace("embed", "", $_GET);
$_GET = str_ireplace("objectClass", "", $_GET);
$_GET = str_ireplace("trace", "", $_GET);
$_GET = str_ireplace("..", "", $_GET);
$_POST = str_ireplace("select", "", $_POST);
$_POST = str_ireplace("update", "", $_POST);
$_POST = str_ireplace("insert", "", $_POST);
$_POST = str_ireplace("delete", "", $_POST);
$_POST = str_ireplace("embed", "", $_POST);
$_POST = str_ireplace("objectClass", "", $_POST);
$_POST = str_ireplace("trace", "", $_POST);
$_POST = str_ireplace("..", "", $_POST);
        
?>