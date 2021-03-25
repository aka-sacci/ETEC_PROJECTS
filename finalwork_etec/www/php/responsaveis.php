<?php


header("Access-Control-Allow-Origin: *");


include('dados_conexao.php');

try {

        $id = $_GET['id'];
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha);
            $conecta->exec("set names utf8");

		$consulta = $conecta->prepare("select tb10_ong, tb01_nome from tb10_ongs_campanhas inner join tb01_ongs on tb10_ongs_campanhas.tb10_ong = tb01_ongs.tb01_cnpj where tb10_campanha = $id and tb10_status = 2");
		$consulta->execute(array());  
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "[";
 
	if ( count($resultadoDaConsulta) ) {
		foreach($resultadoDaConsulta as $registro) {
 
			if ($StringJson != "[") {$StringJson .= ",";}
			$StringJson .= '{"tb10_ong":"' . $registro['tb10_ong']  . '",';								
			$StringJson .= '"tb01_nome":"' . $registro['tb01_nome'] . '"}';
		}  
		echo $StringJson . "]"; // Exibe o vettor JSON
  } 
} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage(); // opcional, apenas para teste
}



?>