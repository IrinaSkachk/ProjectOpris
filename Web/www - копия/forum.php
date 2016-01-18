<?php include "connect.php"; ?>
<!DOCTYPE HTML>
<html>
<head>
    <meta charset="utf-8">
    <title>Электронная регистратура</title>
    <link rel="stylesheet" href="forumstyle.css">
</head>
<body> 
 <div class="wrapper">
	<div class="main-head">
        <div class="main-head__logo">
            <img src="img/logo1.png" alt="logo"/>
        </div> 
    </div>
    <div class="main-page__line1">
         <div class="main-menu">
            <a href="/index.php" class='b-link b-link_menu' >ГЛАВНАЯ</a>
            <a href="/record.php" class='b-link b-link_menu' >ЗАПИСАТЬСЯ НА ПРИЕМ</a>
            <a href="/recepts.php" class='b-link b-link_menu'>ИСТОРИЯ ПРИЕМОВ</a>
            <a href="/forum.php" class='b-link b-link_menu'>ФОРУМ</a>
        </div>  
    </div>
  <div class="content block-1"> 
	<?php
	if (!empty($_SESSION['login']))
	{
		?>
		<form method="post" action="forum.php" name="commentform" id="commentform"> 
			<p>Ваш отзыв о сервисе:</p> 
			<p><textarea name="comment"></textarea></p>
			<button type="submit" name="button"> Отправить </button>
		</form>  
		<?php
		if( isset( $_POST['button']) & !empty($_POST['comment']))
		{
			$d = date("Y-m-d");  
			$t = date("H:i:s"); 
			$sql = "INSERT INTO forum (login, message, date, time) VALUES('".$_SESSION[login]."', '".$_POST['comment']."', '".$d."', '".$t."')";
			mysqli_query($link, $sql);
			//var_dump($sql);
		}
	}
	else
	{
		echo "<p>Для того, чтобы оставить ваше сообщение, вам необходимо <br><a href=\"index.php\"> авторизоваться</a></br></p>";  
	}
	?>
    
  </div>
  <div class="content block-2">
    <?php
    $sql = "SELECT login, message, date, time
			FROM forum
			ORDER BY date DESC, time DESC";
	$forum = mysqli_query($link, $sql);
	echo "<table class='comment'>";
	while($row = mysqli_fetch_array($forum))
	{
		echo "<tr>";
		echo "<th><p>".$row['login']." <br> ".$row['date']." ".$row['time']."</br></p></th>";
		echo "<td><p>".$row['message']."</p></td>";
		echo "</tr>";
	}
	echo "</table>";
	
	?>
  </div>
 </div>
</body>
</html>