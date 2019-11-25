--------------------------------------------------------------------------------
-- Copyright (c) 1995-2013 Xilinx, Inc.  All rights reserved.
--------------------------------------------------------------------------------
--   ____  ____ 
--  /   /\/   / 
-- /___/  \  /    Vendor: Xilinx 
-- \   \   \/     Version : 14.7
--  \   \         Application : sch2hdl
--  /   /         Filename : szamlalo.vhf
-- /___/   /\     Timestamp : 11/23/2019 14:21:40
-- \   \  /  \ 
--  \___\/\___\ 
--
--Command: sch2hdl -intstyle ise -family spartan3e -flat -suppress -vhdl "D:/Digit szimulaciok/DigitLaborVizsga/szamlalo/szamlalo.vhf" -w "D:/Digit szimulaciok/DigitLaborVizsga/szamlalo/szamlalo.sch"
--Design Name: szamlalo
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

entity OBUF8_MXILINX_szamlalo is
   port ( I : in    std_logic_vector (7 downto 0); 
          O : out   std_logic_vector (7 downto 0));
end OBUF8_MXILINX_szamlalo;

architecture BEHAVIORAL of OBUF8_MXILINX_szamlalo is
   attribute IOSTANDARD : string ;
   attribute SLEW       : string ;
   attribute DRIVE      : string ;
   attribute BOX_TYPE   : string ;
   component OBUF
      port ( I : in    std_logic; 
             O : out   std_logic);
   end component;
   attribute IOSTANDARD of OBUF : component is "DEFAULT";
   attribute SLEW of OBUF : component is "SLOW";
   attribute DRIVE of OBUF : component is "12";
   attribute BOX_TYPE of OBUF : component is "BLACK_BOX";
   
begin
   I_36_30 : OBUF
      port map (I=>I(0),
                O=>O(0));
   
   I_36_31 : OBUF
      port map (I=>I(1),
                O=>O(1));
   
   I_36_32 : OBUF
      port map (I=>I(2),
                O=>O(2));
   
   I_36_33 : OBUF
      port map (I=>I(3),
                O=>O(3));
   
   I_36_34 : OBUF
      port map (I=>I(7),
                O=>O(7));
   
   I_36_35 : OBUF
      port map (I=>I(6),
                O=>O(6));
   
   I_36_36 : OBUF
      port map (I=>I(5),
                O=>O(5));
   
   I_36_37 : OBUF
      port map (I=>I(4),
                O=>O(4));
   
end BEHAVIORAL;



library ieee;
use ieee.std_logic_1164.ALL;
use ieee.numeric_std.ALL;
library UNISIM;
use UNISIM.Vcomponents.ALL;

entity FTCE_MXILINX_szamlalo is
   generic( INIT : bit :=  '0');
   port ( C   : in    std_logic; 
          CE  : in    std_logic; 
          CLR : in    std_logic; 
          T   : in    std_logic; 
          Q   : out   std_logic);
end FTCE_MXILINX_szamlalo;

architecture BEHAVIORAL of FTCE_MXILINX_szamlalo is
   attribute BOX_TYPE   : string ;
   attribute RLOC       : string ;
   signal TQ      : std_logic;
   signal Q_DUMMY : std_logic;
   component XOR2
      port ( I0 : in    std_logic; 
             I1 : in    std_logic; 
             O  : out   std_logic);
   end component;
   attribute BOX_TYPE of XOR2 : component is "BLACK_BOX";
   
   component FDCE
      generic( INIT : bit :=  '0');
      port ( C   : in    std_logic; 
             CE  : in    std_logic; 
             CLR : in    std_logic; 
             D   : in    std_logic; 
             Q   : out   std_logic);
   end component;
   attribute BOX_TYPE of FDCE : component is "BLACK_BOX";
   
   attribute RLOC of I_36_35 : label is "X0Y0";
begin
   Q <= Q_DUMMY;
   I_36_32 : XOR2
      port map (I0=>T,
                I1=>Q_DUMMY,
                O=>TQ);
   
   I_36_35 : FDCE
   generic map( INIT => INIT)
      port map (C=>C,
                CE=>CE,
                CLR=>CLR,
                D=>TQ,
                Q=>Q_DUMMY);
   
end BEHAVIORAL;



library ieee;
use ieee.std_logic_1164.ALL;
use ieee.numeric_std.ALL;
library UNISIM;
use UNISIM.Vcomponents.ALL;

entity szamlalo is
   port ( clk    : in    std_logic; 
          clr    : in    std_logic; 
          enable : in    std_logic; 
          led    : out   std_logic_vector (7 downto 0));
end szamlalo;

architecture BEHAVIORAL of szamlalo is
   attribute HU_SET     : string ;
   attribute BOX_TYPE   : string ;
   signal q       : std_logic_vector (7 downto 0);
   signal XLXN_13 : std_logic;
   signal XLXN_14 : std_logic;
   signal XLXN_33 : std_logic;
   component FTCE_MXILINX_szamlalo
      generic( INIT : bit :=  '0');
      port ( C   : in    std_logic; 
             CE  : in    std_logic; 
             CLR : in    std_logic; 
             T   : in    std_logic; 
             Q   : out   std_logic);
   end component;
   
   component AND3
      port ( I0 : in    std_logic; 
             I1 : in    std_logic; 
             I2 : in    std_logic; 
             O  : out   std_logic);
   end component;
   attribute BOX_TYPE of AND3 : component is "BLACK_BOX";
   
   component AND2
      port ( I0 : in    std_logic; 
             I1 : in    std_logic; 
             O  : out   std_logic);
   end component;
   attribute BOX_TYPE of AND2 : component is "BLACK_BOX";
   
   component PULLDOWN
      port ( O : out   std_logic);
   end component;
   attribute BOX_TYPE of PULLDOWN : component is "BLACK_BOX";
   
   component OBUF8_MXILINX_szamlalo
      port ( I : in    std_logic_vector (7 downto 0); 
             O : out   std_logic_vector (7 downto 0));
   end component;
   
   component PULLUP
      port ( O : out   std_logic);
   end component;
   attribute BOX_TYPE of PULLUP : component is "BLACK_BOX";
   
   attribute HU_SET of XLXI_1 : label is "XLXI_1_0";
   attribute HU_SET of XLXI_2 : label is "XLXI_2_1";
   attribute HU_SET of XLXI_3 : label is "XLXI_3_2";
   attribute HU_SET of XLXI_4 : label is "XLXI_4_3";
   attribute HU_SET of XLXI_11 : label is "XLXI_11_4";
begin
   XLXI_1 : FTCE_MXILINX_szamlalo
      port map (C=>clk,
                CE=>enable,
                CLR=>clr,
                T=>XLXN_13,
                Q=>q(3));
   
   XLXI_2 : FTCE_MXILINX_szamlalo
      port map (C=>clk,
                CE=>enable,
                CLR=>clr,
                T=>XLXN_14,
                Q=>q(2));
   
   XLXI_3 : FTCE_MXILINX_szamlalo
      port map (C=>clk,
                CE=>enable,
                CLR=>clr,
                T=>q(0),
                Q=>q(1));
   
   XLXI_4 : FTCE_MXILINX_szamlalo
      port map (C=>clk,
                CE=>enable,
                CLR=>clr,
                T=>XLXN_33,
                Q=>q(0));
   
   XLXI_5 : AND3
      port map (I0=>q(2),
                I1=>q(0),
                I2=>q(1),
                O=>XLXN_13);
   
   XLXI_6 : AND2
      port map (I0=>q(1),
                I1=>q(0),
                O=>XLXN_14);
   
   XLXI_7 : PULLDOWN
      port map (O=>q(7));
   
   XLXI_8 : PULLDOWN
      port map (O=>q(6));
   
   XLXI_9 : PULLDOWN
      port map (O=>q(5));
   
   XLXI_10 : PULLDOWN
      port map (O=>q(4));
   
   XLXI_11 : OBUF8_MXILINX_szamlalo
      port map (I(7 downto 0)=>q(7 downto 0),
                O(7 downto 0)=>led(7 downto 0));
   
   XLXI_12 : PULLUP
      port map (O=>XLXN_33);
   
end BEHAVIORAL;


