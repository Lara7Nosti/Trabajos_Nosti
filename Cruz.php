<?php
$cant_filas=12;
$cant_columnas=12;
?>

<table border="1">
	<?php
		for($filas=1;$filas<=$cant_filas;$filas++){ ?>
			<tr>
			<?php
			for($columnas=1;$columnas<=$cant_columnas;$columnas++){ 
				/*
				if($columnas == $filas)
				{
					$color="red";
				}
				else
				{
					$color = "blue";
				}
				*/
				if()
				{
					$color="red";
				}
				else
				{
					$color = "blue";
				}	
			?>
				
				<td bgcolor="<?php echo $color; ?>"><?php echo "f" . $filas . "--c" .$columnas; ?></td>
			<?php } ?>
			</tr>
		<?php } ?>
</table>