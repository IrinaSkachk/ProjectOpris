<?php include "connect.php"; ?>
<!DOCTYPE HTML>
<html>
<head>
    <meta charset="utf-8">
    <title>Электронная регистратура</title>
    <link rel="stylesheet" href="receptstyle.css">
    <script type="text/javascript" src="jquery-1.11.3.min.js"></script>
    <script type="text/javascript" src="script.js"></script>
</head>
<body> 
 <div class="wrapper">
	<div class="main-head">
        <div class="main-head__logo">
            <img src="img/logo1.png" alt="logo"/>
        </div> 
    </div>
    <div class="login"> <p>Здравствуйте, <b><?=$_SESSION['login']?></b>. <a href="logout.php">Выход</a></p> </div>
    <div class="main-page__line1">
         <div class="main-menu">
            <a href="/index.php" class='b-link b-link_menu' >ГЛАВНАЯ</a>
            <a href="/record.php" class='b-link b-link_menu' >ЗАПИСАТЬСЯ НА ПРИЕМ</a>
            <a href="/recepts.php" class='b-link b-link_menu'>ИСТОРИЯ ПРИЕМОВ</a>
            <a href="/forum.php" class='b-link b-link_menu'>ФОРУМ</a>
        </div>  
    </div>
 
<div class="content">
		<?php
		if(!empty($_SESSION['LoggedIn']))  
		{  	
			if ($_GET['script'] == 'y')
			{
				$sql = "DELETE 
						FROM General 
						WHERE (ID_Account = ".$_SESSION['ID'].") and (date = \"".$_GET['date']."\") and (time = \"".$_GET['time']."\") and (ID_Doctor = ".$_GET['doctor'].")";
				//var_dump($sql);
				mysqli_query($link, $sql);
				echo "Удаление";
				echo "<meta http-equiv='refresh' content='2;recepts.php'>";
			}
			else
			{
				if (!empty($_GET['date']) and !empty($_GET['time']) and !empty($_GET['doctor']))
				{ ?>
					<div class= "mainblock"> <?php
					echo "<p>Хотите удалить прием?</p>";
					echo "<p><a href=\"recepts.php?date=".$_GET['date']."&time=".$_GET['time']."&doctor=".$_GET['doctor']."&script=y\" >Удалить</a>  <br>  <a href=\"recepts.php\">Назад</a> </br></p>";
					 ?></div> <?php
				}
				else
				{
					$sql = "SELECT date, time, ID_Doctor 
							FROM General 
							WHERE ID_Account = ".$_SESSION['ID']."
							ORDER BY date, time";
					
					$recepts = mysqli_query($link, $sql);
					echo "<table class='recept'>";
					echo "<tbody>";
						while($row = mysqli_fetch_array($recepts))
						{
							$t = date('H:i', strtotime($row['time']));
							if (date("Y-m-d") <= $row[date])
							{
								echo "<tr><td bgcolor=\"#FFFACD\";><p><a href=\"recepts.php?date=".$row['date']."&time=".$row['time']."&doctor=".$row['ID_Doctor']."\" >".$row[date]." ".$t."</a></p></td></tr>";
							}
							else
							{
								echo "<tr><td bgcolor=\"#6495ED\";><p>".$row[date]." ".$t."</p></td></tr>";
							}
						}
					echo "</tbody>";
					echo "</table>";	
				}
			}
		}
		else
		{
			?>
			<p>Для просмотра истории приемов вам необходимо <a class="enter" href="index.php">войти.</a></p> 
			<?php
		}
		?>
	</div>
 </div>
</body>
</html>