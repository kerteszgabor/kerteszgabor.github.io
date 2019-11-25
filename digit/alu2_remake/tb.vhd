-- Vhdl test bench created from schematic C:\Users\Seres\Desktop\DIGIT\digit_remake\alu2_remake\alu2_remake.sch - Fri Nov 22 16:32:00 2019
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
ENTITY alu2_remake_alu2_remake_sch_tb IS
END alu2_remake_alu2_remake_sch_tb;
ARCHITECTURE behavioral OF alu2_remake_alu2_remake_sch_tb IS 

   COMPONENT alu2_remake
   PORT( A	:	IN	STD_LOGIC_VECTOR (3 DOWNTO 0); 
          RR	:	OUT	STD_LOGIC_VECTOR (3 DOWNTO 0); 
          RL	:	OUT	STD_LOGIC_VECTOR (3 DOWNTO 0));
   END COMPONENT;

   SIGNAL A	:	STD_LOGIC_VECTOR (3 DOWNTO 0);
   SIGNAL RR	:	STD_LOGIC_VECTOR (3 DOWNTO 0);
   SIGNAL RL	:	STD_LOGIC_VECTOR (3 DOWNTO 0);

BEGIN

   UUT: alu2_remake PORT MAP(
		A => A, 
		RR => RR, 
		RL => RL
   );

-- *** Test Bench - User Defined Section ***
   tb : PROCESS
   BEGIN
	     A <= "0100";
			WAIT;
   END PROCESS;
-- *** End Test Bench - User Defined Section ***

END;
