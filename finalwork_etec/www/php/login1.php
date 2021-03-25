<?php

header("Access-Control-Allow-Origin: *");
header("Content-Type: apllication/json; charset=utf-8");

include('dados_conexao.php');

try {

        $login = $_GET['login'];
        $senhaa = $_GET['senha'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
            $conecta->exec("set names utf8");

		$consulta = $conecta->prepare("select * from tb08_user where tb08_id=$login and tb08_senha = '$senhaa'");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb08_nome":"' . $registro['tb08_nome']  . '"}';			
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>
