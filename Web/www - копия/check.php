<?php
	$serverName = "PC";
	$connectionInfo = array("Database"=> "ToDoctor" );
	$conn = sqlsrv_connect( $serverName, $connectionInfo);
	if( $conn )
	{
		echo "Успешно соединено к MS SQL.\n";
	}
	else
	{
		echo "Невозможно соединиться к MS SQL.\n";
	}
	sqlsrv_close( $conn);
	
	$link = mysqli_connect('localhost', 'root', 'root');
	if ($link) 
	{
		echo "Успешно соединено к MySQL.\n";
	}
	else
	{
		echo "Невозможно соединиться к MySQL.\n";
		die( print_r( mysqli_connect_error(), true));
	}
	
	printf("О хосте: %s\n", mysqli_get_host_info($link));
	
	mysqli_close($link);
?>