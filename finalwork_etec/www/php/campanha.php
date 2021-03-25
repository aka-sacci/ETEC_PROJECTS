<?php


header("Access-Control-Allow-Origin: *");
header("Content-Type: apllication/json; charset=utf-8");

include('dados_conexao.php');

try {

        $id = $_GET['id'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
            $conecta->exec("set names utf8");

		$consulta = $conecta->prepare("select * from tb09_campanhas inner join tb01_ongs on tb09_campanhas.tb09_ong = tb01_ongs.tb01_cnpj where tb09_id = $id");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb09_descricao":"' . $registro['tb09_descricao']  . '",';			
			$StringJson .= '"tb09_nome":"' . $registro['tb09_nome']  . '",';			
			$StringJson .= '"tb09_status":"' . $registro['tb09_status']  . '",';					
			$StringJson .= '"tb09_datainicio":"' . $registro['tb09_datainicio']  . '",';					
			$StringJson .= '"tb09_datafim":"' . $registro['tb09_datafim']  . '",';					
			$StringJson .= '"tb09_ong":"' . $registro['tb09_ong']  . '",';					
			$StringJson .= '"tb01_nome":"' . $registro['tb01_nome']  . '",';					
			$StringJson .= '"tb09_objetivo":"' . $registro['tb09_objetivo'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>