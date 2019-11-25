--------------------------------------------------------------------------------
-- Copyright (c) 1995-2013 Xilinx, Inc.  All rights reserved.
--------------------------------------------------------------------------------
--   ____  ____ 
--  /   /\/   / 
-- /___/  \  /    Vendor: Xilinx 
-- \   \   \/     Version : 14.7
--  \   \         Application : sch2hdl
--  /   /         Filename : alu2_remake.vhf
-- /___/   /\     Timestamp : 11/23/2019 18:12:07
-- \   \  /  \ 
--  \___\/\___\ 
--
--Command: sch2hdl -intstyle ise -family spartan3e -flat -suppress -vhdl "D:/Digit szimulaciok/DigitLaborVizsga/alu2_remake/alu2_remake.vhf" -w "D:/Digit szimulaciok/DigitLaborVizsga/alu2_remake/alu2_remake.sch"
--Design Name: alu2_remake
--Device: spartan3e
--Purpose:
--    This vhdl netlist is translated from an ECS schematic. It can be 
--    synthesized and simulated, but it should not be modified. 
--

library ieee;
use ieee.std_logic_1164.ALL;
use ieee.numeric_std.ALL;
library UNISIM;
use UNISIM.Vcomponents.ALL;

entity M2_1_MXILINX_alu2_remake is
   port ( D0 : in    std_logic; 
          D1 : in    std_logic; 
          S0 : in    std_logic; 
          O  : out   std_logic);
end M2_1_MXILINX_alu2_remake;

architecture BEHAVIORAL of M2_1_MXILINX_alu2_remake is
   attribute BOX_TYPE   : string ;
   signal M0 : std_logic;
   signal M1 : std_logic;
   component AND2B1
      port ( I0 : in    std_logic; 
             I1 : in    std_logic; 
             O  : out   std_logic);
   end component;
   attribute BOX_TYPE of AND2B1 : component is "BLACK_BOX";
   
   component OR2
      port ( I0 : in    std_logic; 
             I1 : in    std_logic; 
             O  : out   std_logic);
   end component;
   attribute BOX_TYPE of OR2 : component is "BLACK_BOX";
   
   component AND2
      port ( I0 : in    std_logic; 
             I1 : in    std_logic; 
             O  : out   std_logic);
   end component;
   attribute BOX_TYPE of AND2 : component is "BLACK_BOX";
   
begin
   I_36_7 : AND2B1
      port map (I0=>S0,
                I1=>D0,
                O=>M0);
   
   I_36_8 : OR2
      port map (I0=>M1,
                I1=>M0,
                O=>O);
   
   I_36_9 : AND2
      port map (I0=>D1,
                I1=>S0,
                O=>M1);
   
end BEHAVIORAL;



library ieee;
use ieee.std_logic_1164.ALL;
use ieee.numeric_std.ALL;
library UNISIM;
use UNISIM.Vcomponents.ALL;

entity mplx_2_1_4bit_MUSER_alu2_remake is
   port ( ain : in    std_logic_vector (3 downto 0); 
          bin : in    std_logic_vector (3 downto 0); 
          sel : in    std_logic; 
          ki  : out   std_logic_vector (3 downto 0));
end mplx_2_1_4bit_MUSER_alu2_remake;

architecture BEHAVIORAL of mplx_2_1_4bit_MUSER_alu2_remake is
   attribute HU_SET     : string ;
   component M2_1_MXILINX_alu2_remake
      port ( D0 : in    std_logic; 
             D1 : in    std_logic; 
             S0 : in    std_logic; 
             O  : out   std_logic);
   end component;
   
   attribute HU_SET of XLXI_1 : label is "XLXI_1_0";
   attribute HU_SET of XLXI_2 : label is "XLXI_2_3";
   attribute HU_SET of XLXI_3 : label is "XLXI_3_1";
   attribute HU_SET of XLXI_4 : label is "XLXI_4_2";
begin
   XLXI_1 : M2_1_MXILINX_alu2_remake
      port map (D0=>ain(0),
                D1=>bin(0),
                S0=>sel,
                O=>ki(0));
   
   XLXI_2 : M2_1_MXILINX_alu2_remake
      port map (D0=>ain(1),
                D1=>bin(1),
                S0=>sel,
                O=>ki(1));
   
   XLXI_3 : M2_1_MXILINX_alu2_remake
      port map (D0=>ain(2),
                D1=>bin(2),
                S0=>sel,
                O=>ki(2));
   
   XLXI_4 : M2_1_MXILINX_alu2_remake
      port map (D0=>ain(3),
                D1=>bin(3),
                S0=>sel,
                O=>ki(3));
   
end BEHAVIORAL;



library ieee;
use ieee.std_logic_1164.ALL;
use ieee.numeric_std.ALL;
library UNISIM;
use UNISIM.Vcomponents.ALL;

entity alu2_remake is
   port ( A   : in    std_logic_vector (3 downto 0); 
          st  : in    std_logic; 
          seg : out   std_logic_vector (6 downto 0));
end alu2_remake;

architecture BEHAVIORAL of alu2_remake is
   attribute BOX_TYPE   : string ;
   signal RL      : std_logic_vector (3 downto 0);
   signal RR      : std_logic_vector (3 downto 0);
   signal XLXN_24 : std_logic_vector (3 downto 0);
   component BUF
      port ( I : in    std_logic; 
             O : out   std_logic);
   end component;
   attribute BOX_TYPE of BUF : component is "BLACK_BOX";
   
   component GND
      port ( G : out   std_logic);
   end component;
   attribute BOX_TYPE of GND : component is "BLACK_BOX";
   
   component mplx_2_1_4bit_MUSER_alu2_remake
      port ( ain : in    std_logic_vector (3 downto 0); 
             bin : in    std_logic_vector (3 downto 0); 
             sel : in    std_logic; 
             ki  : out   std_logic_vector (3 downto 0));
   end component;
   
   component hex_7seg
      port ( d : in    std_logic_vector (3 downto 0); 
             s : out   std_logic_vector (6 downto 0));
   end component;
   
begin
   XLXI_1 : BUF
      port map (I=>A(1),
                O=>RR(0));
   
   XLXI_2 : BUF
      port map (I=>A(2),
                O=>RR(1));
   
   XLXI_3 : BUF
      port map (I=>A(3),
                O=>RR(2));
   
   XLXI_4 : GND
      port map (G=>RR(3));
   
   XLXI_5 : BUF
      port map (I=>A(0),
                O=>RL(1));
   
   XLXI_6 : BUF
      port map (I=>A(1),
                O=>RL(2));
   
   XLXI_7 : BUF
      port map (I=>A(2),
                O=>RL(3));
   
   XLXI_8 : GND
      port map (G=>RL(0));
   
   XLXI_9 : mplx_2_1_4bit_MUSER_alu2_remake
      port map (ain(3 downto 0)=>RR(3 downto 0),
                bin(3 downto 0)=>RL(3 downto 0),
                sel=>st,
                ki(3 downto 0)=>XLXN_24(3 downto 0));
   
   XLXI_10 : hex_7seg
      port map (d(3 downto 0)=>XLXN_24(3 downto 0),
                s(6 downto 0)=>seg(6 downto 0));
   
end BEHAVIORAL;


