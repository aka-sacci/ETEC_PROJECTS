<?php


header("Access-Control-Allow-Origin: *");
header("Content-Type: apllication/json; charset=utf-8");

include('dados_conexao.php');

try {

        $ong = $_GET['ong'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
            $conecta->exec("set names utf8");

		$consulta = $conecta->prepare("select tb03_tipo, tb07_ong from tb07_urgencias inner join tb03_tipo_doacao on tb07_urgencias.tb07_tipo = tb03_tipo_doacao.tb03_cod where tb07_ong = $ong");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb03_tipo":"' . $registro['tb03_tipo']  . '",';			
			$StringJson .= '"tb07_ong":"' . $registro['tb07_ong'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>