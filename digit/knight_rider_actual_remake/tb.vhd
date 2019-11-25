-- Vhdl test bench created from schematic C:\Users\Seres\Desktop\DIGIT\digit_remake\knight_rider_actual_remake\knight_rider_actual.sch - Fri Nov 22 16:05:33 2019
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
ENTITY knight_rider_actual_knight_rider_actual_sch_tb IS
END knight_rider_actual_knight_rider_actual_sch_tb;
ARCHITECTURE behavioral OF knight_rider_actual_knight_rider_actual_sch_tb IS 

   COMPONENT knight_rider_actual
   PORT( led0	:	OUT	STD_LOGIC; 
          led1	:	OUT	STD_LOGIC; 
          led2	:	OUT	STD_LOGIC; 
          led3	:	OUT	STD_LOGIC; 
          led4	:	OUT	STD_LOGIC; 
          led5	:	OUT	STD_LOGIC; 
          led6	:	OUT	STD_LOGIC; 
          led7	:	OUT	STD_LOGIC; 
          sw	:	IN	STD_LOGIC; 
          clk	:	IN	STD_LOGIC; 
          irany	:	IN	STD_LOGIC);
   END COMPONENT;

   SIGNAL led0	:	STD_LOGIC;
   SIGNAL led1	:	STD_LOGIC;
   SIGNAL led2	:	STD_LOGIC;
   SIGNAL led3	:	STD_LOGIC;
   SIGNAL led4	:	STD_LOGIC;
   SIGNAL led5	:	STD_LOGIC;
   SIGNAL led6	:	STD_LOGIC;
   SIGNAL led7	:	STD_LOGIC;
   SIGNAL sw	:	STD_LOGIC;
   SIGNAL clk	:	STD_LOGIC;
   SIGNAL irany	:	STD_LOGIC;

BEGIN

   UUT: knight_rider_actual PORT MAP(
		led0 => led0, 
		led1 => led1, 
		led2 => led2, 
		led3 => led3, 
		led4 => led4, 
		led5 => led5, 
		led6 => led6, 
		led7 => led7, 
		sw => sw, 
		clk => clk, 
		irany => irany
   );

-- *** Test Bench - User Defined Section ***
   tb : PROCESS
   BEGIN
	irany <= '1';
	sw <= '1';
	clk <= '1';
	wait for 4 us;
	clk <= '0';
	wait for 4 us;
   END PROCESS;
-- *** End Test Bench - User Defined Section ***

END;
