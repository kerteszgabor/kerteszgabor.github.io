# Prog harmadik előadás

## Eddigi git ismeretek

- decentralizált verziókövető-rendszer
- nem klónozás az elv
- nem csak master branchet használunk: ténylegesen többfelhasználós, eloszott fejlesztést szeretnénk támogatni

## Git általában

- a UI-ok jól néznek ki, de nem tudják a funkciók 100%-át
    - főleg bonyolultabb műveleteket **csak CLI-ből** érünk el
    - ráadásul előfordulnak bugok 
    - IDE-k, GUI git kliensek is rendelkeznek CLI-vel

### Konfliktuskezelés

- egy file-on belüli két módosítás **mindig** conflict, akkor is, ha valójában a fájlon belül különböző helyre írnak
- konfliktfeloldás: helyileg történjen (local) → gyakorlatilag egy új commit keletkezik
- local branch és remote branch viszonya: vagy *behind* vagy *ahead*
- mindig **no-fast-forward** merge-t használjunk
- kdiff3 viszonylag jó merge-tool

### Branching

- stabilitást jelezni, funkciókat szeparálni is kiváló
- forke - merge
- merging: 
    * több ág egyesítése
    * plain merge: headet áthelyezzük az új kódrészlet végére → "összeláncoljuk"
    * plain merge esetén forke-history elveszik 
    * no-fast-forwardot használjunk → ekkor a merge **mindig egy új commit**
    * van lehetőség remote mergelni is 
    * elvárás: master/develop felosztás, masterre **soha** nem megy feature-commit, csak merge-commit
    * túl sok commit **nincs**
- GitFlow modell
    * feature, hotfix branchek: ezek nem személy- és modul-specifikusak
    * release-branch-be új feature **soha** nem kerül bele, csak hibajavítás → viszont ezeket a developba is be kell commitolni, hogy a hiba ne jöjjön elő még egyszer 
    * github branching model esetén a remote merging komoly szerepet játszik, hiszen sikeres pull request után ez történik
    * automatizmusok (pl.: tesztelés, esetleg deployment is)