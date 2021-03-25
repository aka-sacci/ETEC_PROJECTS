<?php


header("Access-Control-Allow-Origin: *");
header("Content-Type: apllication/json; charset=utf-8");

include('dados_conexao.php');

try {

        $ong = $_GET['ong'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
            $conecta->exec("set names utf8");

		$consulta = $conecta->prepare("select * from tb10_ongs_campanhas inner join tb09_campanhas on tb10_ongs_campanhas.tb10_campanha = tb09_campanhas.tb09_id where tb10_ong = $ong and tb10_status = 2 order by tb09_status DESC");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb09_id":"' . $registro['tb09_id']  . '",';			
			$StringJson .= '"tb09_nome":"' . $registro['tb09_nome']  . '",';			
			$StringJson .= '"tb09_status":"' . $registro['tb09_status']  . '",';					
			$StringJson .= '"tb09_objetivo":"' . $registro['tb09_objetivo'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>