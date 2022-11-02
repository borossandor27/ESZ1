<?php
namespace classes;
class Allat{
    public $nev = "ősosztály";
    public static $hang = "néma"; //-- a példányosítás pillanatától használható
    
    public function __construct() {
//        $this->nev = $param;
    }
    public function hangotAd() {
//        return $this->hang; 
        return $this::$hang; //-- statitikus változó
    }
}