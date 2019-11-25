-- Vhdl test bench created from schematic C:\Users\Seres\Desktop\DIGIT\szamlalo\szamlalo.sch - Thu Nov 21 17:31:21 2019
--
-- Notes: 
-- 1) This testbench template has been automatically generated using types
-- std_logic and std_logic_vector for the ports of the unit under test.
-- Xilinx recommends that these types always be used for the top-level
-- I/O of a design in order to guarantee that the testbench will bind
-- correctly to the timing (post-route) simulation model.
-- 2) To use this template as your testbench, change the filename to any
-- name of your choice with the extension .vhd, and use the "Source->Add"
-- menu in Project Navigator to import the testbench. Then
-- edit the user defined section below, adding code to generate the 
-- stimulus for your design.
--
LIBRARY ieee;
USE ieee.std_logic_1164.ALL;
USE ieee.numeric_std.ALL;
LIBRARY UNISIM;
USE UNISIM.Vcomponents.ALL;
ENTITY szamlalo_szamlalo_sch_tb IS
END szamlalo_szamlalo_sch_tb;
ARCHITECTURE behavioral OF szamlalo_szamlalo_sch_tb IS 

   COMPONENT szamlalo
   PORT( clr	:	IN	STD_LOGIC; 
          clk	:	IN	STD_LOGIC; 
          enable	:	IN	STD_LOGIC; 
          led	:	OUT	STD_LOGIC_VECTOR (7 DOWNTO 0));
   END COMPONENT;

   SIGNAL clr	:	STD_LOGIC;
   SIGNAL clk	:	STD_LOGIC;
   SIGNAL enable	:	STD_LOGIC;
   SIGNAL led	:	STD_LOGIC_VECTOR (7 DOWNTO 0);

BEGIN

   UUT: szamlalo PORT MAP(
		clr => clr, 
		clk => clk, 
		enable => enable, 
		led => led
   );

-- *** Test Bench - User Defined Section ***
   tb : PROCESS
   BEGIN
	enable <= '1';
	clk <= '0';
	wait for 4 us;
	clk <= '1';
	wait for 4 us;
      
   END PROCESS;
-- *** End Test Bench - User Defined Section ***

END;
