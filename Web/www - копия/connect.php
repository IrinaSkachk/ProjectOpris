<?php
	error_reporting(0);
	session_start();
	$db_host = 'localhost';
	$db_user = 'client';
	$db_password = '';
	$db_name = 'ToDoctor';
	
	$link = mysqli_connect($db_host, $db_user, $db_password, $db_name);
	if (!$link) 
	{
    	die('<p style="color:red">'.mysqli_connect_errno().' - '.mysqli_connect_error().'</p>');
	}
	mysqli_query($link, "SET NAMES utf8");
	//echo "<p>Вы подключились к MySQL!</p>";
?>