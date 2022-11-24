Module Module1
    Public Const DB_Folder As String = "\DB\"
    Public Const DB_Index As String = DB_Folder & "Index.xml"
    Public Const TemplateAttachDBName As String = "A.xml"
    Public Const TemplateTAttachDBName As String = "T.xml"
    Public Const ModelloAllegati As String = "modello_allegati.xml"
    Public Const schema As String = DB_Folder & "schema.xml"
    Public Const schemaindex As String = DB_Folder & "schema_index.xml"
    Public AttData As DataSet
    Public Form3identificativo As String
    Public Form3data As String
    Public Const PasswordAdmin As String = "Rebus2022"
    Public CanSave As Boolean

    Public Const XMLSchema As String = "<?xml version=""1.0""?>
<xs:schema id=""Stati"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
  <xs:element name=""Stati"" msdata:IsDataSet=""true"" msdata:Locale=""en-US"">
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element name=""Giorno"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Allegato"" nillable=""true"" minOccurs=""0"" maxOccurs=""unbounded"">
                <xs:complexType>
                  <xs:simpleContent msdata:ColumnName=""Allegato_Text"" msdata:Ordinal=""1"">
                    <xs:extension base=""xs:string"">
                      <xs:attribute name=""nome"" type=""xs:string"" />
                    </xs:extension>
                  </xs:simpleContent>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute name=""data"" type=""xs:string"" />

            <xs:attribute name=""Ent1"" type=""xs:string"" />


            <xs:attribute name=""Ent2"" type=""xs:string"" />


            <xs:attribute name=""Usc1"" type=""xs:string"" />


            <xs:attribute name=""Usc2"" type=""xs:string"" />

            <xs:attribute name=""attivita"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>"

    Public Const XMLSchemaIndex As String = "<?xml version=""1.0"" standalone=""yes""?>
<xs:schema id=""PersonaleCivile_Table"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
  <xs:element name=""PersonaleCivile_Table"" msdata:IsDataSet=""true"" msdata:Locale=""en-US"">
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element name=""Persona"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""pp_CodiceFiscale"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""0"" />
              <xs:element name=""pp_Nome"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""1"" />
              <xs:element name=""pp_Cognome"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""2"" />
              <xs:element name=""pp_Tabellare"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""3"" />
              <xs:element name=""pp_Incarico"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""4"" />
              <xs:element name=""pp_AssunzioneCivile"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""5"" />
              <xs:element name=""pp_AssunzioneMilitare"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""6"" />
  <xs:element name=""pp_AssunzioneGiuridica"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""6"" />
              <xs:element name=""pp_AssunzioneAmministrativa"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""6"" />
                        
<xs:element name=""pp_LuogoNascita"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""7"" />
              <xs:element name=""pp_Nascita"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""8"" />
              <xs:element name=""pp_Residenza"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""9"" />
              <xs:element name=""pp_Telefono"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""10"" />
              <xs:element name=""pp_Email"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""11"" />
              <xs:element name=""pp_Area"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""12"" />
              <xs:element name=""pp_Qualifica"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""13"" />
              <xs:element name=""pp_Note"" type=""xs:string"" minOccurs=""0"" msdata:Ordinal=""14"" />
            </xs:sequence>
            <xs:attribute name=""id"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>"


    Public Const ElencoComuni As String = "<tabellacomuni>
<comune><nome>Abano Terme</nome><codice>A001</codice></comune>
<comune><nome>Abbadia Cerreto</nome><codice>A004</codice></comune>
<comune><nome>Abbadia Lariana</nome><codice>A005</codice></comune>
<comune><nome>Abbadia San Salvatore</nome><codice>A006</codice></comune>
<comune><nome>Abbasanta</nome><codice>A007</codice></comune>
<comune><nome>Abbateggio</nome><codice>A008</codice></comune>
<comune><nome>Abbiategrasso</nome><codice>A010</codice></comune>
<comune><nome>Abetone</nome><codice>A012</codice></comune>
<comune><nome>Abriola</nome><codice>A013</codice></comune>
<comune><nome>Acate</nome><codice>A014</codice></comune>
<comune><nome>Accadia</nome><codice>A015</codice></comune>
<comune><nome>Acceglio</nome><codice>A016</codice></comune>
<comune><nome>Accettura</nome><codice>A017</codice></comune>
<comune><nome>Acciano</nome><codice>A018</codice></comune>
<comune><nome>Accumoli</nome><codice>A019</codice></comune>
<comune><nome>Acerenza</nome><codice>A020</codice></comune>
<comune><nome>Acerno</nome><codice>A023</codice></comune>
<comune><nome>Acerra</nome><codice>A024</codice></comune>
<comune><nome>Aci Bonaccorsi</nome><codice>A025</codice></comune>
<comune><nome>Aci Castello</nome><codice>A026</codice></comune>
<comune><nome>Aci Catena</nome><codice>A027</codice></comune>
<comune><nome>Aci Sant'Antonio</nome><codice>A029</codice></comune>
<comune><nome>Acireale</nome><codice>A028</codice></comune>
<comune><nome>Acquacanina</nome><codice>A031</codice></comune>
<comune><nome>Acquafondata</nome><codice>A032</codice></comune>
<comune><nome>Acquaformosa</nome><codice>A033</codice></comune>
<comune><nome>Acquafredda</nome><codice>A034</codice></comune>
<comune><nome>Acqualagna</nome><codice>A035</codice></comune>
<comune><nome>Acquanegra Cremonese</nome><codice>A039</codice></comune>
<comune><nome>Acquanegra sul Chiese</nome><codice>A038</codice></comune>
<comune><nome>Acquapendente</nome><codice>A040</codice></comune>
<comune><nome>Acquappesa</nome><codice>A041</codice></comune>
<comune><nome>Acquarica del Capo</nome><codice>A042</codice></comune>
<comune><nome>Acquaro</nome><codice>A043</codice></comune>
<comune><nome>Acquasanta Terme</nome><codice>A044</codice></comune>
<comune><nome>Acquasparta</nome><codice>A045</codice></comune>
<comune><nome>Acquaviva Collecroce</nome><codice>A050</codice></comune>
<comune><nome>Acquaviva delle Fonti</nome><codice>A048</codice></comune>
<comune><nome>Acquaviva d'Isernia</nome><codice>A051</codice></comune>
<comune><nome>Acquaviva Picena</nome><codice>A047</codice></comune>
<comune><nome>Acquaviva Platani</nome><codice>A049</codice></comune>
<comune><nome>Acquedolci</nome><codice>M211</codice></comune>
<comune><nome>Acqui Terme</nome><codice>A052</codice></comune>
<comune><nome>Acri</nome><codice>A053</codice></comune>
<comune><nome>Acuto</nome><codice>A054</codice></comune>
<comune><nome>Adelfia</nome><codice>A055</codice></comune>
<comune><nome>Adrano</nome><codice>A056</codice></comune>
<comune><nome>Adrara San Martino</nome><codice>A057</codice></comune>
<comune><nome>Adrara San Rocco</nome><codice>A058</codice></comune>
<comune><nome>Adria</nome><codice>A059</codice></comune>
<comune><nome>Adro</nome><codice>A060</codice></comune>
<comune><nome>Affi</nome><codice>A061</codice></comune>
<comune><nome>Affile</nome><codice>A062</codice></comune>
<comune><nome>Afragola</nome><codice>A064</codice></comune>
<comune><nome>Africo</nome><codice>A065</codice></comune>
<comune><nome>Agazzano</nome><codice>A067</codice></comune>
<comune><nome>Agerola</nome><codice>A068</codice></comune>
<comune><nome>Aggius</nome><codice>A069</codice></comune>
<comune><nome>Agira</nome><codice>A070</codice></comune>
<comune><nome>Agliana</nome><codice>A071</codice></comune>
<comune><nome>Agliano Terme</nome><codice>A072</codice></comune>
<comune><nome>Agliè</nome><codice>A074</codice></comune>
<comune><nome>Aglientu</nome><codice>H848</codice></comune>
<comune><nome>Agna</nome><codice>A075</codice></comune>
<comune><nome>Agnadello</nome><codice>A076</codice></comune>
<comune><nome>Agnana Calabra</nome><codice>A077</codice></comune>
<comune><nome>Agnone</nome><codice>A080</codice></comune>
<comune><nome>Agnosine</nome><codice>A082</codice></comune>
<comune><nome>Agordo</nome><codice>A083</codice></comune>
<comune><nome>Agosta</nome><codice>A084</codice></comune>
<comune><nome>Agra</nome><codice>A085</codice></comune>
<comune><nome>Agrate Brianza</nome><codice>A087</codice></comune>
<comune><nome>Agrate Conturbia</nome><codice>A088</codice></comune>
<comune><nome>Agrigento</nome><codice>A089</codice></comune>
<comune><nome>Agropoli</nome><codice>A091</codice></comune>
<comune><nome>Agugliano</nome><codice>A092</codice></comune>
<comune><nome>Agugliaro</nome><codice>A093</codice></comune>
<comune><nome>Aicurzio</nome><codice>A096</codice></comune>
<comune><nome>Aidomaggiore</nome><codice>A097</codice></comune>
<comune><nome>Aidone</nome><codice>A098</codice></comune>
<comune><nome>Aielli</nome><codice>A100</codice></comune>
<comune><nome>Aiello Calabro</nome><codice>A102</codice></comune>
<comune><nome>Aiello del Friuli</nome><codice>A103</codice></comune>
<comune><nome>Aiello del Sabato</nome><codice>A101</codice></comune>
<comune><nome>Aieta</nome><codice>A105</codice></comune>
<comune><nome>Ailano</nome><codice>A106</codice></comune>
<comune><nome>Ailoche</nome><codice>A107</codice></comune>
<comune><nome>Airasca</nome><codice>A109</codice></comune>
<comune><nome>Airola</nome><codice>A110</codice></comune>
<comune><nome>Airole</nome><codice>A111</codice></comune>
<comune><nome>Airuno</nome><codice>A112</codice></comune>
<comune><nome>Aisone</nome><codice>A113</codice></comune>
<comune><nome>Ala</nome><codice>A116</codice></comune>
<comune><nome>Alà dei Sardi</nome><codice>A115</codice></comune>
<comune><nome>Ala di Stura</nome><codice>A117</codice></comune>
<comune><nome>Alagna</nome><codice>A118</codice></comune>
<comune><nome>Alagna Valsesia</nome><codice>A119</codice></comune>
<comune><nome>Alanno</nome><codice>A120</codice></comune>
<comune><nome>Alano di Piave</nome><codice>A121</codice></comune>
<comune><nome>Alassio</nome><codice>A122</codice></comune>
<comune><nome>Alatri</nome><codice>A123</codice></comune>
<comune><nome>Alba</nome><codice>A124</codice></comune>
<comune><nome>Alba Adriatica</nome><codice>A125</codice></comune>
<comune><nome>Albagiara</nome><codice>A126</codice></comune>
<comune><nome>Albairate</nome><codice>A127</codice></comune>
<comune><nome>Albanella</nome><codice>A128</codice></comune>
<comune><nome>Albano di Lucania</nome><codice>A131</codice></comune>
<comune><nome>Albano Laziale</nome><codice>A132</codice></comune>
<comune><nome>Albano Sant'Alessandro</nome><codice>A129</codice></comune>
<comune><nome>Albano Vercellese</nome><codice>A130</codice></comune>
<comune><nome>Albaredo Arnaboldi</nome><codice>A134</codice></comune>
<comune><nome>Albaredo d'Adige</nome><codice>A137</codice></comune>
<comune><nome>Albaredo per San Marco</nome><codice>A135</codice></comune>
<comune><nome>Albareto</nome><codice>A138</codice></comune>
<comune><nome>Albaretto della Torre</nome><codice>A139</codice></comune>
<comune><nome>Albavilla</nome><codice>A143</codice></comune>
<comune><nome>Albenga</nome><codice>A145</codice></comune>
<comune><nome>Albera Ligure</nome><codice>A146</codice></comune>
<comune><nome>Alberobello</nome><codice>A149</codice></comune>
<comune><nome>Alberona</nome><codice>A150</codice></comune>
<comune><nome>Albese con Cassano</nome><codice>A153</codice></comune>
<comune><nome>Albettone</nome><codice>A154</codice></comune>
<comune><nome>Albi</nome><codice>A155</codice></comune>
<comune><nome>Albiano</nome><codice>A158</codice></comune>
<comune><nome>Albiano d'Ivrea</nome><codice>A157</codice></comune>
<comune><nome>Albiate</nome><codice>A159</codice></comune>
<comune><nome>Albidona</nome><codice>A160</codice></comune>
<comune><nome>Albignasego</nome><codice>A161</codice></comune>
<comune><nome>Albinea</nome><codice>A162</codice></comune>
<comune><nome>Albino</nome><codice>A163</codice></comune>
<comune><nome>Albiolo</nome><codice>A164</codice></comune>
<comune><nome>Albisola Superiore</nome><codice>A166</codice></comune>
<comune><nome>Albissola Marina</nome><codice>A165</codice></comune>
<comune><nome>Albizzate</nome><codice>A167</codice></comune>
<comune><nome>Albonese</nome><codice>A171</codice></comune>
<comune><nome>Albosaggia</nome><codice>A172</codice></comune>
<comune><nome>Albugnano</nome><codice>A173</codice></comune>
<comune><nome>Albuzzano</nome><codice>A175</codice></comune>
<comune><nome>Alcamo</nome><codice>A176</codice></comune>
<comune><nome>Alcara Li Fusi</nome><codice>A177</codice></comune>
<comune><nome>Aldeno</nome><codice>A178</codice></comune>
<comune><nome>Aldino</nome><codice>A179</codice></comune>
<comune><nome>Ales</nome><codice>A180</codice></comune>
<comune><nome>Alessandria</nome><codice>A182</codice></comune>
<comune><nome>Alessandria del Carretto</nome><codice>A183</codice></comune>
<comune><nome>Alessandria della Rocca</nome><codice>A181</codice></comune>
<comune><nome>Alessano</nome><codice>A184</codice></comune>
<comune><nome>Alezio</nome><codice>A185</codice></comune>
<comune><nome>Alfano</nome><codice>A186</codice></comune>
<comune><nome>Alfedena</nome><codice>A187</codice></comune>
<comune><nome>Alfianello</nome><codice>A188</codice></comune>
<comune><nome>Alfiano Natta</nome><codice>A189</codice></comune>
<comune><nome>Alfonsine</nome><codice>A191</codice></comune>
<comune><nome>Alghero</nome><codice>A192</codice></comune>
<comune><nome>Algua</nome><codice>A193</codice></comune>
<comune><nome>Alì</nome><codice>A194</codice></comune>
<comune><nome>Alì Terme</nome><codice>A201</codice></comune>
<comune><nome>Alia</nome><codice>A195</codice></comune>
<comune><nome>Aliano</nome><codice>A196</codice></comune>
<comune><nome>Alice Bel Colle</nome><codice>A197</codice></comune>
<comune><nome>Alice Castello</nome><codice>A198</codice></comune>
<comune><nome>Alice Superiore</nome><codice>A199</codice></comune>
<comune><nome>Alife</nome><codice>A200</codice></comune>
<comune><nome>Alimena</nome><codice>A202</codice></comune>
<comune><nome>Aliminusa</nome><codice>A203</codice></comune>
<comune><nome>Allai</nome><codice>A204</codice></comune>
<comune><nome>Alleghe</nome><codice>A206</codice></comune>
<comune><nome>Allein</nome><codice>A205</codice></comune>
<comune><nome>Allerona</nome><codice>A207</codice></comune>
<comune><nome>Alliste</nome><codice>A208</codice></comune>
<comune><nome>Allumiere</nome><codice>A210</codice></comune>
<comune><nome>Alluvioni Cambiò</nome><codice>A211</codice></comune>
<comune><nome>Almè</nome><codice>A214</codice></comune>
<comune><nome>Almenno San Bartolomeo</nome><codice>A216</codice></comune>
<comune><nome>Almenno San Salvatore</nome><codice>A217</codice></comune>
<comune><nome>Almese</nome><codice>A218</codice></comune>
<comune><nome>Alonte</nome><codice>A220</codice></comune>
<comune><nome>Alpette</nome><codice>A221</codice></comune>
<comune><nome>Alpignano</nome><codice>A222</codice></comune>
<comune><nome>Alseno</nome><codice>A223</codice></comune>
<comune><nome>Alserio</nome><codice>A224</codice></comune>
<comune><nome>Altamura</nome><codice>A225</codice></comune>
<comune><nome>Altare</nome><codice>A226</codice></comune>
<comune><nome>Altavilla Irpina</nome><codice>A228</codice></comune>
<comune><nome>Altavilla Milicia</nome><codice>A229</codice></comune>
<comune><nome>Altavilla Monferrato</nome><codice>A227</codice></comune>
<comune><nome>Altavilla Silentina</nome><codice>A230</codice></comune>
<comune><nome>Altavilla Vicentina</nome><codice>A231</codice></comune>
<comune><nome>Altidona</nome><codice>A233</codice></comune>
<comune><nome>Altilia</nome><codice>A234</codice></comune>
<comune><nome>Altino</nome><codice>A235</codice></comune>
<comune><nome>Altissimo</nome><codice>A236</codice></comune>
<comune><nome>Altivole</nome><codice>A237</codice></comune>
<comune><nome>Alto</nome><codice>A238</codice></comune>
<comune><nome>Altofonte</nome><codice>A239</codice></comune>
<comune><nome>Altomonte</nome><codice>A240</codice></comune>
<comune><nome>Altopascio</nome><codice>A241</codice></comune>
<comune><nome>Alviano</nome><codice>A242</codice></comune>
<comune><nome>Alvignano</nome><codice>A243</codice></comune>
<comune><nome>Alvito</nome><codice>A244</codice></comune>
<comune><nome>Alzano Lombardo</nome><codice>A246</codice></comune>
<comune><nome>Alzano Scrivia</nome><codice>A245</codice></comune>
<comune><nome>Alzate Brianza</nome><codice>A249</codice></comune>
<comune><nome>Amalfi</nome><codice>A251</codice></comune>
<comune><nome>Amandola</nome><codice>A252</codice></comune>
<comune><nome>Amantea</nome><codice>A253</codice></comune>
<comune><nome>Amaro</nome><codice>A254</codice></comune>
<comune><nome>Amaroni</nome><codice>A255</codice></comune>
<comune><nome>Amaseno</nome><codice>A256</codice></comune>
<comune><nome>Amato</nome><codice>A257</codice></comune>
<comune><nome>Amatrice</nome><codice>A258</codice></comune>
<comune><nome>Ambivere</nome><codice>A259</codice></comune>
<comune><nome>Amblar</nome><codice>A260</codice></comune>
<comune><nome>Ameglia</nome><codice>A261</codice></comune>
<comune><nome>Amelia</nome><codice>A262</codice></comune>
<comune><nome>Amendolara</nome><codice>A263</codice></comune>
<comune><nome>Ameno</nome><codice>A264</codice></comune>
<comune><nome>Amorosi</nome><codice>A265</codice></comune>
<comune><nome>Ampezzo</nome><codice>A267</codice></comune>
<comune><nome>Anacapri</nome><codice>A268</codice></comune>
<comune><nome>Anagni</nome><codice>A269</codice></comune>
<comune><nome>Ancarano</nome><codice>A270</codice></comune>
<comune><nome>Ancona</nome><codice>A271</codice></comune>
<comune><nome>Andali</nome><codice>A272</codice></comune>
<comune><nome>Andalo</nome><codice>A274</codice></comune>
<comune><nome>Andalo Valtellino</nome><codice>A273</codice></comune>
<comune><nome>Andezeno</nome><codice>A275</codice></comune>
<comune><nome>Andora</nome><codice>A278</codice></comune>
<comune><nome>Andorno Micca</nome><codice>A280</codice></comune>
<comune><nome>Andrano</nome><codice>A281</codice></comune>
<comune><nome>Andrate</nome><codice>A282</codice></comune>
<comune><nome>Andreis</nome><codice>A283</codice></comune>
<comune><nome>Andretta</nome><codice>A284</codice></comune>
<comune><nome>Andria</nome><codice>A285</codice></comune>
<comune><nome>Andriano</nome><codice>A286</codice></comune>
<comune><nome>Anela</nome><codice>A287</codice></comune>
<comune><nome>Anfo</nome><codice>A288</codice></comune>
<comune><nome>Angera</nome><codice>A290</codice></comune>
<comune><nome>Anghiari</nome><codice>A291</codice></comune>
<comune><nome>Angiari</nome><codice>A292</codice></comune>
<comune><nome>Angolo Terme</nome><codice>A293</codice></comune>
<comune><nome>Angri</nome><codice>A294</codice></comune>
<comune><nome>Angrogna</nome><codice>A295</codice></comune>
<comune><nome>Anguillara Sabazia</nome><codice>A297</codice></comune>
<comune><nome>Anguillara Veneta</nome><codice>A296</codice></comune>
<comune><nome>Annicco</nome><codice>A299</codice></comune>
<comune><nome>Annone di Brianza</nome><codice>A301</codice></comune>
<comune><nome>Annone Veneto</nome><codice>A302</codice></comune>
<comune><nome>Anoia</nome><codice>A303</codice></comune>
<comune><nome>Antegnate</nome><codice>A304</codice></comune>
<comune><nome>Anterivo</nome><codice>A306</codice></comune>
<comune><nome>Antey-Saint-Andrè</nome><codice>A305</codice></comune>
<comune><nome>Anticoli Corrado</nome><codice>A309</codice></comune>
<comune><nome>Antignano</nome><codice>A312</codice></comune>
<comune><nome>Antillo</nome><codice>A313</codice></comune>
<comune><nome>Antonimina</nome><codice>A314</codice></comune>
<comune><nome>Antrodoco</nome><codice>A315</codice></comune>
<comune><nome>Antrona Schieranco</nome><codice>A317</codice></comune>
<comune><nome>Anversa degli Abruzzi</nome><codice>A318</codice></comune>
<comune><nome>Anzano del Parco</nome><codice>A319</codice></comune>
<comune><nome>Anzano di Puglia</nome><codice>A320</codice></comune>
<comune><nome>Anzi</nome><codice>A321</codice></comune>
<comune><nome>Anzio</nome><codice>A323</codice></comune>
<comune><nome>Anzola dell'Emilia</nome><codice>A324</codice></comune>
<comune><nome>Anzola d'Ossola</nome><codice>A325</codice></comune>
<comune><nome>Aosta</nome><codice>A326</codice></comune>
<comune><nome>Apecchio</nome><codice>A327</codice></comune>
<comune><nome>Apice</nome><codice>A328</codice></comune>
<comune><nome>Apiro</nome><codice>A329</codice></comune>
<comune><nome>Apollosa</nome><codice>A330</codice></comune>
<comune><nome>Appiano Gentile</nome><codice>A333</codice></comune>
<comune><nome>Appiano sulla Strada del Vino</nome><codice>A332</codice></comune>
<comune><nome>Appignano</nome><codice>A334</codice></comune>
<comune><nome>Appignano del Tronto</nome><codice>A335</codice></comune>
<comune><nome>Aprica</nome><codice>A337</codice></comune>
<comune><nome>Apricale</nome><codice>A338</codice></comune>
<comune><nome>Apricena</nome><codice>A339</codice></comune>
<comune><nome>Aprigliano</nome><codice>A340</codice></comune>
<comune><nome>Aprilia</nome><codice>A341</codice></comune>
<comune><nome>Aquara</nome><codice>A343</codice></comune>
<comune><nome>Aquila d'Arroscia</nome><codice>A344</codice></comune>
<comune><nome>Aquileia</nome><codice>A346</codice></comune>
<comune><nome>Aquilonia</nome><codice>A347</codice></comune>
<comune><nome>Aquino</nome><codice>A348</codice></comune>
<comune><nome>Aradeo</nome><codice>A350</codice></comune>
<comune><nome>Aragona</nome><codice>A351</codice></comune>
<comune><nome>Aramengo</nome><codice>A352</codice></comune>
<comune><nome>Arba</nome><codice>A354</codice></comune>
<comune><nome>Arborea</nome><codice>A357</codice></comune>
<comune><nome>Arborio</nome><codice>A358</codice></comune>
<comune><nome>Arbus</nome><codice>A359</codice></comune>
<comune><nome>Arcade</nome><codice>A360</codice></comune>
<comune><nome>Arce</nome><codice>A363</codice></comune>
<comune><nome>Arcene</nome><codice>A365</codice></comune>
<comune><nome>Arcevia</nome><codice>A366</codice></comune>
<comune><nome>Archi</nome><codice>A367</codice></comune>
<comune><nome>Arcidosso</nome><codice>A369</codice></comune>
<comune><nome>Arcinazzo Romano</nome><codice>A370</codice></comune>
<comune><nome>Arcisate</nome><codice>A371</codice></comune>
<comune><nome>Arco</nome><codice>A372</codice></comune>
<comune><nome>Arcola</nome><codice>A373</codice></comune>
<comune><nome>Arcole</nome><codice>A374</codice></comune>
<comune><nome>Arconate</nome><codice>A375</codice></comune>
<comune><nome>Arcore</nome><codice>A376</codice></comune>
<comune><nome>Arcugnano</nome><codice>A377</codice></comune>
<comune><nome>Ardara</nome><codice>A379</codice></comune>
<comune><nome>Ardauli</nome><codice>A380</codice></comune>
<comune><nome>Ardea</nome><codice>M213</codice></comune>
<comune><nome>Ardenno</nome><codice>A382</codice></comune>
<comune><nome>Ardesio</nome><codice>A383</codice></comune>
<comune><nome>Ardore</nome><codice>A385</codice></comune>
<comune><nome>Arena</nome><codice>A386</codice></comune>
<comune><nome>Arena Po</nome><codice>A387</codice></comune>
<comune><nome>Arenzano</nome><codice>A388</codice></comune>
<comune><nome>Arese</nome><codice>A389</codice></comune>
<comune><nome>Arezzo</nome><codice>A390</codice></comune>
<comune><nome>Argegno</nome><codice>A391</codice></comune>
<comune><nome>Argelato</nome><codice>A392</codice></comune>
<comune><nome>Argenta</nome><codice>A393</codice></comune>
<comune><nome>Argentera</nome><codice>A394</codice></comune>
<comune><nome>Arguello</nome><codice>A396</codice></comune>
<comune><nome>Argusto</nome><codice>A397</codice></comune>
<comune><nome>Ari</nome><codice>A398</codice></comune>
<comune><nome>Ariano Irpino</nome><codice>A399</codice></comune>
<comune><nome>Ariano nel Polesine</nome><codice>A400</codice></comune>
<comune><nome>Ariccia</nome><codice>A401</codice></comune>
<comune><nome>Arielli</nome><codice>A402</codice></comune>
<comune><nome>Arienzo</nome><codice>A403</codice></comune>
<comune><nome>Arignano</nome><codice>A405</codice></comune>
<comune><nome>Aritzo</nome><codice>A407</codice></comune>
<comune><nome>Arizzano</nome><codice>A409</codice></comune>
<comune><nome>Arlena di Castro</nome><codice>A412</codice></comune>
<comune><nome>Arluno</nome><codice>A413</codice></comune>
<comune><nome>Armeno</nome><codice>A414</codice></comune>
<comune><nome>Armento</nome><codice>A415</codice></comune>
<comune><nome>Armo</nome><codice>A418</codice></comune>
<comune><nome>Armungia</nome><codice>A419</codice></comune>
<comune><nome>Arnad</nome><codice>A424</codice></comune>
<comune><nome>Arnara</nome><codice>A421</codice></comune>
<comune><nome>Arnasco</nome><codice>A422</codice></comune>
<comune><nome>Arnesano</nome><codice>A425</codice></comune>
<comune><nome>Arola</nome><codice>A427</codice></comune>
<comune><nome>Arona</nome><codice>A429</codice></comune>
<comune><nome>Arosio</nome><codice>A430</codice></comune>
<comune><nome>Arpaia</nome><codice>A431</codice></comune>
<comune><nome>Arpaise</nome><codice>A432</codice></comune>
<comune><nome>Arpino</nome><codice>A433</codice></comune>
<comune><nome>Arquà Petrarca</nome><codice>A434</codice></comune>
<comune><nome>Arquà Polesine</nome><codice>A435</codice></comune>
<comune><nome>Arquata del Tronto</nome><codice>A437</codice></comune>
<comune><nome>Arquata Scrivia</nome><codice>A436</codice></comune>
<comune><nome>Arre</nome><codice>A438</codice></comune>
<comune><nome>Arrone</nome><codice>A439</codice></comune>
<comune><nome>Arsago Seprio</nome><codice>A441</codice></comune>
<comune><nome>Arsiè</nome><codice>A443</codice></comune>
<comune><nome>Arsiero</nome><codice>A444</codice></comune>
<comune><nome>Arsita</nome><codice>A445</codice></comune>
<comune><nome>Arsoli</nome><codice>A446</codice></comune>
<comune><nome>Arta Terme</nome><codice>A447</codice></comune>
<comune><nome>Artegna</nome><codice>A448</codice></comune>
<comune><nome>Artena</nome><codice>A449</codice></comune>
<comune><nome>Artogne</nome><codice>A451</codice></comune>
<comune><nome>Arvier</nome><codice>A452</codice></comune>
<comune><nome>Arzachena</nome><codice>A453</codice></comune>
<comune><nome>Arzago d'Adda</nome><codice>A440</codice></comune>
<comune><nome>Arzana</nome><codice>A454</codice></comune>
<comune><nome>Arzano</nome><codice>A455</codice></comune>
<comune><nome>Arzene</nome><codice>A456</codice></comune>
<comune><nome>Arzergrande</nome><codice>A458</codice></comune>
<comune><nome>Arzignano</nome><codice>A459</codice></comune>
<comune><nome>Ascea</nome><codice>A460</codice></comune>
<comune><nome>Asciano</nome><codice>A461</codice></comune>
<comune><nome>Ascoli Piceno</nome><codice>A462</codice></comune>
<comune><nome>Ascoli Satriano</nome><codice>A463</codice></comune>
<comune><nome>Ascrea</nome><codice>A464</codice></comune>
<comune><nome>Asiago</nome><codice>A465</codice></comune>
<comune><nome>Asigliano Veneto</nome><codice>A467</codice></comune>
<comune><nome>Asigliano Vercellese</nome><codice>A466</codice></comune>
<comune><nome>Asola</nome><codice>A470</codice></comune>
<comune><nome>Asolo</nome><codice>A471</codice></comune>
<comune><nome>Assago</nome><codice>A473</codice></comune>
<comune><nome>Assemini</nome><codice>A474</codice></comune>
<comune><nome>Assisi</nome><codice>A475</codice></comune>
<comune><nome>Asso</nome><codice>A476</codice></comune>
<comune><nome>Assolo</nome><codice>A477</codice></comune>
<comune><nome>Assoro</nome><codice>A478</codice></comune>
<comune><nome>Asti</nome><codice>A479</codice></comune>
<comune><nome>Asuni</nome><codice>A480</codice></comune>
<comune><nome>Ateleta</nome><codice>A481</codice></comune>
<comune><nome>Atella</nome><codice>A482</codice></comune>
<comune><nome>Atena Lucana</nome><codice>A484</codice></comune>
<comune><nome>Atessa</nome><codice>A485</codice></comune>
<comune><nome>Atina</nome><codice>A486</codice></comune>
<comune><nome>Atrani</nome><codice>A487</codice></comune>
<comune><nome>Atri</nome><codice>A488</codice></comune>
<comune><nome>Atripalda</nome><codice>A489</codice></comune>
<comune><nome>Attigliano</nome><codice>A490</codice></comune>
<comune><nome>Attimis</nome><codice>A491</codice></comune>
<comune><nome>Atzara</nome><codice>A492</codice></comune>
<comune><nome>Auditore</nome><codice>A493</codice></comune>
<comune><nome>Augusta</nome><codice>A494</codice></comune>
<comune><nome>Auletta</nome><codice>A495</codice></comune>
<comune><nome>Aulla</nome><codice>A496</codice></comune>
<comune><nome>Aurano</nome><codice>A497</codice></comune>
<comune><nome>Aurigo</nome><codice>A499</codice></comune>
<comune><nome>Auronzo di Cadore</nome><codice>A501</codice></comune>
<comune><nome>Ausonia</nome><codice>A502</codice></comune>
<comune><nome>Austis</nome><codice>A503</codice></comune>
<comune><nome>Avegno</nome><codice>A506</codice></comune>
<comune><nome>Avelengo</nome><codice>A507</codice></comune>
<comune><nome>Avella</nome><codice>A508</codice></comune>
<comune><nome>Avellino</nome><codice>A509</codice></comune>
<comune><nome>Averara</nome><codice>A511</codice></comune>
<comune><nome>Aversa</nome><codice>A512</codice></comune>
<comune><nome>Avetrana</nome><codice>A514</codice></comune>
<comune><nome>Avezzano</nome><codice>A515</codice></comune>
<comune><nome>Aviano</nome><codice>A516</codice></comune>
<comune><nome>Aviatico</nome><codice>A517</codice></comune>
<comune><nome>Avigliana</nome><codice>A518</codice></comune>
<comune><nome>Avigliano</nome><codice>A519</codice></comune>
<comune><nome>Avigliano Umbro</nome><codice>M258</codice></comune>
<comune><nome>Avio</nome><codice>A520</codice></comune>
<comune><nome>Avise</nome><codice>A521</codice></comune>
<comune><nome>Avola</nome><codice>A522</codice></comune>
<comune><nome>Avolasca</nome><codice>A523</codice></comune>
<comune><nome>Ayas</nome><codice>A094</codice></comune>
<comune><nome>Aymavilles</nome><codice>A108</codice></comune>
<comune><nome>Azeglio</nome><codice>A525</codice></comune>
<comune><nome>Azzanello</nome><codice>A526</codice></comune>
<comune><nome>Azzano d'Asti</nome><codice>A527</codice></comune>
<comune><nome>Azzano Decimo</nome><codice>A530</codice></comune>
<comune><nome>Azzano Mella</nome><codice>A529</codice></comune>
<comune><nome>Azzano San Paolo</nome><codice>A528</codice></comune>
<comune><nome>Azzate</nome><codice>A531</codice></comune>
<comune><nome>Azzio</nome><codice>A532</codice></comune>
<comune><nome>Azzone</nome><codice>A533</codice></comune>
<comune><nome>Baceno</nome><codice>A534</codice></comune>
<comune><nome>Bacoli</nome><codice>A535</codice></comune>
<comune><nome>Badalucco</nome><codice>A536</codice></comune>
<comune><nome>Badesi</nome><codice>M214</codice></comune>
<comune><nome>Badia</nome><codice>A537</codice></comune>
<comune><nome>Badia Calavena</nome><codice>A540</codice></comune>
<comune><nome>Badia Pavese</nome><codice>A538</codice></comune>
<comune><nome>Badia Polesine</nome><codice>A539</codice></comune>
<comune><nome>Badia Tedalda</nome><codice>A541</codice></comune>
<comune><nome>Badolato</nome><codice>A542</codice></comune>
<comune><nome>Bagaladi</nome><codice>A544</codice></comune>
<comune><nome>Bagheria</nome><codice>A546</codice></comune>
<comune><nome>Bagnacavallo</nome><codice>A547</codice></comune>
<comune><nome>Bagnara Calabra</nome><codice>A552</codice></comune>
<comune><nome>Bagnara di Romagna</nome><codice>A551</codice></comune>
<comune><nome>Bagnaria</nome><codice>A550</codice></comune>
<comune><nome>Bagnaria Arsa</nome><codice>A553</codice></comune>
<comune><nome>Bagnasco</nome><codice>A555</codice></comune>
<comune><nome>Bagnatica</nome><codice>A557</codice></comune>
<comune><nome>Bagni di Lucca</nome><codice>A560</codice></comune>
<comune><nome>Bagno a Ripoli</nome><codice>A564</codice></comune>
<comune><nome>Bagno di Romagna</nome><codice>A565</codice></comune>
<comune><nome>Bagnoli del Trigno</nome><codice>A567</codice></comune>
<comune><nome>Bagnoli di Sopra</nome><codice>A568</codice></comune>
<comune><nome>Bagnoli Irpino</nome><codice>A566</codice></comune>
<comune><nome>Bagnolo Cremasco</nome><codice>A570</codice></comune>
<comune><nome>Bagnolo del Salento</nome><codice>A572</codice></comune>
<comune><nome>Bagnolo di Po</nome><codice>A574</codice></comune>
<comune><nome>Bagnolo in Piano</nome><codice>A573</codice></comune>
<comune><nome>Bagnolo Mella</nome><codice>A569</codice></comune>
<comune><nome>Bagnolo Piemonte</nome><codice>A571</codice></comune>
<comune><nome>Bagnolo San Vito</nome><codice>A575</codice></comune>
<comune><nome>Bagnone</nome><codice>A576</codice></comune>
<comune><nome>Bagnoregio</nome><codice>A577</codice></comune>
<comune><nome>Bagolino</nome><codice>A578</codice></comune>
<comune><nome>Baia e Latina</nome><codice>A579</codice></comune>
<comune><nome>Baiano</nome><codice>A580</codice></comune>
<comune><nome>Bairo</nome><codice>A584</codice></comune>
<comune><nome>Baiso</nome><codice>A586</codice></comune>
<comune><nome>Bajardo</nome><codice>A581</codice></comune>
<comune><nome>Balangero</nome><codice>A587</codice></comune>
<comune><nome>Baldichieri d'Asti</nome><codice>A588</codice></comune>
<comune><nome>Baldissero Canavese</nome><codice>A590</codice></comune>
<comune><nome>Baldissero d'Alba</nome><codice>A589</codice></comune>
<comune><nome>Baldissero Torinese</nome><codice>A591</codice></comune>
<comune><nome>Balestrate</nome><codice>A592</codice></comune>
<comune><nome>Balestrino</nome><codice>A593</codice></comune>
<comune><nome>Ballabio</nome><codice>A594</codice></comune>
<comune><nome>Ballao</nome><codice>A597</codice></comune>
<comune><nome>Balme</nome><codice>A599</codice></comune>
<comune><nome>Balmuccia</nome><codice>A600</codice></comune>
<comune><nome>Balocco</nome><codice>A601</codice></comune>
<comune><nome>Balsorano</nome><codice>A603</codice></comune>
<comune><nome>Balvano</nome><codice>A604</codice></comune>
<comune><nome>Balzola</nome><codice>A605</codice></comune>
<comune><nome>Banari</nome><codice>A606</codice></comune>
<comune><nome>Banchette</nome><codice>A607</codice></comune>
<comune><nome>Bannio Anzino</nome><codice>A610</codice></comune>
<comune><nome>Banzi</nome><codice>A612</codice></comune>
<comune><nome>Baone</nome><codice>A613</codice></comune>
<comune><nome>Baradili</nome><codice>A614</codice></comune>
<comune><nome>Baragiano</nome><codice>A615</codice></comune>
<comune><nome>Baranello</nome><codice>A616</codice></comune>
<comune><nome>Barano d'Ischia</nome><codice>A617</codice></comune>
<comune><nome>Baranzate</nome><codice>A618</codice></comune>
<comune><nome>Barasso</nome><codice>A619</codice></comune>
<comune><nome>Baratili San Pietro</nome><codice>A621</codice></comune>
<comune><nome>Barbania</nome><codice>A625</codice></comune>
<comune><nome>Barbara</nome><codice>A626</codice></comune>
<comune><nome>Barbarano Romano</nome><codice>A628</codice></comune>
<comune><nome>Barbarano Vicentino</nome><codice>A627</codice></comune>
<comune><nome>Barbaresco</nome><codice>A629</codice></comune>
<comune><nome>Barbariga</nome><codice>A630</codice></comune>
<comune><nome>Barbata</nome><codice>A631</codice></comune>
<comune><nome>Barberino di Mugello</nome><codice>A632</codice></comune>
<comune><nome>Barberino Val d'Elsa</nome><codice>A633</codice></comune>
<comune><nome>Barbianello</nome><codice>A634</codice></comune>
<comune><nome>Barbiano</nome><codice>A635</codice></comune>
<comune><nome>Barbona</nome><codice>A637</codice></comune>
<comune><nome>Barcellona Pozzo di Gotto</nome><codice>A638</codice></comune>
<comune><nome>Barchi</nome><codice>A639</codice></comune>
<comune><nome>Barcis</nome><codice>A640</codice></comune>
<comune><nome>Bard</nome><codice>A643</codice></comune>
<comune><nome>Bardello</nome><codice>A645</codice></comune>
<comune><nome>Bardi</nome><codice>A646</codice></comune>
<comune><nome>Bardineto</nome><codice>A647</codice></comune>
<comune><nome>Bardolino</nome><codice>A650</codice></comune>
<comune><nome>Bardonecchia</nome><codice>A651</codice></comune>
<comune><nome>Bareggio</nome><codice>A652</codice></comune>
<comune><nome>Barengo</nome><codice>A653</codice></comune>
<comune><nome>Baressa</nome><codice>A655</codice></comune>
<comune><nome>Barete</nome><codice>A656</codice></comune>
<comune><nome>Barga</nome><codice>A657</codice></comune>
<comune><nome>Bargagli</nome><codice>A658</codice></comune>
<comune><nome>Barge</nome><codice>A660</codice></comune>
<comune><nome>Barghe</nome><codice>A661</codice></comune>
<comune><nome>Bari</nome><codice>A662</codice></comune>
<comune><nome>Bari Sardo</nome><codice>A663</codice></comune>
<comune><nome>Bariano</nome><codice>A664</codice></comune>
<comune><nome>Baricella</nome><codice>A665</codice></comune>
<comune><nome>Barile</nome><codice>A666</codice></comune>
<comune><nome>Barisciano</nome><codice>A667</codice></comune>
<comune><nome>Barlassina</nome><codice>A668</codice></comune>
<comune><nome>Barletta</nome><codice>A669</codice></comune>
<comune><nome>Barni</nome><codice>A670</codice></comune>
<comune><nome>Barolo</nome><codice>A671</codice></comune>
<comune><nome>Barone Canavese</nome><codice>A673</codice></comune>
<comune><nome>Baronissi</nome><codice>A674</codice></comune>
<comune><nome>Barrafranca</nome><codice>A676</codice></comune>
<comune><nome>Barrali</nome><codice>A677</codice></comune>
<comune><nome>Barrea</nome><codice>A678</codice></comune>
<comune><nome>Barumini</nome><codice>A681</codice></comune>
<comune><nome>Barzago</nome><codice>A683</codice></comune>
<comune><nome>Barzana</nome><codice>A684</codice></comune>
<comune><nome>Barzanò</nome><codice>A686</codice></comune>
<comune><nome>Barzio</nome><codice>A687</codice></comune>
<comune><nome>Basaluzzo</nome><codice>A689</codice></comune>
<comune><nome>Bascapè</nome><codice>A690</codice></comune>
<comune><nome>Baschi</nome><codice>A691</codice></comune>
<comune><nome>Basciano</nome><codice>A692</codice></comune>
<comune><nome>Baselga di Pinè</nome><codice>A694</codice></comune>
<comune><nome>Baselice</nome><codice>A696</codice></comune>
<comune><nome>Basiano</nome><codice>A697</codice></comune>
<comune><nome>Basicò</nome><codice>A698</codice></comune>
<comune><nome>Basiglio</nome><codice>A699</codice></comune>
<comune><nome>Basiliano</nome><codice>A700</codice></comune>
<comune><nome>Bassano Bresciano</nome><codice>A702</codice></comune>
<comune><nome>Bassano del Grappa</nome><codice>A703</codice></comune>
<comune><nome>Bassano in Teverina</nome><codice>A706</codice></comune>
<comune><nome>Bassano Romano</nome><codice>A704</codice></comune>
<comune><nome>Bassiano</nome><codice>A707</codice></comune>
<comune><nome>Bassignana</nome><codice>A708</codice></comune>
<comune><nome>Bastia Mondovì</nome><codice>A709</codice></comune>
<comune><nome>Bastia Umbra</nome><codice>A710</codice></comune>
<comune><nome>Bastida de' Dossi</nome><codice>A711</codice></comune>
<comune><nome>Bastida Pancarana</nome><codice>A712</codice></comune>
<comune><nome>Bastiglia</nome><codice>A713</codice></comune>
<comune><nome>Battaglia Terme</nome><codice>A714</codice></comune>
<comune><nome>Battifollo</nome><codice>A716</codice></comune>
<comune><nome>Battipaglia</nome><codice>A717</codice></comune>
<comune><nome>Battuda</nome><codice>A718</codice></comune>
<comune><nome>Baucina</nome><codice>A719</codice></comune>
<comune><nome>Bauladu</nome><codice>A721</codice></comune>
<comune><nome>Baunei</nome><codice>A722</codice></comune>
<comune><nome>Baveno</nome><codice>A725</codice></comune>
<comune><nome>Bazzano</nome><codice>A726</codice></comune>
<comune><nome>Bedero Valcuvia</nome><codice>A728</codice></comune>
<comune><nome>Bedizzole</nome><codice>A729</codice></comune>
<comune><nome>Bedollo</nome><codice>A730</codice></comune>
<comune><nome>Bedonia</nome><codice>A731</codice></comune>
<comune><nome>Bedulita</nome><codice>A732</codice></comune>
<comune><nome>Bee</nome><codice>A733</codice></comune>
<comune><nome>Beinasco</nome><codice>A734</codice></comune>
<comune><nome>Beinette</nome><codice>A735</codice></comune>
<comune><nome>Belcastro</nome><codice>A736</codice></comune>
<comune><nome>Belfiore</nome><codice>A737</codice></comune>
<comune><nome>Belforte all'Isauro</nome><codice>A740</codice></comune>
<comune><nome>Belforte del Chienti</nome><codice>A739</codice></comune>
<comune><nome>Belforte Monferrato</nome><codice>A738</codice></comune>
<comune><nome>Belgioioso</nome><codice>A741</codice></comune>
<comune><nome>Belgirate</nome><codice>A742</codice></comune>
<comune><nome>Bella</nome><codice>A743</codice></comune>
<comune><nome>Bellagio</nome><codice>A744</codice></comune>
<comune><nome>Bellano</nome><codice>A745</codice></comune>
<comune><nome>Bellante</nome><codice>A746</codice></comune>
<comune><nome>Bellaria-Igea Marina</nome><codice>A747</codice></comune>
<comune><nome>Bellegra</nome><codice>A749</codice></comune>
<comune><nome>Bellino</nome><codice>A750</codice></comune>
<comune><nome>Bellinzago Lombardo</nome><codice>A751</codice></comune>
<comune><nome>Bellinzago Novarese</nome><codice>A752</codice></comune>
<comune><nome>Bellizzi</nome><codice>M294</codice></comune>
<comune><nome>Bellona</nome><codice>A755</codice></comune>
<comune><nome>Bellosguardo</nome><codice>A756</codice></comune>
<comune><nome>Belluno</nome><codice>A757</codice></comune>
<comune><nome>Bellusco</nome><codice>A759</codice></comune>
<comune><nome>Belmonte Calabro</nome><codice>A762</codice></comune>
<comune><nome>Belmonte Castello</nome><codice>A763</codice></comune>
<comune><nome>Belmonte del Sannio</nome><codice>A761</codice></comune>
<comune><nome>Belmonte in Sabina</nome><codice>A765</codice></comune>
<comune><nome>Belmonte Mezzagno</nome><codice>A764</codice></comune>
<comune><nome>Belmonte Piceno</nome><codice>A760</codice></comune>
<comune><nome>Belpasso</nome><codice>A766</codice></comune>
<comune><nome>Belsito</nome><codice>A768</codice></comune>
<comune><nome>Belvedere di Spinello</nome><codice>A772</codice></comune>
<comune><nome>Belvedere Langhe</nome><codice>A774</codice></comune>
<comune><nome>Belvedere Marittimo</nome><codice>A773</codice></comune>
<comune><nome>Belvedere Ostrense</nome><codice>A769</codice></comune>
<comune><nome>Belveglio</nome><codice>A770</codice></comune>
<comune><nome>Belvì</nome><codice>A776</codice></comune>
<comune><nome>Bema</nome><codice>A777</codice></comune>
<comune><nome>Bene Lario</nome><codice>A778</codice></comune>
<comune><nome>Bene Vagienna</nome><codice>A779</codice></comune>
<comune><nome>Benestare</nome><codice>A780</codice></comune>
<comune><nome>Benetutti</nome><codice>A781</codice></comune>
<comune><nome>Benevello</nome><codice>A782</codice></comune>
<comune><nome>Benevento</nome><codice>A783</codice></comune>
<comune><nome>Benna</nome><codice>A784</codice></comune>
<comune><nome>Bentivoglio</nome><codice>A785</codice></comune>
<comune><nome>Berbenno</nome><codice>A786</codice></comune>
<comune><nome>Berbenno di Valtellina</nome><codice>A787</codice></comune>
<comune><nome>Berceto</nome><codice>A788</codice></comune>
<comune><nome>Berchidda</nome><codice>A789</codice></comune>
<comune><nome>Beregazzo con Figliaro</nome><codice>A791</codice></comune>
<comune><nome>Bereguardo</nome><codice>A792</codice></comune>
<comune><nome>Bergamasco</nome><codice>A793</codice></comune>
<comune><nome>Bergamo</nome><codice>A794</codice></comune>
<comune><nome>Bergantino</nome><codice>A795</codice></comune>
<comune><nome>Bergeggi</nome><codice>A796</codice></comune>
<comune><nome>Bergolo</nome><codice>A798</codice></comune>
<comune><nome>Berlingo</nome><codice>A799</codice></comune>
<comune><nome>Bernalda</nome><codice>A801</codice></comune>
<comune><nome>Bernareggio</nome><codice>A802</codice></comune>
<comune><nome>Bernate Ticino</nome><codice>A804</codice></comune>
<comune><nome>Bernezzo</nome><codice>A805</codice></comune>
<comune><nome>Berra</nome><codice>A806</codice></comune>
<comune><nome>Bersone</nome><codice>A808</codice></comune>
<comune><nome>Bertinoro</nome><codice>A809</codice></comune>
<comune><nome>Bertiolo</nome><codice>A810</codice></comune>
<comune><nome>Bertonico</nome><codice>A811</codice></comune>
<comune><nome>Berzano di San Pietro</nome><codice>A812</codice></comune>
<comune><nome>Berzano di Tortona</nome><codice>A813</codice></comune>
<comune><nome>Berzo Demo</nome><codice>A816</codice></comune>
<comune><nome>Berzo Inferiore</nome><codice>A817</codice></comune>
<comune><nome>Berzo San Fermo</nome><codice>A815</codice></comune>
<comune><nome>Besana in Brianza</nome><codice>A818</codice></comune>
<comune><nome>Besano</nome><codice>A819</codice></comune>
<comune><nome>Besate</nome><codice>A820</codice></comune>
<comune><nome>Besenello</nome><codice>A821</codice></comune>
<comune><nome>Besenzone</nome><codice>A823</codice></comune>
<comune><nome>Besnate</nome><codice>A825</codice></comune>
<comune><nome>Besozzo</nome><codice>A826</codice></comune>
<comune><nome>Bessude</nome><codice>A827</codice></comune>
<comune><nome>Bettola</nome><codice>A831</codice></comune>
<comune><nome>Bettona</nome><codice>A832</codice></comune>
<comune><nome>Beura-Cardezza</nome><codice>A834</codice></comune>
<comune><nome>Bevagna</nome><codice>A835</codice></comune>
<comune><nome>Beverino</nome><codice>A836</codice></comune>
<comune><nome>Bevilacqua</nome><codice>A837</codice></comune>
<comune><nome>Biancavilla</nome><codice>A841</codice></comune>
<comune><nome>Bianchi</nome><codice>A842</codice></comune>
<comune><nome>Bianco</nome><codice>A843</codice></comune>
<comune><nome>Biandrate</nome><codice>A844</codice></comune>
<comune><nome>Biandronno</nome><codice>A845</codice></comune>
<comune><nome>Bianzano</nome><codice>A846</codice></comune>
<comune><nome>Bianzè</nome><codice>A847</codice></comune>
<comune><nome>Bianzone</nome><codice>A848</codice></comune>
<comune><nome>Biassono</nome><codice>A849</codice></comune>
<comune><nome>Bibbiano</nome><codice>A850</codice></comune>
<comune><nome>Bibbiena</nome><codice>A851</codice></comune>
<comune><nome>Bibbona</nome><codice>A852</codice></comune>
<comune><nome>Bibiana</nome><codice>A853</codice></comune>
<comune><nome>Biccari</nome><codice>A854</codice></comune>
<comune><nome>Bicinicco</nome><codice>A855</codice></comune>
<comune><nome>Bidonì</nome><codice>A856</codice></comune>
<comune><nome>Biella</nome><codice>A859</codice></comune>
<comune><nome>Bienno</nome><codice>A861</codice></comune>
<comune><nome>Bieno</nome><codice>A863</codice></comune>
<comune><nome>Bientina</nome><codice>A864</codice></comune>
<comune><nome>Bigarello</nome><codice>A866</codice></comune>
<comune><nome>Binago</nome><codice>A870</codice></comune>
<comune><nome>Binasco</nome><codice>A872</codice></comune>
<comune><nome>Binetto</nome><codice>A874</codice></comune>
<comune><nome>Bioglio</nome><codice>A876</codice></comune>
<comune><nome>Bionaz</nome><codice>A877</codice></comune>
<comune><nome>Bione</nome><codice>A878</codice></comune>
<comune><nome>Birori</nome><codice>A880</codice></comune>
<comune><nome>Bisaccia</nome><codice>A881</codice></comune>
<comune><nome>Bisacquino</nome><codice>A882</codice></comune>
<comune><nome>Bisceglie</nome><codice>A883</codice></comune>
<comune><nome>Bisegna</nome><codice>A884</codice></comune>
<comune><nome>Bisenti</nome><codice>A885</codice></comune>
<comune><nome>Bisignano</nome><codice>A887</codice></comune>
<comune><nome>Bistagno</nome><codice>A889</codice></comune>
<comune><nome>Bisuschio</nome><codice>A891</codice></comune>
<comune><nome>Bitetto</nome><codice>A892</codice></comune>
<comune><nome>Bitonto</nome><codice>A893</codice></comune>
<comune><nome>Bitritto</nome><codice>A894</codice></comune>
<comune><nome>Bitti</nome><codice>A895</codice></comune>
<comune><nome>Bivona</nome><codice>A896</codice></comune>
<comune><nome>Bivongi</nome><codice>A897</codice></comune>
<comune><nome>Bizzarone</nome><codice>A898</codice></comune>
<comune><nome>Bleggio Superiore</nome><codice>A902</codice></comune>
<comune><nome>Blello</nome><codice>A903</codice></comune>
<comune><nome>Blera</nome><codice>A857</codice></comune>
<comune><nome>Blessagno</nome><codice>A904</codice></comune>
<comune><nome>Blevio</nome><codice>A905</codice></comune>
<comune><nome>Blufi</nome><codice>M268</codice></comune>
<comune><nome>Boara Pisani</nome><codice>A906</codice></comune>
<comune><nome>Bobbio</nome><codice>A909</codice></comune>
<comune><nome>Bobbio Pellice</nome><codice>A910</codice></comune>
<comune><nome>Boca</nome><codice>A911</codice></comune>
<comune><nome>Bocchigliero</nome><codice>A912</codice></comune>
<comune><nome>Boccioleto</nome><codice>A914</codice></comune>
<comune><nome>Bocenago</nome><codice>A916</codice></comune>
<comune><nome>Bodio Lomnago</nome><codice>A918</codice></comune>
<comune><nome>Boffalora d'Adda</nome><codice>A919</codice></comune>
<comune><nome>Boffalora Sopra Ticino</nome><codice>A920</codice></comune>
<comune><nome>Bogliasco</nome><codice>A922</codice></comune>
<comune><nome>Bognanco</nome><codice>A925</codice></comune>
<comune><nome>Bogogno</nome><codice>A929</codice></comune>
<comune><nome>Boissano</nome><codice>A931</codice></comune>
<comune><nome>Bojano</nome><codice>A930</codice></comune>
<comune><nome>Bolano</nome><codice>A932</codice></comune>
<comune><nome>Bolbeno</nome><codice>A933</codice></comune>
<comune><nome>Bolgare</nome><codice>A937</codice></comune>
<comune><nome>Bollate</nome><codice>A940</codice></comune>
<comune><nome>Bollengo</nome><codice>A941</codice></comune>
<comune><nome>Bologna</nome><codice>A944</codice></comune>
<comune><nome>Bolognano</nome><codice>A945</codice></comune>
<comune><nome>Bolognetta</nome><codice>A946</codice></comune>
<comune><nome>Bolognola</nome><codice>A947</codice></comune>
<comune><nome>Bolotana</nome><codice>A948</codice></comune>
<comune><nome>Bolsena</nome><codice>A949</codice></comune>
<comune><nome>Boltiere</nome><codice>A950</codice></comune>
<comune><nome>Bolzano</nome><codice>A952</codice></comune>
<comune><nome>Bolzano Novarese</nome><codice>A953</codice></comune>
<comune><nome>Bolzano Vicentino</nome><codice>A954</codice></comune>
<comune><nome>Bomarzo</nome><codice>A955</codice></comune>
<comune><nome>Bomba</nome><codice>A956</codice></comune>
<comune><nome>Bompensiere</nome><codice>A957</codice></comune>
<comune><nome>Bompietro</nome><codice>A958</codice></comune>
<comune><nome>Bomporto</nome><codice>A959</codice></comune>
<comune><nome>Bonarcado</nome><codice>A960</codice></comune>
<comune><nome>Bonassola</nome><codice>A961</codice></comune>
<comune><nome>Bonate Sopra</nome><codice>A963</codice></comune>
<comune><nome>Bonate Sotto</nome><codice>A962</codice></comune>
<comune><nome>Bonavigo</nome><codice>A964</codice></comune>
<comune><nome>Bondeno</nome><codice>A965</codice></comune>
<comune><nome>Bondo</nome><codice>A967</codice></comune>
<comune><nome>Bondone</nome><codice>A968</codice></comune>
<comune><nome>Bonea</nome><codice>A970</codice></comune>
<comune><nome>Bonefro</nome><codice>A971</codice></comune>
<comune><nome>Bonemerse</nome><codice>A972</codice></comune>
<comune><nome>Bonifati</nome><codice>A973</codice></comune>
<comune><nome>Bonito</nome><codice>A975</codice></comune>
<comune><nome>Bonnanaro</nome><codice>A976</codice></comune>
<comune><nome>Bono</nome><codice>A977</codice></comune>
<comune><nome>Bonorva</nome><codice>A978</codice></comune>
<comune><nome>Bonvicino</nome><codice>A979</codice></comune>
<comune><nome>Borbona</nome><codice>A981</codice></comune>
<comune><nome>Borca di Cadore</nome><codice>A982</codice></comune>
<comune><nome>Bordano</nome><codice>A983</codice></comune>
<comune><nome>Bordighera</nome><codice>A984</codice></comune>
<comune><nome>Bordolano</nome><codice>A986</codice></comune>
<comune><nome>Bore</nome><codice>A987</codice></comune>
<comune><nome>Boretto</nome><codice>A988</codice></comune>
<comune><nome>Borgarello</nome><codice>A989</codice></comune>
<comune><nome>Borgaro Torinese</nome><codice>A990</codice></comune>
<comune><nome>Borgetto</nome><codice>A991</codice></comune>
<comune><nome>Borghetto d'Arroscia</nome><codice>A993</codice></comune>
<comune><nome>Borghetto di Borbera</nome><codice>A998</codice></comune>
<comune><nome>Borghetto di Vara</nome><codice>A992</codice></comune>
<comune><nome>Borghetto Lodigiano</nome><codice>A995</codice></comune>
<comune><nome>Borghetto Santo Spirito</nome><codice>A999</codice></comune>
<comune><nome>Borghi</nome><codice>B001</codice></comune>
<comune><nome>Borgia</nome><codice>B002</codice></comune>
<comune><nome>Borgiallo</nome><codice>B003</codice></comune>
<comune><nome>Borgio Verezzi</nome><codice>B005</codice></comune>
<comune><nome>Borgo a Mozzano</nome><codice>B007</codice></comune>
<comune><nome>Borgo d'Ale</nome><codice>B009</codice></comune>
<comune><nome>Borgo di Terzo</nome><codice>B010</codice></comune>
<comune><nome>Borgo Pace</nome><codice>B026</codice></comune>
<comune><nome>Borgo Priolo</nome><codice>B028</codice></comune>
<comune><nome>Borgo San Dalmazzo</nome><codice>B033</codice></comune>
<comune><nome>Borgo San Giacomo</nome><codice>B035</codice></comune>
<comune><nome>Borgo San Giovanni</nome><codice>B017</codice></comune>
<comune><nome>Borgo San Lorenzo</nome><codice>B036</codice></comune>
<comune><nome>Borgo San Martino</nome><codice>B037</codice></comune>
<comune><nome>Borgo San Siro</nome><codice>B038</codice></comune>
<comune><nome>Borgo Ticino</nome><codice>B043</codice></comune>
<comune><nome>Borgo Tossignano</nome><codice>B044</codice></comune>
<comune><nome>Borgo Val di Taro</nome><codice>B042</codice></comune>
<comune><nome>Borgo Valsugana</nome><codice>B006</codice></comune>
<comune><nome>Borgo Velino</nome><codice>A996</codice></comune>
<comune><nome>Borgo Vercelli</nome><codice>B046</codice></comune>
<comune><nome>Borgoforte</nome><codice>B011</codice></comune>
<comune><nome>Borgofranco d'Ivrea</nome><codice>B015</codice></comune>
<comune><nome>Borgofranco sul Po</nome><codice>B013</codice></comune>
<comune><nome>Borgolavezzaro</nome><codice>B016</codice></comune>
<comune><nome>Borgomale</nome><codice>B018</codice></comune>
<comune><nome>Borgomanero</nome><codice>B019</codice></comune>
<comune><nome>Borgomaro</nome><codice>B020</codice></comune>
<comune><nome>Borgomasino</nome><codice>B021</codice></comune>
<comune><nome>Borgone Susa</nome><codice>B024</codice></comune>
<comune><nome>Borgonovo Val Tidone</nome><codice>B025</codice></comune>
<comune><nome>Borgoratto Alessandrino</nome><codice>B029</codice></comune>
<comune><nome>Borgoratto Mormorolo</nome><codice>B030</codice></comune>
<comune><nome>Borgoricco</nome><codice>B031</codice></comune>
<comune><nome>Borgorose</nome><codice>B008</codice></comune>
<comune><nome>Borgosatollo</nome><codice>B040</codice></comune>
<comune><nome>Borgosesia</nome><codice>B041</codice></comune>
<comune><nome>Bormida</nome><codice>B048</codice></comune>
<comune><nome>Bormio</nome><codice>B049</codice></comune>
<comune><nome>Bornasco</nome><codice>B051</codice></comune>
<comune><nome>Borno</nome><codice>B054</codice></comune>
<comune><nome>Boroneddu</nome><codice>B055</codice></comune>
<comune><nome>Borore</nome><codice>B056</codice></comune>
<comune><nome>Borrello</nome><codice>B057</codice></comune>
<comune><nome>Borriana</nome><codice>B058</codice></comune>
<comune><nome>Borso del Grappa</nome><codice>B061</codice></comune>
<comune><nome>Bortigali</nome><codice>B062</codice></comune>
<comune><nome>Bortigiadas</nome><codice>B063</codice></comune>
<comune><nome>Borutta</nome><codice>B064</codice></comune>
<comune><nome>Borzonasca</nome><codice>B067</codice></comune>
<comune><nome>Bosa</nome><codice>B068</codice></comune>
<comune><nome>Bosaro</nome><codice>B069</codice></comune>
<comune><nome>Boschi Sant'Anna</nome><codice>B070</codice></comune>
<comune><nome>Bosco Chiesanuova</nome><codice>B073</codice></comune>
<comune><nome>Bosco Marengo</nome><codice>B071</codice></comune>
<comune><nome>Bosconero</nome><codice>B075</codice></comune>
<comune><nome>Boscoreale</nome><codice>B076</codice></comune>
<comune><nome>Boscotrecase</nome><codice>B077</codice></comune>
<comune><nome>Bosentino</nome><codice>B078</codice></comune>
<comune><nome>Bosia</nome><codice>B079</codice></comune>
<comune><nome>Bosio</nome><codice>B080</codice></comune>
<comune><nome>Bosisio Parini</nome><codice>B081</codice></comune>
<comune><nome>Bosnasco</nome><codice>B082</codice></comune>
<comune><nome>Bossico</nome><codice>B083</codice></comune>
<comune><nome>Bossolasco</nome><codice>B084</codice></comune>
<comune><nome>Botricello</nome><codice>B085</codice></comune>
<comune><nome>Botrugno</nome><codice>B086</codice></comune>
<comune><nome>Bottanuco</nome><codice>B088</codice></comune>
<comune><nome>Botticino</nome><codice>B091</codice></comune>
<comune><nome>Bottidda</nome><codice>B094</codice></comune>
<comune><nome>Bova</nome><codice>B097</codice></comune>
<comune><nome>Bova Marina</nome><codice>B099</codice></comune>
<comune><nome>Bovalino</nome><codice>B098</codice></comune>
<comune><nome>Bovegno</nome><codice>B100</codice></comune>
<comune><nome>Boves</nome><codice>B101</codice></comune>
<comune><nome>Bovezzo</nome><codice>B102</codice></comune>
<comune><nome>Boville Ernica</nome><codice>A720</codice></comune>
<comune><nome>Bovino</nome><codice>B104</codice></comune>
<comune><nome>Bovisio-Masciago</nome><codice>B105</codice></comune>
<comune><nome>Bovolenta</nome><codice>B106</codice></comune>
<comune><nome>Bovolone</nome><codice>B107</codice></comune>
<comune><nome>Bozzole</nome><codice>B109</codice></comune>
<comune><nome>Bozzolo</nome><codice>B110</codice></comune>
<comune><nome>Bra</nome><codice>B111</codice></comune>
<comune><nome>Bracca</nome><codice>B112</codice></comune>
<comune><nome>Bracciano</nome><codice>B114</codice></comune>
<comune><nome>Bracigliano</nome><codice>B115</codice></comune>
<comune><nome>Braies</nome><codice>B116</codice></comune>
<comune><nome>Brallo di Pregola</nome><codice>B117</codice></comune>
<comune><nome>Brancaleone</nome><codice>B118</codice></comune>
<comune><nome>Brandico</nome><codice>B120</codice></comune>
<comune><nome>Brandizzo</nome><codice>B121</codice></comune>
<comune><nome>Branzi</nome><codice>B123</codice></comune>
<comune><nome>Braone</nome><codice>B124</codice></comune>
<comune><nome>Brebbia</nome><codice>B126</codice></comune>
<comune><nome>Breda di Piave</nome><codice>B128</codice></comune>
<comune><nome>Bregano</nome><codice>B131</codice></comune>
<comune><nome>Breganze</nome><codice>B132</codice></comune>
<comune><nome>Bregnano</nome><codice>B134</codice></comune>
<comune><nome>Breguzzo</nome><codice>B135</codice></comune>
<comune><nome>Breia</nome><codice>B136</codice></comune>
<comune><nome>Brembate</nome><codice>B137</codice></comune>
<comune><nome>Brembate di Sopra</nome><codice>B138</codice></comune>
<comune><nome>Brembilla</nome><codice>B140</codice></comune>
<comune><nome>Brembio</nome><codice>B141</codice></comune>
<comune><nome>Breme</nome><codice>B142</codice></comune>
<comune><nome>Brendola</nome><codice>B143</codice></comune>
<comune><nome>Brenna</nome><codice>B144</codice></comune>
<comune><nome>Brennero</nome><codice>B145</codice></comune>
<comune><nome>Breno</nome><codice>B149</codice></comune>
<comune><nome>Brenta</nome><codice>B150</codice></comune>
<comune><nome>Brentino Belluno</nome><codice>B152</codice></comune>
<comune><nome>Brentonico</nome><codice>B153</codice></comune>
<comune><nome>Brenzone</nome><codice>B154</codice></comune>
<comune><nome>Brescello</nome><codice>B156</codice></comune>
<comune><nome>Brescia</nome><codice>B157</codice></comune>
<comune><nome>Bresimo</nome><codice>B158</codice></comune>
<comune><nome>Bressana Bottarone</nome><codice>B159</codice></comune>
<comune><nome>Bressanone</nome><codice>B160</codice></comune>
<comune><nome>Bressanvido</nome><codice>B161</codice></comune>
<comune><nome>Bresso</nome><codice>B162</codice></comune>
<comune><nome>Brez</nome><codice>B165</codice></comune>
<comune><nome>Brezzo di Bedero</nome><codice>B166</codice></comune>
<comune><nome>Briaglia</nome><codice>B167</codice></comune>
<comune><nome>Briatico</nome><codice>B169</codice></comune>
<comune><nome>Bricherasio</nome><codice>B171</codice></comune>
<comune><nome>Brienno</nome><codice>B172</codice></comune>
<comune><nome>Brienza</nome><codice>B173</codice></comune>
<comune><nome>Briga Alta</nome><codice>B175</codice></comune>
<comune><nome>Briga Novarese</nome><codice>B176</codice></comune>
<comune><nome>Brignano Gera d'Adda</nome><codice>B178</codice></comune>
<comune><nome>Brignano-Frascata</nome><codice>B179</codice></comune>
<comune><nome>Brindisi</nome><codice>B180</codice></comune>
<comune><nome>Brindisi Montagna</nome><codice>B181</codice></comune>
<comune><nome>Brinzio</nome><codice>B182</codice></comune>
<comune><nome>Briona</nome><codice>B183</codice></comune>
<comune><nome>Brione</nome><codice>B184</codice></comune>
<comune><nome>Brione</nome><codice>B185</codice></comune>
<comune><nome>Briosco</nome><codice>B187</codice></comune>
<comune><nome>Brisighella</nome><codice>B188</codice></comune>
<comune><nome>Brissago-Valtravaglia</nome><codice>B191</codice></comune>
<comune><nome>Brissogne</nome><codice>B192</codice></comune>
<comune><nome>Brittoli</nome><codice>B193</codice></comune>
<comune><nome>Brivio</nome><codice>B194</codice></comune>
<comune><nome>Broccostella</nome><codice>B195</codice></comune>
<comune><nome>Brogliano</nome><codice>B196</codice></comune>
<comune><nome>Brognaturo</nome><codice>B197</codice></comune>
<comune><nome>Brolo</nome><codice>B198</codice></comune>
<comune><nome>Brondello</nome><codice>B200</codice></comune>
<comune><nome>Broni</nome><codice>B201</codice></comune>
<comune><nome>Bronte</nome><codice>B202</codice></comune>
<comune><nome>Bronzolo</nome><codice>B203</codice></comune>
<comune><nome>Brossasco</nome><codice>B204</codice></comune>
<comune><nome>Brosso</nome><codice>B205</codice></comune>
<comune><nome>Brovello-Carpugnino</nome><codice>B207</codice></comune>
<comune><nome>Brozolo</nome><codice>B209</codice></comune>
<comune><nome>Brugherio</nome><codice>B212</codice></comune>
<comune><nome>Brugine</nome><codice>B213</codice></comune>
<comune><nome>Brugnato</nome><codice>B214</codice></comune>
<comune><nome>Brugnera</nome><codice>B215</codice></comune>
<comune><nome>Bruino</nome><codice>B216</codice></comune>
<comune><nome>Brumano</nome><codice>B217</codice></comune>
<comune><nome>Brunate</nome><codice>B218</codice></comune>
<comune><nome>Brunello</nome><codice>B219</codice></comune>
<comune><nome>Brunico</nome><codice>B220</codice></comune>
<comune><nome>Bruno</nome><codice>B221</codice></comune>
<comune><nome>Brusaporto</nome><codice>B223</codice></comune>
<comune><nome>Brusasco</nome><codice>B225</codice></comune>
<comune><nome>Brusciano</nome><codice>B227</codice></comune>
<comune><nome>Brusimpiano</nome><codice>B228</codice></comune>
<comune><nome>Brusnengo</nome><codice>B229</codice></comune>
<comune><nome>Brusson</nome><codice>B230</codice></comune>
<comune><nome>Bruzolo</nome><codice>B232</codice></comune>
<comune><nome>Bruzzano Zeffirio</nome><codice>B234</codice></comune>
<comune><nome>Bubbiano</nome><codice>B235</codice></comune>
<comune><nome>Bubbio</nome><codice>B236</codice></comune>
<comune><nome>Buccheri</nome><codice>B237</codice></comune>
<comune><nome>Bucchianico</nome><codice>B238</codice></comune>
<comune><nome>Bucciano</nome><codice>B239</codice></comune>
<comune><nome>Buccinasco</nome><codice>B240</codice></comune>
<comune><nome>Buccino</nome><codice>B242</codice></comune>
<comune><nome>Bucine</nome><codice>B243</codice></comune>
<comune><nome>Buddusò</nome><codice>B246</codice></comune>
<comune><nome>Budoia</nome><codice>B247</codice></comune>
<comune><nome>Budoni</nome><codice>B248</codice></comune>
<comune><nome>Budrio</nome><codice>B249</codice></comune>
<comune><nome>Buggerru</nome><codice>B250</codice></comune>
<comune><nome>Buggiano</nome><codice>B251</codice></comune>
<comune><nome>Buglio in Monte</nome><codice>B255</codice></comune>
<comune><nome>Bugnara</nome><codice>B256</codice></comune>
<comune><nome>Buguggiate</nome><codice>B258</codice></comune>
<comune><nome>Buja</nome><codice>B259</codice></comune>
<comune><nome>Bulciago</nome><codice>B261</codice></comune>
<comune><nome>Bulgarograsso</nome><codice>B262</codice></comune>
<comune><nome>Bultei</nome><codice>B264</codice></comune>
<comune><nome>Bulzi</nome><codice>B265</codice></comune>
<comune><nome>Buonabitacolo</nome><codice>B266</codice></comune>
<comune><nome>Buonalbergo</nome><codice>B267</codice></comune>
<comune><nome>Buonconvento</nome><codice>B269</codice></comune>
<comune><nome>Buonvicino</nome><codice>B270</codice></comune>
<comune><nome>Burago di Molgora</nome><codice>B272</codice></comune>
<comune><nome>Burcei</nome><codice>B274</codice></comune>
<comune><nome>Burgio</nome><codice>B275</codice></comune>
<comune><nome>Burgos</nome><codice>B276</codice></comune>
<comune><nome>Buriasco</nome><codice>B278</codice></comune>
<comune><nome>Burolo</nome><codice>B279</codice></comune>
<comune><nome>Buronzo</nome><codice>B280</codice></comune>
<comune><nome>Busachi</nome><codice>B281</codice></comune>
<comune><nome>Busalla</nome><codice>B282</codice></comune>
<comune><nome>Busana</nome><codice>B283</codice></comune>
<comune><nome>Busano</nome><codice>B284</codice></comune>
<comune><nome>Busca</nome><codice>B285</codice></comune>
<comune><nome>Buscate</nome><codice>B286</codice></comune>
<comune><nome>Buscemi</nome><codice>B287</codice></comune>
<comune><nome>Buseto Palizzolo</nome><codice>B288</codice></comune>
<comune><nome>Busnago</nome><codice>B289</codice></comune>
<comune><nome>Bussero</nome><codice>B292</codice></comune>
<comune><nome>Busseto</nome><codice>B293</codice></comune>
<comune><nome>Bussi sul Tirino</nome><codice>B294</codice></comune>
<comune><nome>Busso</nome><codice>B295</codice></comune>
<comune><nome>Bussolengo</nome><codice>B296</codice></comune>
<comune><nome>Bussoleno</nome><codice>B297</codice></comune>
<comune><nome>Busto Arsizio</nome><codice>B300</codice></comune>
<comune><nome>Busto Garolfo</nome><codice>B301</codice></comune>
<comune><nome>Butera</nome><codice>B302</codice></comune>
<comune><nome>Buti</nome><codice>B303</codice></comune>
<comune><nome>Buttapietra</nome><codice>B304</codice></comune>
<comune><nome>Buttigliera Alta</nome><codice>B305</codice></comune>
<comune><nome>Buttigliera d'Asti</nome><codice>B306</codice></comune>
<comune><nome>Buttrio</nome><codice>B309</codice></comune>
<comune><nome>Ca' d'Andrea</nome><codice>B320</codice></comune>
<comune><nome>Cabella Ligure</nome><codice>B311</codice></comune>
<comune><nome>Cabiate</nome><codice>B313</codice></comune>
<comune><nome>Cabras</nome><codice>B314</codice></comune>
<comune><nome>Caccamo</nome><codice>B315</codice></comune>
<comune><nome>Caccuri</nome><codice>B319</codice></comune>
<comune><nome>Cadegliano-Viconago</nome><codice>B326</codice></comune>
<comune><nome>Cadelbosco di Sopra</nome><codice>B328</codice></comune>
<comune><nome>Cadeo</nome><codice>B332</codice></comune>
<comune><nome>Caderzone Terme</nome><codice>B335</codice></comune>
<comune><nome>Cadoneghe</nome><codice>B345</codice></comune>
<comune><nome>Cadorago</nome><codice>B346</codice></comune>
<comune><nome>Cadrezzate</nome><codice>B347</codice></comune>
<comune><nome>Caerano di San Marco</nome><codice>B349</codice></comune>
<comune><nome>Cafasse</nome><codice>B350</codice></comune>
<comune><nome>Caggiano</nome><codice>B351</codice></comune>
<comune><nome>Cagli</nome><codice>B352</codice></comune>
<comune><nome>Cagliari</nome><codice>B354</codice></comune>
<comune><nome>Caglio</nome><codice>B355</codice></comune>
<comune><nome>Cagnano Amiterno</nome><codice>B358</codice></comune>
<comune><nome>Cagnano Varano</nome><codice>B357</codice></comune>
<comune><nome>Cagno</nome><codice>B359</codice></comune>
<comune><nome>Cagnò</nome><codice>B360</codice></comune>
<comune><nome>Caianello</nome><codice>B361</codice></comune>
<comune><nome>Caiazzo</nome><codice>B362</codice></comune>
<comune><nome>Caines</nome><codice>B364</codice></comune>
<comune><nome>Caino</nome><codice>B365</codice></comune>
<comune><nome>Caiolo</nome><codice>B366</codice></comune>
<comune><nome>Cairano</nome><codice>B367</codice></comune>
<comune><nome>Cairate</nome><codice>B368</codice></comune>
<comune><nome>Cairo Montenotte</nome><codice>B369</codice></comune>
<comune><nome>Caivano</nome><codice>B371</codice></comune>
<comune><nome>Calabritto</nome><codice>B374</codice></comune>
<comune><nome>Calalzo di Cadore</nome><codice>B375</codice></comune>
<comune><nome>Calamandrana</nome><codice>B376</codice></comune>
<comune><nome>Calamonaci</nome><codice>B377</codice></comune>
<comune><nome>Calangianus</nome><codice>B378</codice></comune>
<comune><nome>Calanna</nome><codice>B379</codice></comune>
<comune><nome>Calasca-Castiglione</nome><codice>B380</codice></comune>
<comune><nome>Calascibetta</nome><codice>B381</codice></comune>
<comune><nome>Calascio</nome><codice>B382</codice></comune>
<comune><nome>Calasetta</nome><codice>B383</codice></comune>
<comune><nome>Calatabiano</nome><codice>B384</codice></comune>
<comune><nome>Calatafimi Segesta</nome><codice>B385</codice></comune>
<comune><nome>Calavino</nome><codice>B386</codice></comune>
<comune><nome>Calcata</nome><codice>B388</codice></comune>
<comune><nome>Calceranica al Lago</nome><codice>B389</codice></comune>
<comune><nome>Calci</nome><codice>B390</codice></comune>
<comune><nome>Calciano</nome><codice>B391</codice></comune>
<comune><nome>Calcinaia</nome><codice>B392</codice></comune>
<comune><nome>Calcinate</nome><codice>B393</codice></comune>
<comune><nome>Calcinato</nome><codice>B394</codice></comune>
<comune><nome>Calcio</nome><codice>B395</codice></comune>
<comune><nome>Calco</nome><codice>B396</codice></comune>
<comune><nome>Caldaro sulla Strada del Vino</nome><codice>B397</codice></comune>
<comune><nome>Caldarola</nome><codice>B398</codice></comune>
<comune><nome>Calderara di Reno</nome><codice>B399</codice></comune>
<comune><nome>Caldes</nome><codice>B400</codice></comune>
<comune><nome>Caldiero</nome><codice>B402</codice></comune>
<comune><nome>Caldogno</nome><codice>B403</codice></comune>
<comune><nome>Caldonazzo</nome><codice>B404</codice></comune>
<comune><nome>Calendasco</nome><codice>B405</codice></comune>
<comune><nome>Calenzano</nome><codice>B406</codice></comune>
<comune><nome>Calestano</nome><codice>B408</codice></comune>
<comune><nome>Calice al Cornoviglio</nome><codice>B410</codice></comune>
<comune><nome>Calice Ligure</nome><codice>B409</codice></comune>
<comune><nome>Calimera</nome><codice>B413</codice></comune>
<comune><nome>Calitri</nome><codice>B415</codice></comune>
<comune><nome>Calizzano</nome><codice>B416</codice></comune>
<comune><nome>Callabiana</nome><codice>B417</codice></comune>
<comune><nome>Calliano</nome><codice>B418</codice></comune>
<comune><nome>Calliano</nome><codice>B419</codice></comune>
<comune><nome>Calolziocorte</nome><codice>B423</codice></comune>
<comune><nome>Calopezzati</nome><codice>B424</codice></comune>
<comune><nome>Calosso</nome><codice>B425</codice></comune>
<comune><nome>Caloveto</nome><codice>B426</codice></comune>
<comune><nome>Caltabellotta</nome><codice>B427</codice></comune>
<comune><nome>Caltagirone</nome><codice>B428</codice></comune>
<comune><nome>Caltanissetta</nome><codice>B429</codice></comune>
<comune><nome>Caltavuturo</nome><codice>B430</codice></comune>
<comune><nome>Caltignaga</nome><codice>B431</codice></comune>
<comune><nome>Calto</nome><codice>B432</codice></comune>
<comune><nome>Caltrano</nome><codice>B433</codice></comune>
<comune><nome>Calusco d'Adda</nome><codice>B434</codice></comune>
<comune><nome>Caluso</nome><codice>B435</codice></comune>
<comune><nome>Calvagese della Riviera</nome><codice>B436</codice></comune>
<comune><nome>Calvanico</nome><codice>B437</codice></comune>
<comune><nome>Calvatone</nome><codice>B439</codice></comune>
<comune><nome>Calvello</nome><codice>B440</codice></comune>
<comune><nome>Calvene</nome><codice>B441</codice></comune>
<comune><nome>Calvenzano</nome><codice>B442</codice></comune>
<comune><nome>Calvera</nome><codice>B443</codice></comune>
<comune><nome>Calvi</nome><codice>B444</codice></comune>
<comune><nome>Calvi dell'Umbria</nome><codice>B446</codice></comune>
<comune><nome>Calvi Risorta</nome><codice>B445</codice></comune>
<comune><nome>Calvignano</nome><codice>B447</codice></comune>
<comune><nome>Calvignasco</nome><codice>B448</codice></comune>
<comune><nome>Calvisano</nome><codice>B450</codice></comune>
<comune><nome>Calvizzano</nome><codice>B452</codice></comune>
<comune><nome>Camagna Monferrato</nome><codice>B453</codice></comune>
<comune><nome>Camaiore</nome><codice>B455</codice></comune>
<comune><nome>Camairago</nome><codice>B456</codice></comune>
<comune><nome>Camandona</nome><codice>B457</codice></comune>
<comune><nome>Camastra</nome><codice>B460</codice></comune>
<comune><nome>Cambiago</nome><codice>B461</codice></comune>
<comune><nome>Cambiano</nome><codice>B462</codice></comune>
<comune><nome>Cambiasca</nome><codice>B463</codice></comune>
<comune><nome>Camburzano</nome><codice>B465</codice></comune>
<comune><nome>Camerana</nome><codice>B467</codice></comune>
<comune><nome>Camerano</nome><codice>B468</codice></comune>
<comune><nome>Camerano Casasco</nome><codice>B469</codice></comune>
<comune><nome>Camerata Cornello</nome><codice>B471</codice></comune>
<comune><nome>Camerata Nuova</nome><codice>B472</codice></comune>
<comune><nome>Camerata Picena</nome><codice>B470</codice></comune>
<comune><nome>Cameri</nome><codice>B473</codice></comune>
<comune><nome>Camerino</nome><codice>B474</codice></comune>
<comune><nome>Camerota</nome><codice>B476</codice></comune>
<comune><nome>Camigliano</nome><codice>B477</codice></comune>
<comune><nome>Caminata</nome><codice>B479</codice></comune>
<comune><nome>Camini</nome><codice>B481</codice></comune>
<comune><nome>Camino</nome><codice>B482</codice></comune>
<comune><nome>Camino al Tagliamento</nome><codice>B483</codice></comune>
<comune><nome>Camisano</nome><codice>B484</codice></comune>
<comune><nome>Camisano Vicentino</nome><codice>B485</codice></comune>
<comune><nome>Cammarata</nome><codice>B486</codice></comune>
<comune><nome>Camo</nome><codice>B489</codice></comune>
<comune><nome>Camogli</nome><codice>B490</codice></comune>
<comune><nome>Campagna</nome><codice>B492</codice></comune>
<comune><nome>Campagna Lupia</nome><codice>B493</codice></comune>
<comune><nome>Campagnano di Roma</nome><codice>B496</codice></comune>
<comune><nome>Campagnatico</nome><codice>B497</codice></comune>
<comune><nome>Campagnola Cremasca</nome><codice>B498</codice></comune>
<comune><nome>Campagnola Emilia</nome><codice>B499</codice></comune>
<comune><nome>Campana</nome><codice>B500</codice></comune>
<comune><nome>Camparada</nome><codice>B501</codice></comune>
<comune><nome>Campegine</nome><codice>B502</codice></comune>
<comune><nome>Campello sul Clitunno</nome><codice>B504</codice></comune>
<comune><nome>Campertogno</nome><codice>B505</codice></comune>
<comune><nome>Campi Bisenzio</nome><codice>B507</codice></comune>
<comune><nome>Campi Salentina</nome><codice>B506</codice></comune>
<comune><nome>Campiglia Cervo</nome><codice>B508</codice></comune>
<comune><nome>Campiglia dei Berici</nome><codice>B511</codice></comune>
<comune><nome>Campiglia Marittima</nome><codice>B509</codice></comune>
<comune><nome>Campiglione-Fenile</nome><codice>B512</codice></comune>
<comune><nome>Campione d'Italia</nome><codice>B513</codice></comune>
<comune><nome>Campitello di Fassa</nome><codice>B514</codice></comune>
<comune><nome>Campli</nome><codice>B515</codice></comune>
<comune><nome>Campo Calabro</nome><codice>B516</codice></comune>
<comune><nome>Campo di Giove</nome><codice>B526</codice></comune>
<comune><nome>Campo di Trens</nome><codice>B529</codice></comune>
<comune><nome>Campo Ligure</nome><codice>B538</codice></comune>
<comune><nome>Campo nell'Elba</nome><codice>B553</codice></comune>
<comune><nome>Campo San Martino</nome><codice>B564</codice></comune>
<comune><nome>Campo Tures</nome><codice>B570</codice></comune>
<comune><nome>Campobasso</nome><codice>B519</codice></comune>
<comune><nome>Campobello di Licata</nome><codice>B520</codice></comune>
<comune><nome>Campobello di Mazara</nome><codice>B521</codice></comune>
<comune><nome>Campochiaro</nome><codice>B522</codice></comune>
<comune><nome>Campodarsego</nome><codice>B524</codice></comune>
<comune><nome>Campodenno</nome><codice>B525</codice></comune>
<comune><nome>Campodimele</nome><codice>B527</codice></comune>
<comune><nome>Campodipietra</nome><codice>B528</codice></comune>
<comune><nome>Campodolcino</nome><codice>B530</codice></comune>
<comune><nome>Campodoro</nome><codice>B531</codice></comune>
<comune><nome>Campofelice di Fitalia</nome><codice>B533</codice></comune>
<comune><nome>Campofelice di Roccella</nome><codice>B532</codice></comune>
<comune><nome>Campofilone</nome><codice>B534</codice></comune>
<comune><nome>Campofiorito</nome><codice>B535</codice></comune>
<comune><nome>Campoformido</nome><codice>B536</codice></comune>
<comune><nome>Campofranco</nome><codice>B537</codice></comune>
<comune><nome>Campogalliano</nome><codice>B539</codice></comune>
<comune><nome>Campolattaro</nome><codice>B541</codice></comune>
<comune><nome>Campoli Appennino</nome><codice>B543</codice></comune>
<comune><nome>Campoli del Monte Taburno</nome><codice>B542</codice></comune>
<comune><nome>Campolieto</nome><codice>B544</codice></comune>
<comune><nome>Campolongo Maggiore</nome><codice>B546</codice></comune>
<comune><nome>Campolongo sul Brenta</nome><codice>B547</codice></comune>
<comune><nome>Campolongo Tapogliano</nome><codice>M311</codice></comune>
<comune><nome>Campomaggiore</nome><codice>B549</codice></comune>
<comune><nome>Campomarino</nome><codice>B550</codice></comune>
<comune><nome>Campomorone</nome><codice>B551</codice></comune>
<comune><nome>Camponogara</nome><codice>B554</codice></comune>
<comune><nome>Campora</nome><codice>B555</codice></comune>
<comune><nome>Camporeale</nome><codice>B556</codice></comune>
<comune><nome>Camporgiano</nome><codice>B557</codice></comune>
<comune><nome>Camporosso</nome><codice>B559</codice></comune>
<comune><nome>Camporotondo di Fiastrone</nome><codice>B562</codice></comune>
<comune><nome>Camporotondo Etneo</nome><codice>B561</codice></comune>
<comune><nome>Camposampiero</nome><codice>B563</codice></comune>
<comune><nome>Camposano</nome><codice>B565</codice></comune>
<comune><nome>Camposanto</nome><codice>B566</codice></comune>
<comune><nome>Campospinoso</nome><codice>B567</codice></comune>
<comune><nome>Campotosto</nome><codice>B569</codice></comune>
<comune><nome>Camugnano</nome><codice>B572</codice></comune>
<comune><nome>Canal San Bovo</nome><codice>B577</codice></comune>
<comune><nome>Canale</nome><codice>B573</codice></comune>
<comune><nome>Canale d'Agordo</nome><codice>B574</codice></comune>
<comune><nome>Canale Monterano</nome><codice>B576</codice></comune>
<comune><nome>Canaro</nome><codice>B578</codice></comune>
<comune><nome>Canazei</nome><codice>B579</codice></comune>
<comune><nome>Cancellara</nome><codice>B580</codice></comune>
<comune><nome>Cancello ed Arnone</nome><codice>B581</codice></comune>
<comune><nome>Canda</nome><codice>B582</codice></comune>
<comune><nome>Candela</nome><codice>B584</codice></comune>
<comune><nome>Candelo</nome><codice>B586</codice></comune>
<comune><nome>Candia Canavese</nome><codice>B588</codice></comune>
<comune><nome>Candia Lomellina</nome><codice>B587</codice></comune>
<comune><nome>Candiana</nome><codice>B589</codice></comune>
<comune><nome>Candida</nome><codice>B590</codice></comune>
<comune><nome>Candidoni</nome><codice>B591</codice></comune>
<comune><nome>Candiolo</nome><codice>B592</codice></comune>
<comune><nome>Canegrate</nome><codice>B593</codice></comune>
<comune><nome>Canelli</nome><codice>B594</codice></comune>
<comune><nome>Canepina</nome><codice>B597</codice></comune>
<comune><nome>Caneva</nome><codice>B598</codice></comune>
<comune><nome>Canevino</nome><codice>B599</codice></comune>
<comune><nome>Canicattì</nome><codice>B602</codice></comune>
<comune><nome>Canicattini Bagni</nome><codice>B603</codice></comune>
<comune><nome>Canino</nome><codice>B604</codice></comune>
<comune><nome>Canischio</nome><codice>B605</codice></comune>
<comune><nome>Canistro</nome><codice>B606</codice></comune>
<comune><nome>Canna</nome><codice>B607</codice></comune>
<comune><nome>Cannalonga</nome><codice>B608</codice></comune>
<comune><nome>Cannara</nome><codice>B609</codice></comune>
<comune><nome>Cannero Riviera</nome><codice>B610</codice></comune>
<comune><nome>Canneto Pavese</nome><codice>B613</codice></comune>
<comune><nome>Canneto sull'Oglio</nome><codice>B612</codice></comune>
<comune><nome>Cannobio</nome><codice>B615</codice></comune>
<comune><nome>Cannole</nome><codice>B616</codice></comune>
<comune><nome>Canolo</nome><codice>B617</codice></comune>
<comune><nome>Canonica d'Adda</nome><codice>B618</codice></comune>
<comune><nome>Canosa di Puglia</nome><codice>B619</codice></comune>
<comune><nome>Canosa Sannita</nome><codice>B620</codice></comune>
<comune><nome>Canosio</nome><codice>B621</codice></comune>
<comune><nome>Canossa</nome><codice>C669</codice></comune>
<comune><nome>Cansano</nome><codice>B624</codice></comune>
<comune><nome>Cantagallo</nome><codice>B626</codice></comune>
<comune><nome>Cantalice</nome><codice>B627</codice></comune>
<comune><nome>Cantalupa</nome><codice>B628</codice></comune>
<comune><nome>Cantalupo in Sabina</nome><codice>B631</codice></comune>
<comune><nome>Cantalupo Ligure</nome><codice>B629</codice></comune>
<comune><nome>Cantalupo nel Sannio</nome><codice>B630</codice></comune>
<comune><nome>Cantarana</nome><codice>B633</codice></comune>
<comune><nome>Cantello</nome><codice>B634</codice></comune>
<comune><nome>Canterano</nome><codice>B635</codice></comune>
<comune><nome>Cantiano</nome><codice>B636</codice></comune>
<comune><nome>Cantoira</nome><codice>B637</codice></comune>
<comune><nome>Cantù</nome><codice>B639</codice></comune>
<comune><nome>Canzano</nome><codice>B640</codice></comune>
<comune><nome>Canzo</nome><codice>B641</codice></comune>
<comune><nome>Caorle</nome><codice>B642</codice></comune>
<comune><nome>Caorso</nome><codice>B643</codice></comune>
<comune><nome>Capaccio</nome><codice>B644</codice></comune>
<comune><nome>Capaci</nome><codice>B645</codice></comune>
<comune><nome>Capalbio</nome><codice>B646</codice></comune>
<comune><nome>Capannoli</nome><codice>B647</codice></comune>
<comune><nome>Capannori</nome><codice>B648</codice></comune>
<comune><nome>Capena</nome><codice>B649</codice></comune>
<comune><nome>Capergnanica</nome><codice>B650</codice></comune>
<comune><nome>Capestrano</nome><codice>B651</codice></comune>
<comune><nome>Capiago Intimiano</nome><codice>B653</codice></comune>
<comune><nome>Capistrano</nome><codice>B655</codice></comune>
<comune><nome>Capistrello</nome><codice>B656</codice></comune>
<comune><nome>Capitignano</nome><codice>B658</codice></comune>
<comune><nome>Capizzi</nome><codice>B660</codice></comune>
<comune><nome>Capizzone</nome><codice>B661</codice></comune>
<comune><nome>Capo di Ponte</nome><codice>B664</codice></comune>
<comune><nome>Capo d'Orlando</nome><codice>B666</codice></comune>
<comune><nome>Capodimonte</nome><codice>B663</codice></comune>
<comune><nome>Capodrise</nome><codice>B667</codice></comune>
<comune><nome>Capoliveri</nome><codice>B669</codice></comune>
<comune><nome>Capolona</nome><codice>B670</codice></comune>
<comune><nome>Caponago</nome><codice>B671</codice></comune>
<comune><nome>Caporciano</nome><codice>B672</codice></comune>
<comune><nome>Caposele</nome><codice>B674</codice></comune>
<comune><nome>Capoterra</nome><codice>B675</codice></comune>
<comune><nome>Capovalle</nome><codice>B676</codice></comune>
<comune><nome>Cappadocia</nome><codice>B677</codice></comune>
<comune><nome>Cappella Cantone</nome><codice>B679</codice></comune>
<comune><nome>Cappella de' Picenardi</nome><codice>B680</codice></comune>
<comune><nome>Cappella Maggiore</nome><codice>B678</codice></comune>
<comune><nome>Cappelle sul Tavo</nome><codice>B681</codice></comune>
<comune><nome>Capracotta</nome><codice>B682</codice></comune>
<comune><nome>Capraia e Limite</nome><codice>B684</codice></comune>
<comune><nome>Capraia Isola</nome><codice>B685</codice></comune>
<comune><nome>Capralba</nome><codice>B686</codice></comune>
<comune><nome>Capranica</nome><codice>B688</codice></comune>
<comune><nome>Capranica Prenestina</nome><codice>B687</codice></comune>
<comune><nome>Caprarica di Lecce</nome><codice>B690</codice></comune>
<comune><nome>Caprarola</nome><codice>B691</codice></comune>
<comune><nome>Caprauna</nome><codice>B692</codice></comune>
<comune><nome>Caprese Michelangelo</nome><codice>B693</codice></comune>
<comune><nome>Caprezzo</nome><codice>B694</codice></comune>
<comune><nome>Capri</nome><codice>B696</codice></comune>
<comune><nome>Capri Leone</nome><codice>B695</codice></comune>
<comune><nome>Capriana</nome><codice>B697</codice></comune>
<comune><nome>Capriano del Colle</nome><codice>B698</codice></comune>
<comune><nome>Capriata d'Orba</nome><codice>B701</codice></comune>
<comune><nome>Capriate San Gervasio</nome><codice>B703</codice></comune>
<comune><nome>Capriati a Volturno</nome><codice>B704</codice></comune>
<comune><nome>Caprie</nome><codice>B705</codice></comune>
<comune><nome>Capriglia Irpina</nome><codice>B706</codice></comune>
<comune><nome>Capriglio</nome><codice>B707</codice></comune>
<comune><nome>Caprile</nome><codice>B708</codice></comune>
<comune><nome>Caprino Bergamasco</nome><codice>B710</codice></comune>
<comune><nome>Caprino Veronese</nome><codice>B709</codice></comune>
<comune><nome>Capriolo</nome><codice>B711</codice></comune>
<comune><nome>Capriva del Friuli</nome><codice>B712</codice></comune>
<comune><nome>Capua</nome><codice>B715</codice></comune>
<comune><nome>Capurso</nome><codice>B716</codice></comune>
<comune><nome>Caraffa del Bianco</nome><codice>B718</codice></comune>
<comune><nome>Caraffa di Catanzaro</nome><codice>B717</codice></comune>
<comune><nome>Caraglio</nome><codice>B719</codice></comune>
<comune><nome>Caramagna Piemonte</nome><codice>B720</codice></comune>
<comune><nome>Caramanico Terme</nome><codice>B722</codice></comune>
<comune><nome>Carano</nome><codice>B723</codice></comune>
<comune><nome>Carapelle</nome><codice>B724</codice></comune>
<comune><nome>Carapelle Calvisio</nome><codice>B725</codice></comune>
<comune><nome>Carasco</nome><codice>B726</codice></comune>
<comune><nome>Carassai</nome><codice>B727</codice></comune>
<comune><nome>Carate Brianza</nome><codice>B729</codice></comune>
<comune><nome>Carate Urio</nome><codice>B730</codice></comune>
<comune><nome>Caravaggio</nome><codice>B731</codice></comune>
<comune><nome>Caravate</nome><codice>B732</codice></comune>
<comune><nome>Caravino</nome><codice>B733</codice></comune>
<comune><nome>Caravonica</nome><codice>B734</codice></comune>
<comune><nome>Carbognano</nome><codice>B735</codice></comune>
<comune><nome>Carbonara al Ticino</nome><codice>B741</codice></comune>
<comune><nome>Carbonara di Nola</nome><codice>B740</codice></comune>
<comune><nome>Carbonara di Po</nome><codice>B739</codice></comune>
<comune><nome>Carbonara Scrivia</nome><codice>B736</codice></comune>
<comune><nome>Carbonate</nome><codice>B742</codice></comune>
<comune><nome>Carbone</nome><codice>B743</codice></comune>
<comune><nome>Carbonera</nome><codice>B744</codice></comune>
<comune><nome>Carbonia</nome><codice>B745</codice></comune>
<comune><nome>Carcare</nome><codice>B748</codice></comune>
<comune><nome>Carceri</nome><codice>B749</codice></comune>
<comune><nome>Carcoforo</nome><codice>B752</codice></comune>
<comune><nome>Cardano al Campo</nome><codice>B754</codice></comune>
<comune><nome>Cardè</nome><codice>B755</codice></comune>
<comune><nome>Cardedu</nome><codice>M285</codice></comune>
<comune><nome>Cardeto</nome><codice>B756</codice></comune>
<comune><nome>Cardinale</nome><codice>B758</codice></comune>
<comune><nome>Cardito</nome><codice>B759</codice></comune>
<comune><nome>Careggine</nome><codice>B760</codice></comune>
<comune><nome>Carema</nome><codice>B762</codice></comune>
<comune><nome>Carenno</nome><codice>B763</codice></comune>
<comune><nome>Carentino</nome><codice>B765</codice></comune>
<comune><nome>Careri</nome><codice>B766</codice></comune>
<comune><nome>Caresana</nome><codice>B767</codice></comune>
<comune><nome>Caresanablot</nome><codice>B768</codice></comune>
<comune><nome>Carezzano</nome><codice>B769</codice></comune>
<comune><nome>Carfizzi</nome><codice>B771</codice></comune>
<comune><nome>Cargeghe</nome><codice>B772</codice></comune>
<comune><nome>Cariati</nome><codice>B774</codice></comune>
<comune><nome>Carife</nome><codice>B776</codice></comune>
<comune><nome>Carignano</nome><codice>B777</codice></comune>
<comune><nome>Carimate</nome><codice>B778</codice></comune>
<comune><nome>Carinaro</nome><codice>B779</codice></comune>
<comune><nome>Carini</nome><codice>B780</codice></comune>
<comune><nome>Carinola</nome><codice>B781</codice></comune>
<comune><nome>Carisio</nome><codice>B782</codice></comune>
<comune><nome>Carisolo</nome><codice>B783</codice></comune>
<comune><nome>Carlantino</nome><codice>B784</codice></comune>
<comune><nome>Carlazzo</nome><codice>B785</codice></comune>
<comune><nome>Carlentini</nome><codice>B787</codice></comune>
<comune><nome>Carlino</nome><codice>B788</codice></comune>
<comune><nome>Carloforte</nome><codice>B789</codice></comune>
<comune><nome>Carlopoli</nome><codice>B790</codice></comune>
<comune><nome>Carmagnola</nome><codice>B791</codice></comune>
<comune><nome>Carmiano</nome><codice>B792</codice></comune>
<comune><nome>Carmignano</nome><codice>B794</codice></comune>
<comune><nome>Carmignano di Brenta</nome><codice>B795</codice></comune>
<comune><nome>Carnago</nome><codice>B796</codice></comune>
<comune><nome>Carnate</nome><codice>B798</codice></comune>
<comune><nome>Carobbio degli Angeli</nome><codice>B801</codice></comune>
<comune><nome>Carolei</nome><codice>B802</codice></comune>
<comune><nome>Carona</nome><codice>B803</codice></comune>
<comune><nome>Caronia</nome><codice>B804</codice></comune>
<comune><nome>Caronno Pertusella</nome><codice>B805</codice></comune>
<comune><nome>Caronno Varesino</nome><codice>B807</codice></comune>
<comune><nome>Carosino</nome><codice>B808</codice></comune>
<comune><nome>Carovigno</nome><codice>B809</codice></comune>
<comune><nome>Carovilli</nome><codice>B810</codice></comune>
<comune><nome>Carpaneto Piacentino</nome><codice>B812</codice></comune>
<comune><nome>Carpanzano</nome><codice>B813</codice></comune>
<comune><nome>Carpasio</nome><codice>B814</codice></comune>
<comune><nome>Carpegna</nome><codice>B816</codice></comune>
<comune><nome>Carpenedolo</nome><codice>B817</codice></comune>
<comune><nome>Carpeneto</nome><codice>B818</codice></comune>
<comune><nome>Carpi</nome><codice>B819</codice></comune>
<comune><nome>Carpiano</nome><codice>B820</codice></comune>
<comune><nome>Carpignano Salentino</nome><codice>B822</codice></comune>
<comune><nome>Carpignano Sesia</nome><codice>B823</codice></comune>
<comune><nome>Carpineti</nome><codice>B825</codice></comune>
<comune><nome>Carpineto della Nora</nome><codice>B827</codice></comune>
<comune><nome>Carpineto Romano</nome><codice>B828</codice></comune>
<comune><nome>Carpineto Sinello</nome><codice>B826</codice></comune>
<comune><nome>Carpino</nome><codice>B829</codice></comune>
<comune><nome>Carpinone</nome><codice>B830</codice></comune>
<comune><nome>Carrara</nome><codice>B832</codice></comune>
<comune><nome>Carrè</nome><codice>B835</codice></comune>
<comune><nome>Carrega Ligure</nome><codice>B836</codice></comune>
<comune><nome>Carro</nome><codice>B838</codice></comune>
<comune><nome>Carrodano</nome><codice>B839</codice></comune>
<comune><nome>Carrosio</nome><codice>B840</codice></comune>
<comune><nome>Carrù</nome><codice>B841</codice></comune>
<comune><nome>Carsoli</nome><codice>B842</codice></comune>
<comune><nome>Cartigliano</nome><codice>B844</codice></comune>
<comune><nome>Cartignano</nome><codice>B845</codice></comune>
<comune><nome>Cartoceto</nome><codice>B846</codice></comune>
<comune><nome>Cartosio</nome><codice>B847</codice></comune>
<comune><nome>Cartura</nome><codice>B848</codice></comune>
<comune><nome>Carugate</nome><codice>B850</codice></comune>
<comune><nome>Carugo</nome><codice>B851</codice></comune>
<comune><nome>Carunchio</nome><codice>B853</codice></comune>
<comune><nome>Carvico</nome><codice>B854</codice></comune>
<comune><nome>Carzano</nome><codice>B856</codice></comune>
<comune><nome>Casabona</nome><codice>B857</codice></comune>
<comune><nome>Casacalenda</nome><codice>B858</codice></comune>
<comune><nome>Casacanditella</nome><codice>B859</codice></comune>
<comune><nome>Casagiove</nome><codice>B860</codice></comune>
<comune><nome>Casal Cermelli</nome><codice>B870</codice></comune>
<comune><nome>Casal di Principe</nome><codice>B872</codice></comune>
<comune><nome>Casal Velino</nome><codice>B895</codice></comune>
<comune><nome>Casalanguida</nome><codice>B861</codice></comune>
<comune><nome>Casalattico</nome><codice>B862</codice></comune>
<comune><nome>Casalbeltrame</nome><codice>B864</codice></comune>
<comune><nome>Casalbordino</nome><codice>B865</codice></comune>
<comune><nome>Casalbore</nome><codice>B866</codice></comune>
<comune><nome>Casalborgone</nome><codice>B867</codice></comune>
<comune><nome>Casalbuono</nome><codice>B868</codice></comune>
<comune><nome>Casalbuttano ed Uniti</nome><codice>B869</codice></comune>
<comune><nome>Casalciprano</nome><codice>B871</codice></comune>
<comune><nome>Casalduni</nome><codice>B873</codice></comune>
<comune><nome>Casale Corte Cerro</nome><codice>B876</codice></comune>
<comune><nome>Casale Cremasco-Vidolasco</nome><codice>B881</codice></comune>
<comune><nome>Casale di Scodosia</nome><codice>B877</codice></comune>
<comune><nome>Casale Litta</nome><codice>B875</codice></comune>
<comune><nome>Casale Marittimo</nome><codice>B878</codice></comune>
<comune><nome>Casale Monferrato</nome><codice>B885</codice></comune>
<comune><nome>Casale sul Sile</nome><codice>B879</codice></comune>
<comune><nome>Casalecchio di Reno</nome><codice>B880</codice></comune>
<comune><nome>Casaleggio Boiro</nome><codice>B882</codice></comune>
<comune><nome>Casaleggio Novara</nome><codice>B883</codice></comune>
<comune><nome>Casaleone</nome><codice>B886</codice></comune>
<comune><nome>Casaletto Ceredano</nome><codice>B889</codice></comune>
<comune><nome>Casaletto di Sopra</nome><codice>B890</codice></comune>
<comune><nome>Casaletto Lodigiano</nome><codice>B887</codice></comune>
<comune><nome>Casaletto Spartano</nome><codice>B888</codice></comune>
<comune><nome>Casaletto Vaprio</nome><codice>B891</codice></comune>
<comune><nome>Casalfiumanese</nome><codice>B892</codice></comune>
<comune><nome>Casalgrande</nome><codice>B893</codice></comune>
<comune><nome>Casalgrasso</nome><codice>B894</codice></comune>
<comune><nome>Casalincontrada</nome><codice>B896</codice></comune>
<comune><nome>Casalino</nome><codice>B897</codice></comune>
<comune><nome>Casalmaggiore</nome><codice>B898</codice></comune>
<comune><nome>Casalmaiocco</nome><codice>B899</codice></comune>
<comune><nome>Casalmorano</nome><codice>B900</codice></comune>
<comune><nome>Casalmoro</nome><codice>B901</codice></comune>
<comune><nome>Casalnoceto</nome><codice>B902</codice></comune>
<comune><nome>Casalnuovo di Napoli</nome><codice>B905</codice></comune>
<comune><nome>Casalnuovo Monterotaro</nome><codice>B904</codice></comune>
<comune><nome>Casaloldo</nome><codice>B907</codice></comune>
<comune><nome>Casalpusterlengo</nome><codice>B910</codice></comune>
<comune><nome>Casalromano</nome><codice>B911</codice></comune>
<comune><nome>Casalserugo</nome><codice>B912</codice></comune>
<comune><nome>Casaluce</nome><codice>B916</codice></comune>
<comune><nome>Casalvecchio di Puglia</nome><codice>B917</codice></comune>
<comune><nome>Casalvecchio Siculo</nome><codice>B918</codice></comune>
<comune><nome>Casalvieri</nome><codice>B919</codice></comune>
<comune><nome>Casalvolone</nome><codice>B920</codice></comune>
<comune><nome>Casalzuigno</nome><codice>B921</codice></comune>
<comune><nome>Casamarciano</nome><codice>B922</codice></comune>
<comune><nome>Casamassima</nome><codice>B923</codice></comune>
<comune><nome>Casamicciola Terme</nome><codice>B924</codice></comune>
<comune><nome>Casandrino</nome><codice>B925</codice></comune>
<comune><nome>Casanova Elvo</nome><codice>B928</codice></comune>
<comune><nome>Casanova Lerrone</nome><codice>B927</codice></comune>
<comune><nome>Casanova Lonati</nome><codice>B929</codice></comune>
<comune><nome>Casape</nome><codice>B932</codice></comune>
<comune><nome>Casapesenna</nome><codice>M260</codice></comune>
<comune><nome>Casapinta</nome><codice>B933</codice></comune>
<comune><nome>Casaprota</nome><codice>B934</codice></comune>
<comune><nome>Casapulla</nome><codice>B935</codice></comune>
<comune><nome>Casarano</nome><codice>B936</codice></comune>
<comune><nome>Casargo</nome><codice>B937</codice></comune>
<comune><nome>Casarile</nome><codice>B938</codice></comune>
<comune><nome>Casarsa della Delizia</nome><codice>B940</codice></comune>
<comune><nome>Casarza Ligure</nome><codice>B939</codice></comune>
<comune><nome>Casasco</nome><codice>B941</codice></comune>
<comune><nome>Casasco d'Intelvi</nome><codice>B942</codice></comune>
<comune><nome>Casatenovo</nome><codice>B943</codice></comune>
<comune><nome>Casatisma</nome><codice>B945</codice></comune>
<comune><nome>Casavatore</nome><codice>B946</codice></comune>
<comune><nome>Casazza</nome><codice>B947</codice></comune>
<comune><nome>Cascia</nome><codice>B948</codice></comune>
<comune><nome>Casciago</nome><codice>B949</codice></comune>
<comune><nome>Casciana Terme</nome><codice>A559</codice></comune>
<comune><nome>Cascina</nome><codice>B950</codice></comune>
<comune><nome>Cascinette d'Ivrea</nome><codice>B953</codice></comune>
<comune><nome>Casei Gerola</nome><codice>B954</codice></comune>
<comune><nome>Caselette</nome><codice>B955</codice></comune>
<comune><nome>Casella</nome><codice>B956</codice></comune>
<comune><nome>Caselle in Pittari</nome><codice>B959</codice></comune>
<comune><nome>Caselle Landi</nome><codice>B961</codice></comune>
<comune><nome>Caselle Lurani</nome><codice>B958</codice></comune>
<comune><nome>Caselle Torinese</nome><codice>B960</codice></comune>
<comune><nome>Caserta</nome><codice>B963</codice></comune>
<comune><nome>Casier</nome><codice>B965</codice></comune>
<comune><nome>Casignana</nome><codice>B966</codice></comune>
<comune><nome>Casina</nome><codice>B967</codice></comune>
<comune><nome>Casirate d'Adda</nome><codice>B971</codice></comune>
<comune><nome>Caslino d'Erba</nome><codice>B974</codice></comune>
<comune><nome>Casnate con Bernate</nome><codice>B977</codice></comune>
<comune><nome>Casnigo</nome><codice>B978</codice></comune>
<comune><nome>Casola di Napoli</nome><codice>B980</codice></comune>
<comune><nome>Casola in Lunigiana</nome><codice>B979</codice></comune>
<comune><nome>Casola Valsenio</nome><codice>B982</codice></comune>
<comune><nome>Casole Bruzio</nome><codice>B983</codice></comune>
<comune><nome>Casole d'Elsa</nome><codice>B984</codice></comune>
<comune><nome>Casoli</nome><codice>B985</codice></comune>
<comune><nome>Casorate Primo</nome><codice>B988</codice></comune>
<comune><nome>Casorate Sempione</nome><codice>B987</codice></comune>
<comune><nome>Casorezzo</nome><codice>B989</codice></comune>
<comune><nome>Casoria</nome><codice>B990</codice></comune>
<comune><nome>Casorzo</nome><codice>B991</codice></comune>
<comune><nome>Casperia</nome><codice>A472</codice></comune>
<comune><nome>Caspoggio</nome><codice>B993</codice></comune>
<comune><nome>Cassacco</nome><codice>B994</codice></comune>
<comune><nome>Cassago Brianza</nome><codice>B996</codice></comune>
<comune><nome>Cassano all'Ionio</nome><codice>C002</codice></comune>
<comune><nome>Cassano d'Adda</nome><codice>C003</codice></comune>
<comune><nome>Cassano delle Murge</nome><codice>B998</codice></comune>
<comune><nome>Cassano Irpino</nome><codice>B997</codice></comune>
<comune><nome>Cassano Magnago</nome><codice>C004</codice></comune>
<comune><nome>Cassano Spinola</nome><codice>C005</codice></comune>
<comune><nome>Cassano Valcuvia</nome><codice>B999</codice></comune>
<comune><nome>Cassaro</nome><codice>C006</codice></comune>
<comune><nome>Cassiglio</nome><codice>C007</codice></comune>
<comune><nome>Cassina de' Pecchi</nome><codice>C014</codice></comune>
<comune><nome>Cassina Rizzardi</nome><codice>C020</codice></comune>
<comune><nome>Cassina Valsassina</nome><codice>C024</codice></comune>
<comune><nome>Cassinasco</nome><codice>C022</codice></comune>
<comune><nome>Cassine</nome><codice>C027</codice></comune>
<comune><nome>Cassinelle</nome><codice>C030</codice></comune>
<comune><nome>Cassinetta di Lugagnano</nome><codice>C033</codice></comune>
<comune><nome>Cassino</nome><codice>C034</codice></comune>
<comune><nome>Cassola</nome><codice>C037</codice></comune>
<comune><nome>Cassolnovo</nome><codice>C038</codice></comune>
<comune><nome>Castagnaro</nome><codice>C041</codice></comune>
<comune><nome>Castagneto Carducci</nome><codice>C044</codice></comune>
<comune><nome>Castagneto Po</nome><codice>C045</codice></comune>
<comune><nome>Castagnito</nome><codice>C046</codice></comune>
<comune><nome>Castagnole delle Lanze</nome><codice>C049</codice></comune>
<comune><nome>Castagnole Monferrato</nome><codice>C047</codice></comune>
<comune><nome>Castagnole Piemonte</nome><codice>C048</codice></comune>
<comune><nome>Castana</nome><codice>C050</codice></comune>
<comune><nome>Castano Primo</nome><codice>C052</codice></comune>
<comune><nome>Casteggio</nome><codice>C053</codice></comune>
<comune><nome>Castegnato</nome><codice>C055</codice></comune>
<comune><nome>Castegnero</nome><codice>C056</codice></comune>
<comune><nome>Castel Baronia</nome><codice>C058</codice></comune>
<comune><nome>Castel Boglione</nome><codice>C064</codice></comune>
<comune><nome>Castel Bolognese</nome><codice>C065</codice></comune>
<comune><nome>Castel Campagnano</nome><codice>B494</codice></comune>
<comune><nome>Castel Castagna</nome><codice>C040</codice></comune>
<comune><nome>Castel Colonna</nome><codice>C071</codice></comune>
<comune><nome>Castel Condino</nome><codice>C183</codice></comune>
<comune><nome>Castel d'Aiano</nome><codice>C075</codice></comune>
<comune><nome>Castel d'Ario</nome><codice>C076</codice></comune>
<comune><nome>Castel d'Azzano</nome><codice>C078</codice></comune>
<comune><nome>Castel del Giudice</nome><codice>C082</codice></comune>
<comune><nome>Castel del Monte</nome><codice>C083</codice></comune>
<comune><nome>Castel del Piano</nome><codice>C085</codice></comune>
<comune><nome>Castel del Rio</nome><codice>C086</codice></comune>
<comune><nome>Castel di Casio</nome><codice>B969</codice></comune>
<comune><nome>Castel di Ieri</nome><codice>C090</codice></comune>
<comune><nome>Castel di Iudica</nome><codice>C091</codice></comune>
<comune><nome>Castel di Lama</nome><codice>C093</codice></comune>
<comune><nome>Castel di Lucio</nome><codice>C094</codice></comune>
<comune><nome>Castel di Sangro</nome><codice>C096</codice></comune>
<comune><nome>Castel di Sasso</nome><codice>C097</codice></comune>
<comune><nome>Castel di Tora</nome><codice>C098</codice></comune>
<comune><nome>Castel Focognano</nome><codice>C102</codice></comune>
<comune><nome>Castel Frentano</nome><codice>C114</codice></comune>
<comune><nome>Castel Gabbiano</nome><codice>C115</codice></comune>
<comune><nome>Castel Gandolfo</nome><codice>C116</codice></comune>
<comune><nome>Castel Giorgio</nome><codice>C117</codice></comune>
<comune><nome>Castel Goffredo</nome><codice>C118</codice></comune>
<comune><nome>Castel Guelfo di Bologna</nome><codice>C121</codice></comune>
<comune><nome>Castel Madama</nome><codice>C203</codice></comune>
<comune><nome>Castel Maggiore</nome><codice>C204</codice></comune>
<comune><nome>Castel Mella</nome><codice>C208</codice></comune>
<comune><nome>Castel Morrone</nome><codice>C211</codice></comune>
<comune><nome>Castel Ritaldi</nome><codice>C252</codice></comune>
<comune><nome>Castel Rocchero</nome><codice>C253</codice></comune>
<comune><nome>Castel Rozzone</nome><codice>C255</codice></comune>
<comune><nome>Castel San Giorgio</nome><codice>C259</codice></comune>
<comune><nome>Castel San Giovanni</nome><codice>C261</codice></comune>
<comune><nome>Castel San Lorenzo</nome><codice>C262</codice></comune>
<comune><nome>Castel San Niccolò</nome><codice>C263</codice></comune>
<comune><nome>Castel San Pietro Romano</nome><codice>C266</codice></comune>
<comune><nome>Castel San Pietro Terme</nome><codice>C265</codice></comune>
<comune><nome>Castel San Vincenzo</nome><codice>C270</codice></comune>
<comune><nome>Castel Sant'Angelo</nome><codice>C268</codice></comune>
<comune><nome>Castel Sant'Elia</nome><codice>C269</codice></comune>
<comune><nome>Castel Viscardo</nome><codice>C289</codice></comune>
<comune><nome>Castel Vittorio</nome><codice>C110</codice></comune>
<comune><nome>Castel Volturno</nome><codice>C291</codice></comune>
<comune><nome>Castelbaldo</nome><codice>C057</codice></comune>
<comune><nome>Castelbelforte</nome><codice>C059</codice></comune>
<comune><nome>Castelbellino</nome><codice>C060</codice></comune>
<comune><nome>Castelbello-Ciardes</nome><codice>C062</codice></comune>
<comune><nome>Castelbianco</nome><codice>C063</codice></comune>
<comune><nome>Castelbottaccio</nome><codice>C066</codice></comune>
<comune><nome>Castelbuono</nome><codice>C067</codice></comune>
<comune><nome>Castelcivita</nome><codice>C069</codice></comune>
<comune><nome>Castelcovati</nome><codice>C072</codice></comune>
<comune><nome>Castelcucco</nome><codice>C073</codice></comune>
<comune><nome>Casteldaccia</nome><codice>C074</codice></comune>
<comune><nome>Casteldelci</nome><codice>C080</codice></comune>
<comune><nome>Casteldelfino</nome><codice>C081</codice></comune>
<comune><nome>Casteldidone</nome><codice>C089</codice></comune>
<comune><nome>Castelfidardo</nome><codice>C100</codice></comune>
<comune><nome>Castelfiorentino</nome><codice>C101</codice></comune>
<comune><nome>Castelfondo</nome><codice>C103</codice></comune>
<comune><nome>Castelforte</nome><codice>C104</codice></comune>
<comune><nome>Castelfranci</nome><codice>C105</codice></comune>
<comune><nome>Castelfranco di Sopra</nome><codice>C112</codice></comune>
<comune><nome>Castelfranco di Sotto</nome><codice>C113</codice></comune>
<comune><nome>Castelfranco Emilia</nome><codice>C107</codice></comune>
<comune><nome>Castelfranco in Miscano</nome><codice>C106</codice></comune>
<comune><nome>Castelfranco Veneto</nome><codice>C111</codice></comune>
<comune><nome>Castelgomberto</nome><codice>C119</codice></comune>
<comune><nome>Castelgrande</nome><codice>C120</codice></comune>
<comune><nome>Castelguglielmo</nome><codice>C122</codice></comune>
<comune><nome>Castelguidone</nome><codice>C123</codice></comune>
<comune><nome>Castellabate</nome><codice>C125</codice></comune>
<comune><nome>Castellafiume</nome><codice>C126</codice></comune>
<comune><nome>Castell'Alfero</nome><codice>C127</codice></comune>
<comune><nome>Castellalto</nome><codice>C128</codice></comune>
<comune><nome>Castellammare del Golfo</nome><codice>C130</codice></comune>
<comune><nome>Castellammare di Stabia</nome><codice>C129</codice></comune>
<comune><nome>Castellamonte</nome><codice>C133</codice></comune>
<comune><nome>Castellana Grotte</nome><codice>C134</codice></comune>
<comune><nome>Castellana Sicula</nome><codice>C135</codice></comune>
<comune><nome>Castellaneta</nome><codice>C136</codice></comune>
<comune><nome>Castellania</nome><codice>C137</codice></comune>
<comune><nome>Castellanza</nome><codice>C139</codice></comune>
<comune><nome>Castellar</nome><codice>C140</codice></comune>
<comune><nome>Castellar Guidobono</nome><codice>C142</codice></comune>
<comune><nome>Castellarano</nome><codice>C141</codice></comune>
<comune><nome>Castellaro</nome><codice>C143</codice></comune>
<comune><nome>Castell'Arquato</nome><codice>C145</codice></comune>
<comune><nome>Castellavazzo</nome><codice>C146</codice></comune>
<comune><nome>Castell'Azzara</nome><codice>C147</codice></comune>
<comune><nome>Castellazzo Bormida</nome><codice>C148</codice></comune>
<comune><nome>Castellazzo Novarese</nome><codice>C149</codice></comune>
<comune><nome>Castelleone</nome><codice>C153</codice></comune>
<comune><nome>Castelleone di Suasa</nome><codice>C152</codice></comune>
<comune><nome>Castellero</nome><codice>C154</codice></comune>
<comune><nome>Castelletto Cervo</nome><codice>C155</codice></comune>
<comune><nome>Castelletto d'Erro</nome><codice>C156</codice></comune>
<comune><nome>Castelletto di Branduzzo</nome><codice>C157</codice></comune>
<comune><nome>Castelletto d'Orba</nome><codice>C158</codice></comune>
<comune><nome>Castelletto Merli</nome><codice>C160</codice></comune>
<comune><nome>Castelletto Molina</nome><codice>C161</codice></comune>
<comune><nome>Castelletto Monferrato</nome><codice>C162</codice></comune>
<comune><nome>Castelletto Sopra Ticino</nome><codice>C166</codice></comune>
<comune><nome>Castelletto Stura</nome><codice>C165</codice></comune>
<comune><nome>Castelletto Uzzone</nome><codice>C167</codice></comune>
<comune><nome>Castelli</nome><codice>C169</codice></comune>
<comune><nome>Castelli Calepio</nome><codice>C079</codice></comune>
<comune><nome>Castellina in Chianti</nome><codice>C172</codice></comune>
<comune><nome>Castellina Marittima</nome><codice>C174</codice></comune>
<comune><nome>Castellinaldo</nome><codice>C173</codice></comune>
<comune><nome>Castellino del Biferno</nome><codice>C175</codice></comune>
<comune><nome>Castellino Tanaro</nome><codice>C176</codice></comune>
<comune><nome>Castelliri</nome><codice>C177</codice></comune>
<comune><nome>Castello Cabiaglio</nome><codice>B312</codice></comune>
<comune><nome>Castello d'Agogna</nome><codice>C184</codice></comune>
<comune><nome>Castello d'Argile</nome><codice>C185</codice></comune>
<comune><nome>Castello del Matese</nome><codice>C178</codice></comune>
<comune><nome>Castello dell'Acqua</nome><codice>C186</codice></comune>
<comune><nome>Castello di Annone</nome><codice>A300</codice></comune>
<comune><nome>Castello di Brianza</nome><codice>C187</codice></comune>
<comune><nome>Castello di Cisterna</nome><codice>C188</codice></comune>
<comune><nome>Castello di Godego</nome><codice>C190</codice></comune>
<comune><nome>Castello di Serravalle</nome><codice>C191</codice></comune>
<comune><nome>Castello Tesino</nome><codice>C194</codice></comune>
<comune><nome>Castello-Molina di Fiemme</nome><codice>C189</codice></comune>
<comune><nome>Castellucchio</nome><codice>C195</codice></comune>
<comune><nome>Castelluccio dei Sauri</nome><codice>C198</codice></comune>
<comune><nome>Castelluccio Inferiore</nome><codice>C199</codice></comune>
<comune><nome>Castelluccio Superiore</nome><codice>C201</codice></comune>
<comune><nome>Castelluccio Valmaggiore</nome><codice>C202</codice></comune>
<comune><nome>Castell'Umberto</nome><codice>C051</codice></comune>
<comune><nome>Castelmagno</nome><codice>C205</codice></comune>
<comune><nome>Castelmarte</nome><codice>C206</codice></comune>
<comune><nome>Castelmassa</nome><codice>C207</codice></comune>
<comune><nome>Castelmauro</nome><codice>C197</codice></comune>
<comune><nome>Castelmezzano</nome><codice>C209</codice></comune>
<comune><nome>Castelmola</nome><codice>C210</codice></comune>
<comune><nome>Castelnovetto</nome><codice>C213</codice></comune>
<comune><nome>Castelnovo Bariano</nome><codice>C215</codice></comune>
<comune><nome>Castelnovo del Friuli</nome><codice>C217</codice></comune>
<comune><nome>Castelnovo di Sotto</nome><codice>C218</codice></comune>
<comune><nome>Castelnovo ne' Monti</nome><codice>C219</codice></comune>
<comune><nome>Castelnuovo</nome><codice>C216</codice></comune>
<comune><nome>Castelnuovo Belbo</nome><codice>C226</codice></comune>
<comune><nome>Castelnuovo Berardenga</nome><codice>C227</codice></comune>
<comune><nome>Castelnuovo Bocca d'Adda</nome><codice>C228</codice></comune>
<comune><nome>Castelnuovo Bormida</nome><codice>C229</codice></comune>
<comune><nome>Castelnuovo Bozzente</nome><codice>C220</codice></comune>
<comune><nome>Castelnuovo Calcea</nome><codice>C230</codice></comune>
<comune><nome>Castelnuovo Cilento</nome><codice>C231</codice></comune>
<comune><nome>Castelnuovo del Garda</nome><codice>C225</codice></comune>
<comune><nome>Castelnuovo della Daunia</nome><codice>C222</codice></comune>
<comune><nome>Castelnuovo di Ceva</nome><codice>C214</codice></comune>
<comune><nome>Castelnuovo di Conza</nome><codice>C235</codice></comune>
<comune><nome>Castelnuovo di Farfa</nome><codice>C224</codice></comune>
<comune><nome>Castelnuovo di Garfagnana</nome><codice>C236</codice></comune>
<comune><nome>Castelnuovo di Porto</nome><codice>C237</codice></comune>
<comune><nome>Castelnuovo di Val di Cecina</nome><codice>C244</codice></comune>
<comune><nome>Castelnuovo Don Bosco</nome><codice>C232</codice></comune>
<comune><nome>Castelnuovo Magra</nome><codice>C240</codice></comune>
<comune><nome>Castelnuovo Nigra</nome><codice>C241</codice></comune>
<comune><nome>Castelnuovo Parano</nome><codice>C223</codice></comune>
<comune><nome>Castelnuovo Rangone</nome><codice>C242</codice></comune>
<comune><nome>Castelnuovo Scrivia</nome><codice>C243</codice></comune>
<comune><nome>Castelpagano</nome><codice>C245</codice></comune>
<comune><nome>Castelpetroso</nome><codice>C246</codice></comune>
<comune><nome>Castelpizzuto</nome><codice>C247</codice></comune>
<comune><nome>Castelplanio</nome><codice>C248</codice></comune>
<comune><nome>Castelpoto</nome><codice>C250</codice></comune>
<comune><nome>Castelraimondo</nome><codice>C251</codice></comune>
<comune><nome>Castelrotto</nome><codice>C254</codice></comune>
<comune><nome>Castelsantangelo sul Nera</nome><codice>C267</codice></comune>
<comune><nome>Castelsaraceno</nome><codice>C271</codice></comune>
<comune><nome>Castelsardo</nome><codice>C272</codice></comune>
<comune><nome>Castelseprio</nome><codice>C273</codice></comune>
<comune><nome>Castelsilano</nome><codice>B968</codice></comune>
<comune><nome>Castelspina</nome><codice>C274</codice></comune>
<comune><nome>Casteltermini</nome><codice>C275</codice></comune>
<comune><nome>Castelveccana</nome><codice>C181</codice></comune>
<comune><nome>Castelvecchio Calvisio</nome><codice>C278</codice></comune>
<comune><nome>Castelvecchio di Rocca Barbena</nome><codice>C276</codice></comune>
<comune><nome>Castelvecchio Subequo</nome><codice>C279</codice></comune>
<comune><nome>Castelvenere</nome><codice>C280</codice></comune>
<comune><nome>Castelverde</nome><codice>B129</codice></comune>
<comune><nome>Castelverrino</nome><codice>C200</codice></comune>
<comune><nome>Castelvetere in Val Fortore</nome><codice>C284</codice></comune>
<comune><nome>Castelvetere sul Calore</nome><codice>C283</codice></comune>
<comune><nome>Castelvetrano</nome><codice>C286</codice></comune>
<comune><nome>Castelvetro di Modena</nome><codice>C287</codice></comune>
<comune><nome>Castelvetro Piacentino</nome><codice>C288</codice></comune>
<comune><nome>Castelvisconti</nome><codice>C290</codice></comune>
<comune><nome>Castenaso</nome><codice>C292</codice></comune>
<comune><nome>Castenedolo</nome><codice>C293</codice></comune>
<comune><nome>Castiadas</nome><codice>M288</codice></comune>
<comune><nome>Castiglion Fibocchi</nome><codice>C318</codice></comune>
<comune><nome>Castiglion Fiorentino</nome><codice>C319</codice></comune>
<comune><nome>Castiglione a Casauria</nome><codice>C308</codice></comune>
<comune><nome>Castiglione Chiavarese</nome><codice>C302</codice></comune>
<comune><nome>Castiglione Cosentino</nome><codice>C301</codice></comune>
<comune><nome>Castiglione d'Adda</nome><codice>C304</codice></comune>
<comune><nome>Castiglione dei Pepoli</nome><codice>C296</codice></comune>
<comune><nome>Castiglione del Genovesi</nome><codice>C306</codice></comune>
<comune><nome>Castiglione del Lago</nome><codice>C309</codice></comune>
<comune><nome>Castiglione della Pescaia</nome><codice>C310</codice></comune>
<comune><nome>Castiglione delle Stiviere</nome><codice>C312</codice></comune>
<comune><nome>Castiglione di Garfagnana</nome><codice>C303</codice></comune>
<comune><nome>Castiglione di Sicilia</nome><codice>C297</codice></comune>
<comune><nome>Castiglione d'Intelvi</nome><codice>C299</codice></comune>
<comune><nome>Castiglione d'Orcia</nome><codice>C313</codice></comune>
<comune><nome>Castiglione Falletto</nome><codice>C314</codice></comune>
<comune><nome>Castiglione in Teverina</nome><codice>C315</codice></comune>
<comune><nome>Castiglione Messer Marino</nome><codice>C298</codice></comune>
<comune><nome>Castiglione Messer Raimondo</nome><codice>C316</codice></comune>
<comune><nome>Castiglione Olona</nome><codice>C300</codice></comune>
<comune><nome>Castiglione Tinella</nome><codice>C317</codice></comune>
<comune><nome>Castiglione Torinese</nome><codice>C307</codice></comune>
<comune><nome>Castignano</nome><codice>C321</codice></comune>
<comune><nome>Castilenti</nome><codice>C322</codice></comune>
<comune><nome>Castino</nome><codice>C323</codice></comune>
<comune><nome>Castione Andevenno</nome><codice>C325</codice></comune>
<comune><nome>Castione della Presolana</nome><codice>C324</codice></comune>
<comune><nome>Castions di Strada</nome><codice>C327</codice></comune>
<comune><nome>Castiraga Vidardo</nome><codice>C329</codice></comune>
<comune><nome>Casto</nome><codice>C330</codice></comune>
<comune><nome>Castorano</nome><codice>C331</codice></comune>
<comune><nome>Castrezzato</nome><codice>C332</codice></comune>
<comune><nome>Castri di Lecce</nome><codice>C334</codice></comune>
<comune><nome>Castrignano de' Greci</nome><codice>C335</codice></comune>
<comune><nome>Castrignano del Capo</nome><codice>C336</codice></comune>
<comune><nome>Castro</nome><codice>C337</codice></comune>
<comune><nome>Castro</nome><codice>M261</codice></comune>
<comune><nome>Castro dei Volsci</nome><codice>C338</codice></comune>
<comune><nome>Castrocaro Terme e Terra del Sole</nome><codice>C339</codice></comune>
<comune><nome>Castrocielo</nome><codice>C340</codice></comune>
<comune><nome>Castrofilippo</nome><codice>C341</codice></comune>
<comune><nome>Castrolibero</nome><codice>C108</codice></comune>
<comune><nome>Castronno</nome><codice>C343</codice></comune>
<comune><nome>Castronovo di Sicilia</nome><codice>C344</codice></comune>
<comune><nome>Castronuovo di Sant'Andrea</nome><codice>C345</codice></comune>
<comune><nome>Castropignano</nome><codice>C346</codice></comune>
<comune><nome>Castroreale</nome><codice>C347</codice></comune>
<comune><nome>Castroregio</nome><codice>C348</codice></comune>
<comune><nome>Castrovillari</nome><codice>C349</codice></comune>
<comune><nome>Catania</nome><codice>C351</codice></comune>
<comune><nome>Catanzaro</nome><codice>C352</codice></comune>
<comune><nome>Catenanuova</nome><codice>C353</codice></comune>
<comune><nome>Catignano</nome><codice>C354</codice></comune>
<comune><nome>Cattolica</nome><codice>C357</codice></comune>
<comune><nome>Cattolica Eraclea</nome><codice>C356</codice></comune>
<comune><nome>Caulonia</nome><codice>C285</codice></comune>
<comune><nome>Cautano</nome><codice>C359</codice></comune>
<comune><nome>Cava de' Tirreni</nome><codice>C361</codice></comune>
<comune><nome>Cava Manara</nome><codice>C360</codice></comune>
<comune><nome>Cavacurta</nome><codice>C362</codice></comune>
<comune><nome>Cavaglià</nome><codice>C363</codice></comune>
<comune><nome>Cavaglietto</nome><codice>C364</codice></comune>
<comune><nome>Cavaglio d'Agogna</nome><codice>C365</codice></comune>
<comune><nome>Cavaglio-Spoccia</nome><codice>C367</codice></comune>
<comune><nome>Cavagnolo</nome><codice>C369</codice></comune>
<comune><nome>Cavaion Veronese</nome><codice>C370</codice></comune>
<comune><nome>Cavalese</nome><codice>C372</codice></comune>
<comune><nome>Cavallasca</nome><codice>C374</codice></comune>
<comune><nome>Cavallerleone</nome><codice>C375</codice></comune>
<comune><nome>Cavallermaggiore</nome><codice>C376</codice></comune>
<comune><nome>Cavallino</nome><codice>C377</codice></comune>
<comune><nome>Cavallino-Treporti</nome><codice>M308</codice></comune>
<comune><nome>Cavallirio</nome><codice>C378</codice></comune>
<comune><nome>Cavareno</nome><codice>C380</codice></comune>
<comune><nome>Cavargna</nome><codice>C381</codice></comune>
<comune><nome>Cavaria con Premezzo</nome><codice>C382</codice></comune>
<comune><nome>Cavarzere</nome><codice>C383</codice></comune>
<comune><nome>Cavaso del Tomba</nome><codice>C384</codice></comune>
<comune><nome>Cavasso Nuovo</nome><codice>C385</codice></comune>
<comune><nome>Cavatore</nome><codice>C387</codice></comune>
<comune><nome>Cavazzo Carnico</nome><codice>C389</codice></comune>
<comune><nome>Cave</nome><codice>C390</codice></comune>
<comune><nome>Cavedago</nome><codice>C392</codice></comune>
<comune><nome>Cavedine</nome><codice>C393</codice></comune>
<comune><nome>Cavenago d'Adda</nome><codice>C394</codice></comune>
<comune><nome>Cavenago di Brianza</nome><codice>C395</codice></comune>
<comune><nome>Cavernago</nome><codice>C396</codice></comune>
<comune><nome>Cavezzo</nome><codice>C398</codice></comune>
<comune><nome>Cavizzana</nome><codice>C400</codice></comune>
<comune><nome>Cavour</nome><codice>C404</codice></comune>
<comune><nome>Cavriago</nome><codice>C405</codice></comune>
<comune><nome>Cavriana</nome><codice>C406</codice></comune>
<comune><nome>Cavriglia</nome><codice>C407</codice></comune>
<comune><nome>Cazzago Brabbia</nome><codice>C409</codice></comune>
<comune><nome>Cazzago San Martino</nome><codice>C408</codice></comune>
<comune><nome>Cazzano di Tramigna</nome><codice>C412</codice></comune>
<comune><nome>Cazzano Sant'Andrea</nome><codice>C410</codice></comune>
<comune><nome>Ceccano</nome><codice>C413</codice></comune>
<comune><nome>Cecima</nome><codice>C414</codice></comune>
<comune><nome>Cecina</nome><codice>C415</codice></comune>
<comune><nome>Cedegolo</nome><codice>C417</codice></comune>
<comune><nome>Cedrasco</nome><codice>C418</codice></comune>
<comune><nome>Cefalà Diana</nome><codice>C420</codice></comune>
<comune><nome>Cefalù</nome><codice>C421</codice></comune>
<comune><nome>Ceggia</nome><codice>C422</codice></comune>
<comune><nome>Ceglie Messapica</nome><codice>C424</codice></comune>
<comune><nome>Celano</nome><codice>C426</codice></comune>
<comune><nome>Celenza sul Trigno</nome><codice>C428</codice></comune>
<comune><nome>Celenza Valfortore</nome><codice>C429</codice></comune>
<comune><nome>Celico</nome><codice>C430</codice></comune>
<comune><nome>Cella Dati</nome><codice>C435</codice></comune>
<comune><nome>Cella Monte</nome><codice>C432</codice></comune>
<comune><nome>Cellamare</nome><codice>C436</codice></comune>
<comune><nome>Cellara</nome><codice>C437</codice></comune>
<comune><nome>Cellarengo</nome><codice>C438</codice></comune>
<comune><nome>Cellatica</nome><codice>C439</codice></comune>
<comune><nome>Celle di Bulgheria</nome><codice>C444</codice></comune>
<comune><nome>Celle di Macra</nome><codice>C441</codice></comune>
<comune><nome>Celle di San Vito</nome><codice>C442</codice></comune>
<comune><nome>Celle Enomondo</nome><codice>C440</codice></comune>
<comune><nome>Celle Ligure</nome><codice>C443</codice></comune>
<comune><nome>Celleno</nome><codice>C446</codice></comune>
<comune><nome>Cellere</nome><codice>C447</codice></comune>
<comune><nome>Cellino Attanasio</nome><codice>C449</codice></comune>
<comune><nome>Cellino San Marco</nome><codice>C448</codice></comune>
<comune><nome>Cellio</nome><codice>C450</codice></comune>
<comune><nome>Cellole</nome><codice>M262</codice></comune>
<comune><nome>Cembra</nome><codice>C452</codice></comune>
<comune><nome>Cenadi</nome><codice>C453</codice></comune>
<comune><nome>Cenate Sopra</nome><codice>C456</codice></comune>
<comune><nome>Cenate Sotto</nome><codice>C457</codice></comune>
<comune><nome>Cencenighe Agordino</nome><codice>C458</codice></comune>
<comune><nome>Cene</nome><codice>C459</codice></comune>
<comune><nome>Ceneselli</nome><codice>C461</codice></comune>
<comune><nome>Cengio</nome><codice>C463</codice></comune>
<comune><nome>Centa San Nicolò</nome><codice>C467</codice></comune>
<comune><nome>Centallo</nome><codice>C466</codice></comune>
<comune><nome>Cento</nome><codice>C469</codice></comune>
<comune><nome>Centola</nome><codice>C470</codice></comune>
<comune><nome>Centrache</nome><codice>C472</codice></comune>
<comune><nome>Centuripe</nome><codice>C471</codice></comune>
<comune><nome>Cepagatti</nome><codice>C474</codice></comune>
<comune><nome>Ceppaloni</nome><codice>C476</codice></comune>
<comune><nome>Ceppo Morelli</nome><codice>C478</codice></comune>
<comune><nome>Ceprano</nome><codice>C479</codice></comune>
<comune><nome>Cerami</nome><codice>C480</codice></comune>
<comune><nome>Ceranesi</nome><codice>C481</codice></comune>
<comune><nome>Cerano</nome><codice>C483</codice></comune>
<comune><nome>Cerano d'Intelvi</nome><codice>C482</codice></comune>
<comune><nome>Ceranova</nome><codice>C484</codice></comune>
<comune><nome>Ceraso</nome><codice>C485</codice></comune>
<comune><nome>Cercemaggiore</nome><codice>C486</codice></comune>
<comune><nome>Cercenasco</nome><codice>C487</codice></comune>
<comune><nome>Cercepiccola</nome><codice>C488</codice></comune>
<comune><nome>Cerchiara di Calabria</nome><codice>C489</codice></comune>
<comune><nome>Cerchio</nome><codice>C492</codice></comune>
<comune><nome>Cercino</nome><codice>C493</codice></comune>
<comune><nome>Cercivento</nome><codice>C494</codice></comune>
<comune><nome>Cercola</nome><codice>C495</codice></comune>
<comune><nome>Cerda</nome><codice>C496</codice></comune>
<comune><nome>Cerea</nome><codice>C498</codice></comune>
<comune><nome>Ceregnano</nome><codice>C500</codice></comune>
<comune><nome>Cerenzia</nome><codice>C501</codice></comune>
<comune><nome>Ceres</nome><codice>C497</codice></comune>
<comune><nome>Ceresara</nome><codice>C502</codice></comune>
<comune><nome>Cereseto</nome><codice>C503</codice></comune>
<comune><nome>Ceresole Alba</nome><codice>C504</codice></comune>
<comune><nome>Ceresole Reale</nome><codice>C505</codice></comune>
<comune><nome>Cerete</nome><codice>C506</codice></comune>
<comune><nome>Ceretto Lomellina</nome><codice>C508</codice></comune>
<comune><nome>Cergnago</nome><codice>C509</codice></comune>
<comune><nome>Ceriale</nome><codice>C510</codice></comune>
<comune><nome>Ceriana</nome><codice>C511</codice></comune>
<comune><nome>Ceriano Laghetto</nome><codice>C512</codice></comune>
<comune><nome>Cerignale</nome><codice>C513</codice></comune>
<comune><nome>Cerignola</nome><codice>C514</codice></comune>
<comune><nome>Cerisano</nome><codice>C515</codice></comune>
<comune><nome>Cermenate</nome><codice>C516</codice></comune>
<comune><nome>Cermes</nome><codice>A022</codice></comune>
<comune><nome>Cermignano</nome><codice>C517</codice></comune>
<comune><nome>Cernobbio</nome><codice>C520</codice></comune>
<comune><nome>Cernusco Lombardone</nome><codice>C521</codice></comune>
<comune><nome>Cernusco sul Naviglio</nome><codice>C523</codice></comune>
<comune><nome>Cerreto Castello</nome><codice>C526</codice></comune>
<comune><nome>Cerreto d'Asti</nome><codice>C528</codice></comune>
<comune><nome>Cerreto d'Esi</nome><codice>C524</codice></comune>
<comune><nome>Cerreto di Spoleto</nome><codice>C527</codice></comune>
<comune><nome>Cerreto Grue</nome><codice>C507</codice></comune>
<comune><nome>Cerreto Guidi</nome><codice>C529</codice></comune>
<comune><nome>Cerreto Laziale</nome><codice>C518</codice></comune>
<comune><nome>Cerreto Sannita</nome><codice>C525</codice></comune>
<comune><nome>Cerretto Langhe</nome><codice>C530</codice></comune>
<comune><nome>Cerrina Monferrato</nome><codice>C531</codice></comune>
<comune><nome>Cerrione</nome><codice>C532</codice></comune>
<comune><nome>Cerro al Lambro</nome><codice>C536</codice></comune>
<comune><nome>Cerro al Volturno</nome><codice>C534</codice></comune>
<comune><nome>Cerro Maggiore</nome><codice>C537</codice></comune>
<comune><nome>Cerro Tanaro</nome><codice>C533</codice></comune>
<comune><nome>Cerro Veronese</nome><codice>C538</codice></comune>
<comune><nome>Cersosimo</nome><codice>C539</codice></comune>
<comune><nome>Certaldo</nome><codice>C540</codice></comune>
<comune><nome>Certosa di Pavia</nome><codice>C541</codice></comune>
<comune><nome>Cerva</nome><codice>C542</codice></comune>
<comune><nome>Cervara di Roma</nome><codice>C543</codice></comune>
<comune><nome>Cervarese Santa Croce</nome><codice>C544</codice></comune>
<comune><nome>Cervaro</nome><codice>C545</codice></comune>
<comune><nome>Cervasca</nome><codice>C547</codice></comune>
<comune><nome>Cervatto</nome><codice>C548</codice></comune>
<comune><nome>Cerveno</nome><codice>C549</codice></comune>
<comune><nome>Cervere</nome><codice>C550</codice></comune>
<comune><nome>Cervesina</nome><codice>C551</codice></comune>
<comune><nome>Cerveteri</nome><codice>C552</codice></comune>
<comune><nome>Cervia</nome><codice>C553</codice></comune>
<comune><nome>Cervicati</nome><codice>C554</codice></comune>
<comune><nome>Cervignano d'Adda</nome><codice>C555</codice></comune>
<comune><nome>Cervignano del Friuli</nome><codice>C556</codice></comune>
<comune><nome>Cervinara</nome><codice>C557</codice></comune>
<comune><nome>Cervino</nome><codice>C558</codice></comune>
<comune><nome>Cervo</nome><codice>C559</codice></comune>
<comune><nome>Cerzeto</nome><codice>C560</codice></comune>
<comune><nome>Cesa</nome><codice>C561</codice></comune>
<comune><nome>Cesana Brianza</nome><codice>C563</codice></comune>
<comune><nome>Cesana Torinese</nome><codice>C564</codice></comune>
<comune><nome>Cesano Boscone</nome><codice>C565</codice></comune>
<comune><nome>Cesano Maderno</nome><codice>C566</codice></comune>
<comune><nome>Cesara</nome><codice>C567</codice></comune>
<comune><nome>Cesarò</nome><codice>C568</codice></comune>
<comune><nome>Cesate</nome><codice>C569</codice></comune>
<comune><nome>Cesena</nome><codice>C573</codice></comune>
<comune><nome>Cesenatico</nome><codice>C574</codice></comune>
<comune><nome>Cesinali</nome><codice>C576</codice></comune>
<comune><nome>Cesio</nome><codice>C578</codice></comune>
<comune><nome>Cesiomaggiore</nome><codice>C577</codice></comune>
<comune><nome>Cessalto</nome><codice>C580</codice></comune>
<comune><nome>Cessaniti</nome><codice>C581</codice></comune>
<comune><nome>Cessapalombo</nome><codice>C582</codice></comune>
<comune><nome>Cessole</nome><codice>C583</codice></comune>
<comune><nome>Cetara</nome><codice>C584</codice></comune>
<comune><nome>Ceto</nome><codice>C585</codice></comune>
<comune><nome>Cetona</nome><codice>C587</codice></comune>
<comune><nome>Cetraro</nome><codice>C588</codice></comune>
<comune><nome>Ceva</nome><codice>C589</codice></comune>
<comune><nome>Cevo</nome><codice>C591</codice></comune>
<comune><nome>Challand-Saint-Anselme</nome><codice>C593</codice></comune>
<comune><nome>Challand-Saint-Victor</nome><codice>C594</codice></comune>
<comune><nome>Chambave</nome><codice>C595</codice></comune>
<comune><nome>Chamois</nome><codice>B491</codice></comune>
<comune><nome>Champdepraz</nome><codice>C596</codice></comune>
<comune><nome>Champorcher</nome><codice>B540</codice></comune>
<comune><nome>Charvensod</nome><codice>C598</codice></comune>
<comune><nome>Chatillon</nome><codice>C294</codice></comune>
<comune><nome>Cherasco</nome><codice>C599</codice></comune>
<comune><nome>Cheremule</nome><codice>C600</codice></comune>
<comune><nome>Chialamberto</nome><codice>C604</codice></comune>
<comune><nome>Chiampo</nome><codice>C605</codice></comune>
<comune><nome>Chianche</nome><codice>C606</codice></comune>
<comune><nome>Chianciano Terme</nome><codice>C608</codice></comune>
<comune><nome>Chianni</nome><codice>C609</codice></comune>
<comune><nome>Chianocco</nome><codice>C610</codice></comune>
<comune><nome>Chiaramonte Gulfi</nome><codice>C612</codice></comune>
<comune><nome>Chiaramonti</nome><codice>C613</codice></comune>
<comune><nome>Chiarano</nome><codice>C614</codice></comune>
<comune><nome>Chiaravalle</nome><codice>C615</codice></comune>
<comune><nome>Chiaravalle Centrale</nome><codice>C616</codice></comune>
<comune><nome>Chiari</nome><codice>C618</codice></comune>
<comune><nome>Chiaromonte</nome><codice>C619</codice></comune>
<comune><nome>Chiauci</nome><codice>C620</codice></comune>
<comune><nome>Chiavari</nome><codice>C621</codice></comune>
<comune><nome>Chiavenna</nome><codice>C623</codice></comune>
<comune><nome>Chiaverano</nome><codice>C624</codice></comune>
<comune><nome>Chienes</nome><codice>C625</codice></comune>
<comune><nome>Chieri</nome><codice>C627</codice></comune>
<comune><nome>Chies d'Alpago</nome><codice>C630</codice></comune>
<comune><nome>Chiesa in Valmalenco</nome><codice>C628</codice></comune>
<comune><nome>Chiesanuova</nome><codice>C629</codice></comune>
<comune><nome>Chiesina Uzzanese</nome><codice>C631</codice></comune>
<comune><nome>Chieti</nome><codice>C632</codice></comune>
<comune><nome>Chieuti</nome><codice>C633</codice></comune>
<comune><nome>Chieve</nome><codice>C634</codice></comune>
<comune><nome>Chignolo d'Isola</nome><codice>C635</codice></comune>
<comune><nome>Chignolo Po</nome><codice>C637</codice></comune>
<comune><nome>Chioggia</nome><codice>C638</codice></comune>
<comune><nome>Chiomonte</nome><codice>C639</codice></comune>
<comune><nome>Chions</nome><codice>C640</codice></comune>
<comune><nome>Chiopris-Viscone</nome><codice>C641</codice></comune>
<comune><nome>Chitignano</nome><codice>C648</codice></comune>
<comune><nome>Chiuduno</nome><codice>C649</codice></comune>
<comune><nome>Chiuppano</nome><codice>C650</codice></comune>
<comune><nome>Chiuro</nome><codice>C651</codice></comune>
<comune><nome>Chiusa</nome><codice>C652</codice></comune>
<comune><nome>Chiusa di Pesio</nome><codice>C653</codice></comune>
<comune><nome>Chiusa di San Michele</nome><codice>C655</codice></comune>
<comune><nome>Chiusa Sclafani</nome><codice>C654</codice></comune>
<comune><nome>Chiusaforte</nome><codice>C656</codice></comune>
<comune><nome>Chiusanico</nome><codice>C657</codice></comune>
<comune><nome>Chiusano d'Asti</nome><codice>C658</codice></comune>
<comune><nome>Chiusano di San Domenico</nome><codice>C659</codice></comune>
<comune><nome>Chiusavecchia</nome><codice>C660</codice></comune>
<comune><nome>Chiusdino</nome><codice>C661</codice></comune>
<comune><nome>Chiusi</nome><codice>C662</codice></comune>
<comune><nome>Chiusi della Verna</nome><codice>C663</codice></comune>
<comune><nome>Chivasso</nome><codice>C665</codice></comune>
<comune><nome>Ciampino</nome><codice>M272</codice></comune>
<comune><nome>Cianciana</nome><codice>C668</codice></comune>
<comune><nome>Cibiana di Cadore</nome><codice>C672</codice></comune>
<comune><nome>Cicagna</nome><codice>C673</codice></comune>
<comune><nome>Cicala</nome><codice>C674</codice></comune>
<comune><nome>Cicciano</nome><codice>C675</codice></comune>
<comune><nome>Cicerale</nome><codice>C676</codice></comune>
<comune><nome>Ciciliano</nome><codice>C677</codice></comune>
<comune><nome>Cicognolo</nome><codice>C678</codice></comune>
<comune><nome>Ciconio</nome><codice>C679</codice></comune>
<comune><nome>Cigliano</nome><codice>C680</codice></comune>
<comune><nome>Cigliè</nome><codice>C681</codice></comune>
<comune><nome>Cigognola</nome><codice>C684</codice></comune>
<comune><nome>Cigole</nome><codice>C685</codice></comune>
<comune><nome>Cilavegna</nome><codice>C686</codice></comune>
<comune><nome>Cimadolmo</nome><codice>C689</codice></comune>
<comune><nome>Cimbergo</nome><codice>C691</codice></comune>
<comune><nome>Cimego</nome><codice>C694</codice></comune>
<comune><nome>Ciminà</nome><codice>C695</codice></comune>
<comune><nome>Ciminna</nome><codice>C696</codice></comune>
<comune><nome>Cimitile</nome><codice>C697</codice></comune>
<comune><nome>Cimolais</nome><codice>C699</codice></comune>
<comune><nome>Cimone</nome><codice>C700</codice></comune>
<comune><nome>Cinaglio</nome><codice>C701</codice></comune>
<comune><nome>Cineto Romano</nome><codice>C702</codice></comune>
<comune><nome>Cingia de' Botti</nome><codice>C703</codice></comune>
<comune><nome>Cingoli</nome><codice>C704</codice></comune>
<comune><nome>Cinigiano</nome><codice>C705</codice></comune>
<comune><nome>Cinisello Balsamo</nome><codice>C707</codice></comune>
<comune><nome>Cinisi</nome><codice>C708</codice></comune>
<comune><nome>Cino</nome><codice>C709</codice></comune>
<comune><nome>Cinquefrondi</nome><codice>C710</codice></comune>
<comune><nome>Cintano</nome><codice>C711</codice></comune>
<comune><nome>Cinte Tesino</nome><codice>C712</codice></comune>
<comune><nome>Cinto Caomaggiore</nome><codice>C714</codice></comune>
<comune><nome>Cinto Euganeo</nome><codice>C713</codice></comune>
<comune><nome>Cinzano</nome><codice>C715</codice></comune>
<comune><nome>Ciorlano</nome><codice>C716</codice></comune>
<comune><nome>Cipressa</nome><codice>C718</codice></comune>
<comune><nome>Circello</nome><codice>C719</codice></comune>
<comune><nome>Ciriè</nome><codice>C722</codice></comune>
<comune><nome>Cirigliano</nome><codice>C723</codice></comune>
<comune><nome>Cirimido</nome><codice>C724</codice></comune>
<comune><nome>Cirò</nome><codice>C725</codice></comune>
<comune><nome>Cirò Marina</nome><codice>C726</codice></comune>
<comune><nome>Cis</nome><codice>C727</codice></comune>
<comune><nome>Cisano Bergamasco</nome><codice>C728</codice></comune>
<comune><nome>Cisano sul Neva</nome><codice>C729</codice></comune>
<comune><nome>Ciserano</nome><codice>C730</codice></comune>
<comune><nome>Cislago</nome><codice>C732</codice></comune>
<comune><nome>Cisliano</nome><codice>C733</codice></comune>
<comune><nome>Cismon del Grappa</nome><codice>C734</codice></comune>
<comune><nome>Cison di Valmarino</nome><codice>C735</codice></comune>
<comune><nome>Cissone</nome><codice>C738</codice></comune>
<comune><nome>Cisterna d'Asti</nome><codice>C739</codice></comune>
<comune><nome>Cisterna di Latina</nome><codice>C740</codice></comune>
<comune><nome>Cisternino</nome><codice>C741</codice></comune>
<comune><nome>Citerna</nome><codice>C742</codice></comune>
<comune><nome>Città della Pieve</nome><codice>C744</codice></comune>
<comune><nome>Città di Castello</nome><codice>C745</codice></comune>
<comune><nome>Città Sant'Angelo</nome><codice>C750</codice></comune>
<comune><nome>Cittadella</nome><codice>C743</codice></comune>
<comune><nome>Cittaducale</nome><codice>C746</codice></comune>
<comune><nome>Cittanova</nome><codice>C747</codice></comune>
<comune><nome>Cittareale</nome><codice>C749</codice></comune>
<comune><nome>Cittiglio</nome><codice>C751</codice></comune>
<comune><nome>Civate</nome><codice>C752</codice></comune>
<comune><nome>Civenna</nome><codice>C754</codice></comune>
<comune><nome>Civezza</nome><codice>C755</codice></comune>
<comune><nome>Civezzano</nome><codice>C756</codice></comune>
<comune><nome>Civiasco</nome><codice>C757</codice></comune>
<comune><nome>Cividale del Friuli</nome><codice>C758</codice></comune>
<comune><nome>Cividate al Piano</nome><codice>C759</codice></comune>
<comune><nome>Cividate Camuno</nome><codice>C760</codice></comune>
<comune><nome>Civita</nome><codice>C763</codice></comune>
<comune><nome>Civita Castellana</nome><codice>C765</codice></comune>
<comune><nome>Civita d'Antino</nome><codice>C766</codice></comune>
<comune><nome>Civitacampomarano</nome><codice>C764</codice></comune>
<comune><nome>Civitaluparella</nome><codice>C768</codice></comune>
<comune><nome>Civitanova del Sannio</nome><codice>C769</codice></comune>
<comune><nome>Civitanova Marche</nome><codice>C770</codice></comune>
<comune><nome>Civitaquana</nome><codice>C771</codice></comune>
<comune><nome>Civitavecchia</nome><codice>C773</codice></comune>
<comune><nome>Civitella Alfedena</nome><codice>C778</codice></comune>
<comune><nome>Civitella Casanova</nome><codice>C779</codice></comune>
<comune><nome>Civitella d'Agliano</nome><codice>C780</codice></comune>
<comune><nome>Civitella del Tronto</nome><codice>C781</codice></comune>
<comune><nome>Civitella di Romagna</nome><codice>C777</codice></comune>
<comune><nome>Civitella in Val di Chiana</nome><codice>C774</codice></comune>
<comune><nome>Civitella Messer Raimondo</nome><codice>C776</codice></comune>
<comune><nome>Civitella Paganico</nome><codice>C782</codice></comune>
<comune><nome>Civitella Roveto</nome><codice>C783</codice></comune>
<comune><nome>Civitella San Paolo</nome><codice>C784</codice></comune>
<comune><nome>Civo</nome><codice>C785</codice></comune>
<comune><nome>Claino con Osteno</nome><codice>C787</codice></comune>
<comune><nome>Claut</nome><codice>C790</codice></comune>
<comune><nome>Clauzetto</nome><codice>C791</codice></comune>
<comune><nome>Clavesana</nome><codice>C792</codice></comune>
<comune><nome>Claviere</nome><codice>C793</codice></comune>
<comune><nome>Cles</nome><codice>C794</codice></comune>
<comune><nome>Cleto</nome><codice>C795</codice></comune>
<comune><nome>Clivio</nome><codice>C796</codice></comune>
<comune><nome>Cloz</nome><codice>C797</codice></comune>
<comune><nome>Clusone</nome><codice>C800</codice></comune>
<comune><nome>Coassolo Torinese</nome><codice>C801</codice></comune>
<comune><nome>Coazze</nome><codice>C803</codice></comune>
<comune><nome>Coazzolo</nome><codice>C804</codice></comune>
<comune><nome>Coccaglio</nome><codice>C806</codice></comune>
<comune><nome>Cocconato</nome><codice>C807</codice></comune>
<comune><nome>Cocquio-Trevisago</nome><codice>C810</codice></comune>
<comune><nome>Cocullo</nome><codice>C811</codice></comune>
<comune><nome>Codevigo</nome><codice>C812</codice></comune>
<comune><nome>Codevilla</nome><codice>C813</codice></comune>
<comune><nome>Codigoro</nome><codice>C814</codice></comune>
<comune><nome>Codognè</nome><codice>C815</codice></comune>
<comune><nome>Codogno</nome><codice>C816</codice></comune>
<comune><nome>Codroipo</nome><codice>C817</codice></comune>
<comune><nome>Codrongianos</nome><codice>C818</codice></comune>
<comune><nome>Coggiola</nome><codice>C819</codice></comune>
<comune><nome>Cogliate</nome><codice>C820</codice></comune>
<comune><nome>Cogne</nome><codice>C821</codice></comune>
<comune><nome>Cogoleto</nome><codice>C823</codice></comune>
<comune><nome>Cogollo del Cengio</nome><codice>C824</codice></comune>
<comune><nome>Cogorno</nome><codice>C826</codice></comune>
<comune><nome>Colazza</nome><codice>C829</codice></comune>
<comune><nome>Colbordolo</nome><codice>C830</codice></comune>
<comune><nome>Colere</nome><codice>C835</codice></comune>
<comune><nome>Colfelice</nome><codice>C836</codice></comune>
<comune><nome>Coli</nome><codice>C838</codice></comune>
<comune><nome>Colico</nome><codice>C839</codice></comune>
<comune><nome>Collagna</nome><codice>C840</codice></comune>
<comune><nome>Collalto Sabino</nome><codice>C841</codice></comune>
<comune><nome>Collarmele</nome><codice>C844</codice></comune>
<comune><nome>Collazzone</nome><codice>C845</codice></comune>
<comune><nome>Colle Brianza</nome><codice>C851</codice></comune>
<comune><nome>Colle d'Anchise</nome><codice>C854</codice></comune>
<comune><nome>Colle di Tora</nome><codice>C857</codice></comune>
<comune><nome>Colle di Val d'Elsa</nome><codice>C847</codice></comune>
<comune><nome>Colle San Magno</nome><codice>C870</codice></comune>
<comune><nome>Colle Sannita</nome><codice>C846</codice></comune>
<comune><nome>Colle Santa Lucia</nome><codice>C872</codice></comune>
<comune><nome>Colle Umberto</nome><codice>C848</codice></comune>
<comune><nome>Collebeato</nome><codice>C850</codice></comune>
<comune><nome>Collecchio</nome><codice>C852</codice></comune>
<comune><nome>Collecorvino</nome><codice>C853</codice></comune>
<comune><nome>Colledara</nome><codice>C311</codice></comune>
<comune><nome>Colledimacine</nome><codice>C855</codice></comune>
<comune><nome>Colledimezzo</nome><codice>C856</codice></comune>
<comune><nome>Colleferro</nome><codice>C858</codice></comune>
<comune><nome>Collegiove</nome><codice>C859</codice></comune>
<comune><nome>Collegno</nome><codice>C860</codice></comune>
<comune><nome>Collelongo</nome><codice>C862</codice></comune>
<comune><nome>Collepardo</nome><codice>C864</codice></comune>
<comune><nome>Collepasso</nome><codice>C865</codice></comune>
<comune><nome>Collepietro</nome><codice>C866</codice></comune>
<comune><nome>Colleretto Castelnuovo</nome><codice>C867</codice></comune>
<comune><nome>Colleretto Giacosa</nome><codice>C868</codice></comune>
<comune><nome>Collesalvetti</nome><codice>C869</codice></comune>
<comune><nome>Collesano</nome><codice>C871</codice></comune>
<comune><nome>Colletorto</nome><codice>C875</codice></comune>
<comune><nome>Collevecchio</nome><codice>C876</codice></comune>
<comune><nome>Colli a Volturno</nome><codice>C878</codice></comune>
<comune><nome>Colli del Tronto</nome><codice>C877</codice></comune>
<comune><nome>Colli sul Velino</nome><codice>C880</codice></comune>
<comune><nome>Colliano</nome><codice>C879</codice></comune>
<comune><nome>Collinas</nome><codice>C882</codice></comune>
<comune><nome>Collio</nome><codice>C883</codice></comune>
<comune><nome>Collobiano</nome><codice>C884</codice></comune>
<comune><nome>Colloredo di Monte Albano</nome><codice>C885</codice></comune>
<comune><nome>Colmurano</nome><codice>C886</codice></comune>
<comune><nome>Colobraro</nome><codice>C888</codice></comune>
<comune><nome>Cologna Veneta</nome><codice>C890</codice></comune>
<comune><nome>Cologne</nome><codice>C893</codice></comune>
<comune><nome>Cologno al Serio</nome><codice>C894</codice></comune>
<comune><nome>Cologno Monzese</nome><codice>C895</codice></comune>
<comune><nome>Colognola ai Colli</nome><codice>C897</codice></comune>
<comune><nome>Colonna</nome><codice>C900</codice></comune>
<comune><nome>Colonnella</nome><codice>C901</codice></comune>
<comune><nome>Colonno</nome><codice>C902</codice></comune>
<comune><nome>Colorina</nome><codice>C903</codice></comune>
<comune><nome>Colorno</nome><codice>C904</codice></comune>
<comune><nome>Colosimi</nome><codice>C905</codice></comune>
<comune><nome>Colturano</nome><codice>C908</codice></comune>
<comune><nome>Colzate</nome><codice>C910</codice></comune>
<comune><nome>Comabbio</nome><codice>C911</codice></comune>
<comune><nome>Comacchio</nome><codice>C912</codice></comune>
<comune><nome>Comano</nome><codice>C914</codice></comune>
<comune><nome>Comano Terme</nome><codice>M314</codice></comune>
<comune><nome>Comazzo</nome><codice>C917</codice></comune>
<comune><nome>Comeglians</nome><codice>C918</codice></comune>
<comune><nome>Comelico Superiore</nome><codice>C920</codice></comune>
<comune><nome>Comerio</nome><codice>C922</codice></comune>
<comune><nome>Comezzano-Cizzago</nome><codice>C925</codice></comune>
<comune><nome>Comignago</nome><codice>C926</codice></comune>
<comune><nome>Comiso</nome><codice>C927</codice></comune>
<comune><nome>Comitini</nome><codice>C928</codice></comune>
<comune><nome>Comiziano</nome><codice>C929</codice></comune>
<comune><nome>Commessaggio</nome><codice>C930</codice></comune>
<comune><nome>Commezzadura</nome><codice>C931</codice></comune>
<comune><nome>Como</nome><codice>C933</codice></comune>
<comune><nome>Compiano</nome><codice>C934</codice></comune>
<comune><nome>Comun Nuovo</nome><codice>C937</codice></comune>
<comune><nome>Comunanza</nome><codice>C935</codice></comune>
<comune><nome>Cona</nome><codice>C938</codice></comune>
<comune><nome>Conca Casale</nome><codice>C941</codice></comune>
<comune><nome>Conca dei Marini</nome><codice>C940</codice></comune>
<comune><nome>Conca della Campania</nome><codice>C939</codice></comune>
<comune><nome>Concamarise</nome><codice>C943</codice></comune>
<comune><nome>Concerviano</nome><codice>C946</codice></comune>
<comune><nome>Concesio</nome><codice>C948</codice></comune>
<comune><nome>Conco</nome><codice>C949</codice></comune>
<comune><nome>Concordia Sagittaria</nome><codice>C950</codice></comune>
<comune><nome>Concordia sulla Secchia</nome><codice>C951</codice></comune>
<comune><nome>Concorezzo</nome><codice>C952</codice></comune>
<comune><nome>Condino</nome><codice>C953</codice></comune>
<comune><nome>Condofuri</nome><codice>C954</codice></comune>
<comune><nome>Condove</nome><codice>C955</codice></comune>
<comune><nome>Condrò</nome><codice>C956</codice></comune>
<comune><nome>Conegliano</nome><codice>C957</codice></comune>
<comune><nome>Confienza</nome><codice>C958</codice></comune>
<comune><nome>Configni</nome><codice>C959</codice></comune>
<comune><nome>Conflenti</nome><codice>C960</codice></comune>
<comune><nome>Coniolo</nome><codice>C962</codice></comune>
<comune><nome>Conselice</nome><codice>C963</codice></comune>
<comune><nome>Conselve</nome><codice>C964</codice></comune>
<comune><nome>Contessa Entellina</nome><codice>C968</codice></comune>
<comune><nome>Contigliano</nome><codice>C969</codice></comune>
<comune><nome>Contrada</nome><codice>C971</codice></comune>
<comune><nome>Controguerra</nome><codice>C972</codice></comune>
<comune><nome>Controne</nome><codice>C973</codice></comune>
<comune><nome>Contursi Terme</nome><codice>C974</codice></comune>
<comune><nome>Conversano</nome><codice>C975</codice></comune>
<comune><nome>Conza della Campania</nome><codice>C976</codice></comune>
<comune><nome>Conzano</nome><codice>C977</codice></comune>
<comune><nome>Copertino</nome><codice>C978</codice></comune>
<comune><nome>Copiano</nome><codice>C979</codice></comune>
<comune><nome>Copparo</nome><codice>C980</codice></comune>
<comune><nome>Corana</nome><codice>C982</codice></comune>
<comune><nome>Corato</nome><codice>C983</codice></comune>
<comune><nome>Corbara</nome><codice>C984</codice></comune>
<comune><nome>Corbetta</nome><codice>C986</codice></comune>
<comune><nome>Corbola</nome><codice>C987</codice></comune>
<comune><nome>Corchiano</nome><codice>C988</codice></comune>
<comune><nome>Corciano</nome><codice>C990</codice></comune>
<comune><nome>Cordenons</nome><codice>C991</codice></comune>
<comune><nome>Cordignano</nome><codice>C992</codice></comune>
<comune><nome>Cordovado</nome><codice>C993</codice></comune>
<comune><nome>Coredo</nome><codice>C994</codice></comune>
<comune><nome>Coreglia Antelminelli</nome><codice>C996</codice></comune>
<comune><nome>Coreglia Ligure</nome><codice>C995</codice></comune>
<comune><nome>Coreno Ausonio</nome><codice>C998</codice></comune>
<comune><nome>Corfinio</nome><codice>C999</codice></comune>
<comune><nome>Cori</nome><codice>D003</codice></comune>
<comune><nome>Coriano</nome><codice>D004</codice></comune>
<comune><nome>Corigliano Calabro</nome><codice>D005</codice></comune>
<comune><nome>Corigliano d'Otranto</nome><codice>D006</codice></comune>
<comune><nome>Corinaldo</nome><codice>D007</codice></comune>
<comune><nome>Corio</nome><codice>D008</codice></comune>
<comune><nome>Corleone</nome><codice>D009</codice></comune>
<comune><nome>Corleto Monforte</nome><codice>D011</codice></comune>
<comune><nome>Corleto Perticara</nome><codice>D010</codice></comune>
<comune><nome>Cormano</nome><codice>D013</codice></comune>
<comune><nome>Cormons</nome><codice>D014</codice></comune>
<comune><nome>Corna Imagna</nome><codice>D015</codice></comune>
<comune><nome>Cornalba</nome><codice>D016</codice></comune>
<comune><nome>Cornale</nome><codice>D017</codice></comune>
<comune><nome>Cornaredo</nome><codice>D018</codice></comune>
<comune><nome>Cornate d'Adda</nome><codice>D019</codice></comune>
<comune><nome>Cornedo all'Isarco</nome><codice>B799</codice></comune>
<comune><nome>Cornedo Vicentino</nome><codice>D020</codice></comune>
<comune><nome>Cornegliano Laudense</nome><codice>D021</codice></comune>
<comune><nome>Corneliano d'Alba</nome><codice>D022</codice></comune>
<comune><nome>Corniglio</nome><codice>D026</codice></comune>
<comune><nome>Corno di Rosazzo</nome><codice>D027</codice></comune>
<comune><nome>Corno Giovine</nome><codice>D028</codice></comune>
<comune><nome>Cornovecchio</nome><codice>D029</codice></comune>
<comune><nome>Cornuda</nome><codice>D030</codice></comune>
<comune><nome>Correggio</nome><codice>D037</codice></comune>
<comune><nome>Correzzana</nome><codice>D038</codice></comune>
<comune><nome>Correzzola</nome><codice>D040</codice></comune>
<comune><nome>Corrido</nome><codice>D041</codice></comune>
<comune><nome>Corridonia</nome><codice>D042</codice></comune>
<comune><nome>Corropoli</nome><codice>D043</codice></comune>
<comune><nome>Corsano</nome><codice>D044</codice></comune>
<comune><nome>Corsico</nome><codice>D045</codice></comune>
<comune><nome>Corsione</nome><codice>D046</codice></comune>
<comune><nome>Cortaccia sulla Strada del Vino</nome><codice>D048</codice></comune>
<comune><nome>Cortale</nome><codice>D049</codice></comune>
<comune><nome>Cortandone</nome><codice>D050</codice></comune>
<comune><nome>Cortanze</nome><codice>D051</codice></comune>
<comune><nome>Cortazzone</nome><codice>D052</codice></comune>
<comune><nome>Corte Brugnatella</nome><codice>D054</codice></comune>
<comune><nome>Corte de' Cortesi con Cignone</nome><codice>D056</codice></comune>
<comune><nome>Corte de' Frati</nome><codice>D057</codice></comune>
<comune><nome>Corte Franca</nome><codice>D058</codice></comune>
<comune><nome>Corte Palasio</nome><codice>D068</codice></comune>
<comune><nome>Cortemaggiore</nome><codice>D061</codice></comune>
<comune><nome>Cortemilia</nome><codice>D062</codice></comune>
<comune><nome>Corteno Golgi</nome><codice>D064</codice></comune>
<comune><nome>Cortenova</nome><codice>D065</codice></comune>
<comune><nome>Cortenuova</nome><codice>D066</codice></comune>
<comune><nome>Corteolona</nome><codice>D067</codice></comune>
<comune><nome>Cortiglione</nome><codice>D072</codice></comune>
<comune><nome>Cortina d'Ampezzo</nome><codice>A266</codice></comune>
<comune><nome>Cortina sulla Strada del Vino</nome><codice>D075</codice></comune>
<comune><nome>Cortino</nome><codice>D076</codice></comune>
<comune><nome>Cortona</nome><codice>D077</codice></comune>
<comune><nome>Corvara</nome><codice>D078</codice></comune>
<comune><nome>Corvara in Badia</nome><codice>D079</codice></comune>
<comune><nome>Corvino San Quirico</nome><codice>D081</codice></comune>
<comune><nome>Corzano</nome><codice>D082</codice></comune>
<comune><nome>Coseano</nome><codice>D085</codice></comune>
<comune><nome>Cosenza</nome><codice>D086</codice></comune>
<comune><nome>Cosio d'Arroscia</nome><codice>D087</codice></comune>
<comune><nome>Cosio Valtellino</nome><codice>D088</codice></comune>
<comune><nome>Cosoleto</nome><codice>D089</codice></comune>
<comune><nome>Cossano Belbo</nome><codice>D093</codice></comune>
<comune><nome>Cossano Canavese</nome><codice>D092</codice></comune>
<comune><nome>Cossato</nome><codice>D094</codice></comune>
<comune><nome>Cosseria</nome><codice>D095</codice></comune>
<comune><nome>Cossignano</nome><codice>D096</codice></comune>
<comune><nome>Cossogno</nome><codice>D099</codice></comune>
<comune><nome>Cossoine</nome><codice>D100</codice></comune>
<comune><nome>Cossombrato</nome><codice>D101</codice></comune>
<comune><nome>Costa de' Nobili</nome><codice>D109</codice></comune>
<comune><nome>Costa di Mezzate</nome><codice>D110</codice></comune>
<comune><nome>Costa di Rovigo</nome><codice>D105</codice></comune>
<comune><nome>Costa Masnaga</nome><codice>D112</codice></comune>
<comune><nome>Costa Serina</nome><codice>D111</codice></comune>
<comune><nome>Costa Valle Imagna</nome><codice>D103</codice></comune>
<comune><nome>Costa Vescovato</nome><codice>D102</codice></comune>
<comune><nome>Costa Volpino</nome><codice>D117</codice></comune>
<comune><nome>Costabissara</nome><codice>D107</codice></comune>
<comune><nome>Costacciaro</nome><codice>D108</codice></comune>
<comune><nome>Costanzana</nome><codice>D113</codice></comune>
<comune><nome>Costarainera</nome><codice>D114</codice></comune>
<comune><nome>Costermano</nome><codice>D118</codice></comune>
<comune><nome>Costigliole d'Asti</nome><codice>D119</codice></comune>
<comune><nome>Costigliole Saluzzo</nome><codice>D120</codice></comune>
<comune><nome>Cotignola</nome><codice>D121</codice></comune>
<comune><nome>Cotronei</nome><codice>D123</codice></comune>
<comune><nome>Cottanello</nome><codice>D124</codice></comune>
<comune><nome>Courmayeur</nome><codice>D012</codice></comune>
<comune><nome>Covo</nome><codice>D126</codice></comune>
<comune><nome>Cozzo</nome><codice>D127</codice></comune>
<comune><nome>Craco</nome><codice>D128</codice></comune>
<comune><nome>Crandola Valsassina</nome><codice>D131</codice></comune>
<comune><nome>Cravagliana</nome><codice>D132</codice></comune>
<comune><nome>Cravanzana</nome><codice>D133</codice></comune>
<comune><nome>Craveggia</nome><codice>D134</codice></comune>
<comune><nome>Creazzo</nome><codice>D136</codice></comune>
<comune><nome>Crecchio</nome><codice>D137</codice></comune>
<comune><nome>Credaro</nome><codice>D139</codice></comune>
<comune><nome>Credera Rubbiano</nome><codice>D141</codice></comune>
<comune><nome>Crema</nome><codice>D142</codice></comune>
<comune><nome>Cremella</nome><codice>D143</codice></comune>
<comune><nome>Cremenaga</nome><codice>D144</codice></comune>
<comune><nome>Cremeno</nome><codice>D145</codice></comune>
<comune><nome>Cremia</nome><codice>D147</codice></comune>
<comune><nome>Cremolino</nome><codice>D149</codice></comune>
<comune><nome>Cremona</nome><codice>D150</codice></comune>
<comune><nome>Cremosano</nome><codice>D151</codice></comune>
<comune><nome>Crescentino</nome><codice>D154</codice></comune>
<comune><nome>Crespadoro</nome><codice>D156</codice></comune>
<comune><nome>Crespano del Grappa</nome><codice>D157</codice></comune>
<comune><nome>Crespellano</nome><codice>D158</codice></comune>
<comune><nome>Crespiatica</nome><codice>D159</codice></comune>
<comune><nome>Crespina</nome><codice>D160</codice></comune>
<comune><nome>Crespino</nome><codice>D161</codice></comune>
<comune><nome>Cressa</nome><codice>D162</codice></comune>
<comune><nome>Crevacuore</nome><codice>D165</codice></comune>
<comune><nome>Crevalcore</nome><codice>D166</codice></comune>
<comune><nome>Crevoladossola</nome><codice>D168</codice></comune>
<comune><nome>Crispano</nome><codice>D170</codice></comune>
<comune><nome>Crispiano</nome><codice>D171</codice></comune>
<comune><nome>Crissolo</nome><codice>D172</codice></comune>
<comune><nome>Crocefieschi</nome><codice>D175</codice></comune>
<comune><nome>Crocetta del Montello</nome><codice>C670</codice></comune>
<comune><nome>Crodo</nome><codice>D177</codice></comune>
<comune><nome>Crognaleto</nome><codice>D179</codice></comune>
<comune><nome>Cropalati</nome><codice>D180</codice></comune>
<comune><nome>Cropani</nome><codice>D181</codice></comune>
<comune><nome>Crosa</nome><codice>D182</codice></comune>
<comune><nome>Crosia</nome><codice>D184</codice></comune>
<comune><nome>Crosio della Valle</nome><codice>D185</codice></comune>
<comune><nome>Crotone</nome><codice>D122</codice></comune>
<comune><nome>Crotta d'Adda</nome><codice>D186</codice></comune>
<comune><nome>Crova</nome><codice>D187</codice></comune>
<comune><nome>Croviana</nome><codice>D188</codice></comune>
<comune><nome>Crucoli</nome><codice>D189</codice></comune>
<comune><nome>Cuasso al Monte</nome><codice>D192</codice></comune>
<comune><nome>Cuccaro Monferrato</nome><codice>D194</codice></comune>
<comune><nome>Cuccaro Vetere</nome><codice>D195</codice></comune>
<comune><nome>Cucciago</nome><codice>D196</codice></comune>
<comune><nome>Cuceglio</nome><codice>D197</codice></comune>
<comune><nome>Cuggiono</nome><codice>D198</codice></comune>
<comune><nome>Cugliate-Fabiasco</nome><codice>D199</codice></comune>
<comune><nome>Cuglieri</nome><codice>D200</codice></comune>
<comune><nome>Cugnoli</nome><codice>D201</codice></comune>
<comune><nome>Cumiana</nome><codice>D202</codice></comune>
<comune><nome>Cumignano sul Naviglio</nome><codice>D203</codice></comune>
<comune><nome>Cunardo</nome><codice>D204</codice></comune>
<comune><nome>Cuneo</nome><codice>D205</codice></comune>
<comune><nome>Cunevo</nome><codice>D206</codice></comune>
<comune><nome>Cunico</nome><codice>D207</codice></comune>
<comune><nome>Cuorgnè</nome><codice>D208</codice></comune>
<comune><nome>Cupello</nome><codice>D209</codice></comune>
<comune><nome>Cupra Marittima</nome><codice>D210</codice></comune>
<comune><nome>Cupramontana</nome><codice>D211</codice></comune>
<comune><nome>Cura Carpignano</nome><codice>B824</codice></comune>
<comune><nome>Curcuris</nome><codice>D214</codice></comune>
<comune><nome>Cureggio</nome><codice>D216</codice></comune>
<comune><nome>Curiglia con Monteviasco</nome><codice>D217</codice></comune>
<comune><nome>Curinga</nome><codice>D218</codice></comune>
<comune><nome>Curino</nome><codice>D219</codice></comune>
<comune><nome>Curno</nome><codice>D221</codice></comune>
<comune><nome>Curon Venosta</nome><codice>D222</codice></comune>
<comune><nome>Cursi</nome><codice>D223</codice></comune>
<comune><nome>Cursolo-Orasso</nome><codice>D225</codice></comune>
<comune><nome>Curtarolo</nome><codice>D226</codice></comune>
<comune><nome>Curtatone</nome><codice>D227</codice></comune>
<comune><nome>Curti</nome><codice>D228</codice></comune>
<comune><nome>Cusago</nome><codice>D229</codice></comune>
<comune><nome>Cusano Milanino</nome><codice>D231</codice></comune>
<comune><nome>Cusano Mutri</nome><codice>D230</codice></comune>
<comune><nome>Cusino</nome><codice>D232</codice></comune>
<comune><nome>Cusio</nome><codice>D233</codice></comune>
<comune><nome>Custonaci</nome><codice>D234</codice></comune>
<comune><nome>Cutigliano</nome><codice>D235</codice></comune>
<comune><nome>Cutro</nome><codice>D236</codice></comune>
<comune><nome>Cutrofiano</nome><codice>D237</codice></comune>
<comune><nome>Cuveglio</nome><codice>D238</codice></comune>
<comune><nome>Cuvio</nome><codice>D239</codice></comune>
<comune><nome>Daiano</nome><codice>D243</codice></comune>
<comune><nome>Dairago</nome><codice>D244</codice></comune>
<comune><nome>Dalmine</nome><codice>D245</codice></comune>
<comune><nome>Dambel</nome><codice>D246</codice></comune>
<comune><nome>Danta di Cadore</nome><codice>D247</codice></comune>
<comune><nome>Daone</nome><codice>D248</codice></comune>
<comune><nome>Darè</nome><codice>D250</codice></comune>
<comune><nome>Darfo Boario Terme</nome><codice>D251</codice></comune>
<comune><nome>Dasà</nome><codice>D253</codice></comune>
<comune><nome>Davagna</nome><codice>D255</codice></comune>
<comune><nome>Daverio</nome><codice>D256</codice></comune>
<comune><nome>Davoli</nome><codice>D257</codice></comune>
<comune><nome>Dazio</nome><codice>D258</codice></comune>
<comune><nome>Decimomannu</nome><codice>D259</codice></comune>
<comune><nome>Decimoputzu</nome><codice>D260</codice></comune>
<comune><nome>Decollatura</nome><codice>D261</codice></comune>
<comune><nome>Dego</nome><codice>D264</codice></comune>
<comune><nome>Deiva Marina</nome><codice>D265</codice></comune>
<comune><nome>Delebio</nome><codice>D266</codice></comune>
<comune><nome>Delia</nome><codice>D267</codice></comune>
<comune><nome>Delianuova</nome><codice>D268</codice></comune>
<comune><nome>Deliceto</nome><codice>D269</codice></comune>
<comune><nome>Dello</nome><codice>D270</codice></comune>
<comune><nome>Demonte</nome><codice>D271</codice></comune>
<comune><nome>Denice</nome><codice>D272</codice></comune>
<comune><nome>Denno</nome><codice>D273</codice></comune>
<comune><nome>Dernice</nome><codice>D277</codice></comune>
<comune><nome>Derovere</nome><codice>D278</codice></comune>
<comune><nome>Deruta</nome><codice>D279</codice></comune>
<comune><nome>Dervio</nome><codice>D280</codice></comune>
<comune><nome>Desana</nome><codice>D281</codice></comune>
<comune><nome>Desenzano del Garda</nome><codice>D284</codice></comune>
<comune><nome>Desio</nome><codice>D286</codice></comune>
<comune><nome>Desulo</nome><codice>D287</codice></comune>
<comune><nome>Diamante</nome><codice>D289</codice></comune>
<comune><nome>Diano Arentino</nome><codice>D293</codice></comune>
<comune><nome>Diano Castello</nome><codice>D296</codice></comune>
<comune><nome>Diano d'Alba</nome><codice>D291</codice></comune>
<comune><nome>Diano Marina</nome><codice>D297</codice></comune>
<comune><nome>Diano San Pietro</nome><codice>D298</codice></comune>
<comune><nome>Dicomano</nome><codice>D299</codice></comune>
<comune><nome>Dignano</nome><codice>D300</codice></comune>
<comune><nome>Dimaro</nome><codice>D302</codice></comune>
<comune><nome>Dinami</nome><codice>D303</codice></comune>
<comune><nome>Dipignano</nome><codice>D304</codice></comune>
<comune><nome>Diso</nome><codice>D305</codice></comune>
<comune><nome>Divignano</nome><codice>D309</codice></comune>
<comune><nome>Dizzasco</nome><codice>D310</codice></comune>
<comune><nome>Dobbiaco</nome><codice>D311</codice></comune>
<comune><nome>Doberdò del Lago</nome><codice>D312</codice></comune>
<comune><nome>Dogliani</nome><codice>D314</codice></comune>
<comune><nome>Dogliola</nome><codice>D315</codice></comune>
<comune><nome>Dogna</nome><codice>D316</codice></comune>
<comune><nome>Dolcè</nome><codice>D317</codice></comune>
<comune><nome>Dolceacqua</nome><codice>D318</codice></comune>
<comune><nome>Dolcedo</nome><codice>D319</codice></comune>
<comune><nome>Dolegna del Collio</nome><codice>D321</codice></comune>
<comune><nome>Dolianova</nome><codice>D323</codice></comune>
<comune><nome>Dolo</nome><codice>D325</codice></comune>
<comune><nome>Dolzago</nome><codice>D327</codice></comune>
<comune><nome>Domanico</nome><codice>D328</codice></comune>
<comune><nome>Domaso</nome><codice>D329</codice></comune>
<comune><nome>Domegge di Cadore</nome><codice>D330</codice></comune>
<comune><nome>Domicella</nome><codice>D331</codice></comune>
<comune><nome>Domodossola</nome><codice>D332</codice></comune>
<comune><nome>Domus De Maria</nome><codice>D333</codice></comune>
<comune><nome>Domusnovas</nome><codice>D334</codice></comune>
<comune><nome>Don</nome><codice>D336</codice></comune>
<comune><nome>Donato</nome><codice>D339</codice></comune>
<comune><nome>Dongo</nome><codice>D341</codice></comune>
<comune><nome>Donnas</nome><codice>D338</codice></comune>
<comune><nome>Donori</nome><codice>D344</codice></comune>
<comune><nome>Dorgali</nome><codice>D345</codice></comune>
<comune><nome>Dorio</nome><codice>D346</codice></comune>
<comune><nome>Dormelletto</nome><codice>D347</codice></comune>
<comune><nome>Dorno</nome><codice>D348</codice></comune>
<comune><nome>Dorsino</nome><codice>D349</codice></comune>
<comune><nome>Dorzano</nome><codice>D350</codice></comune>
<comune><nome>Dosolo</nome><codice>D351</codice></comune>
<comune><nome>Dossena</nome><codice>D352</codice></comune>
<comune><nome>Dosso del Liro</nome><codice>D355</codice></comune>
<comune><nome>Doues</nome><codice>D356</codice></comune>
<comune><nome>Dovadola</nome><codice>D357</codice></comune>
<comune><nome>Dovera</nome><codice>D358</codice></comune>
<comune><nome>Dozza</nome><codice>D360</codice></comune>
<comune><nome>Dragoni</nome><codice>D361</codice></comune>
<comune><nome>Drapia</nome><codice>D364</codice></comune>
<comune><nome>Drena</nome><codice>D365</codice></comune>
<comune><nome>Drenchia</nome><codice>D366</codice></comune>
<comune><nome>Dresano</nome><codice>D367</codice></comune>
<comune><nome>Drezzo</nome><codice>D369</codice></comune>
<comune><nome>Drizzona</nome><codice>D370</codice></comune>
<comune><nome>Dro</nome><codice>D371</codice></comune>
<comune><nome>Dronero</nome><codice>D372</codice></comune>
<comune><nome>Druento</nome><codice>D373</codice></comune>
<comune><nome>Druogno</nome><codice>D374</codice></comune>
<comune><nome>Dualchi</nome><codice>D376</codice></comune>
<comune><nome>Dubino</nome><codice>D377</codice></comune>
<comune><nome>Due Carrare</nome><codice>M300</codice></comune>
<comune><nome>Dueville</nome><codice>D379</codice></comune>
<comune><nome>Dugenta</nome><codice>D380</codice></comune>
<comune><nome>Duino-Aurisina</nome><codice>D383</codice></comune>
<comune><nome>Dumenza</nome><codice>D384</codice></comune>
<comune><nome>Duno</nome><codice>D385</codice></comune>
<comune><nome>Durazzano</nome><codice>D386</codice></comune>
<comune><nome>Duronia</nome><codice>C772</codice></comune>
<comune><nome>Dusino San Michele</nome><codice>D388</codice></comune>
<comune><nome>Eboli</nome><codice>D390</codice></comune>
<comune><nome>Edolo</nome><codice>D391</codice></comune>
<comune><nome>Egna</nome><codice>D392</codice></comune>
<comune><nome>Elice</nome><codice>D394</codice></comune>
<comune><nome>Elini</nome><codice>D395</codice></comune>
<comune><nome>Ello</nome><codice>D398</codice></comune>
<comune><nome>Elmas</nome><codice>D399</codice></comune>
<comune><nome>Elva</nome><codice>D401</codice></comune>
<comune><nome>Emarèse</nome><codice>D402</codice></comune>
<comune><nome>Empoli</nome><codice>D403</codice></comune>
<comune><nome>Endine Gaiano</nome><codice>D406</codice></comune>
<comune><nome>Enego</nome><codice>D407</codice></comune>
<comune><nome>Enemonzo</nome><codice>D408</codice></comune>
<comune><nome>Enna</nome><codice>C342</codice></comune>
<comune><nome>Entracque</nome><codice>D410</codice></comune>
<comune><nome>Entratico</nome><codice>D411</codice></comune>
<comune><nome>Envie</nome><codice>D412</codice></comune>
<comune><nome>Episcopia</nome><codice>D414</codice></comune>
<comune><nome>Eraclea</nome><codice>D415</codice></comune>
<comune><nome>Erba</nome><codice>D416</codice></comune>
<comune><nome>Erbè</nome><codice>D419</codice></comune>
<comune><nome>Erbezzo</nome><codice>D420</codice></comune>
<comune><nome>Erbusco</nome><codice>D421</codice></comune>
<comune><nome>Erchie</nome><codice>D422</codice></comune>
<comune><nome>Ercolano</nome><codice>H243</codice></comune>
<comune><nome>Erice</nome><codice>D423</codice></comune>
<comune><nome>Erli</nome><codice>D424</codice></comune>
<comune><nome>Erto e Casso</nome><codice>D426</codice></comune>
<comune><nome>Erula</nome><codice>M292</codice></comune>
<comune><nome>Erve</nome><codice>D428</codice></comune>
<comune><nome>Esanatoglia</nome><codice>D429</codice></comune>
<comune><nome>Escalaplano</nome><codice>D430</codice></comune>
<comune><nome>Escolca</nome><codice>D431</codice></comune>
<comune><nome>Esine</nome><codice>D434</codice></comune>
<comune><nome>Esino Lario</nome><codice>D436</codice></comune>
<comune><nome>Esperia</nome><codice>D440</codice></comune>
<comune><nome>Esporlatu</nome><codice>D441</codice></comune>
<comune><nome>Este</nome><codice>D442</codice></comune>
<comune><nome>Esterzili</nome><codice>D443</codice></comune>
<comune><nome>Etroubles</nome><codice>D444</codice></comune>
<comune><nome>Eupilio</nome><codice>D445</codice></comune>
<comune><nome>Exilles</nome><codice>D433</codice></comune>
<comune><nome>Fabbrica Curone</nome><codice>D447</codice></comune>
<comune><nome>Fabbriche di Vallico</nome><codice>D449</codice></comune>
<comune><nome>Fabbrico</nome><codice>D450</codice></comune>
<comune><nome>Fabriano</nome><codice>D451</codice></comune>
<comune><nome>Fabrica di Roma</nome><codice>D452</codice></comune>
<comune><nome>Fabrizia</nome><codice>D453</codice></comune>
<comune><nome>Fabro</nome><codice>D454</codice></comune>
<comune><nome>Faedis</nome><codice>D455</codice></comune>
<comune><nome>Faedo</nome><codice>D457</codice></comune>
<comune><nome>Faedo Valtellino</nome><codice>D456</codice></comune>
<comune><nome>Faenza</nome><codice>D458</codice></comune>
<comune><nome>Faeto</nome><codice>D459</codice></comune>
<comune><nome>Fagagna</nome><codice>D461</codice></comune>
<comune><nome>Faggeto Lario</nome><codice>D462</codice></comune>
<comune><nome>Faggiano</nome><codice>D463</codice></comune>
<comune><nome>Fagnano Alto</nome><codice>D465</codice></comune>
<comune><nome>Fagnano Castello</nome><codice>D464</codice></comune>
<comune><nome>Fagnano Olona</nome><codice>D467</codice></comune>
<comune><nome>Fai della Paganella</nome><codice>D468</codice></comune>
<comune><nome>Faicchio</nome><codice>D469</codice></comune>
<comune><nome>Falcade</nome><codice>D470</codice></comune>
<comune><nome>Falciano del Massico</nome><codice>D471</codice></comune>
<comune><nome>Falconara Albanese</nome><codice>D473</codice></comune>
<comune><nome>Falconara Marittima</nome><codice>D472</codice></comune>
<comune><nome>Falcone</nome><codice>D474</codice></comune>
<comune><nome>Faleria</nome><codice>D475</codice></comune>
<comune><nome>Falerna</nome><codice>D476</codice></comune>
<comune><nome>Falerone</nome><codice>D477</codice></comune>
<comune><nome>Fallo</nome><codice>D480</codice></comune>
<comune><nome>Falmenta</nome><codice>D481</codice></comune>
<comune><nome>Faloppio</nome><codice>D482</codice></comune>
<comune><nome>Falvaterra</nome><codice>D483</codice></comune>
<comune><nome>Falzes</nome><codice>D484</codice></comune>
<comune><nome>Fanano</nome><codice>D486</codice></comune>
<comune><nome>Fanna</nome><codice>D487</codice></comune>
<comune><nome>Fano</nome><codice>D488</codice></comune>
<comune><nome>Fano Adriano</nome><codice>D489</codice></comune>
<comune><nome>Fara Filiorum Petri</nome><codice>D494</codice></comune>
<comune><nome>Fara Gera d'Adda</nome><codice>D490</codice></comune>
<comune><nome>Fara in Sabina</nome><codice>D493</codice></comune>
<comune><nome>Fara Novarese</nome><codice>D492</codice></comune>
<comune><nome>Fara Olivana con Sola</nome><codice>D491</codice></comune>
<comune><nome>Fara San Martino</nome><codice>D495</codice></comune>
<comune><nome>Fara Vicentino</nome><codice>D496</codice></comune>
<comune><nome>Fardella</nome><codice>D497</codice></comune>
<comune><nome>Farigliano</nome><codice>D499</codice></comune>
<comune><nome>Farindola</nome><codice>D501</codice></comune>
<comune><nome>Farini</nome><codice>D502</codice></comune>
<comune><nome>Farnese</nome><codice>D503</codice></comune>
<comune><nome>Farra d'Alpago</nome><codice>D506</codice></comune>
<comune><nome>Farra di Soligo</nome><codice>D505</codice></comune>
<comune><nome>Farra d'Isonzo</nome><codice>D504</codice></comune>
<comune><nome>Fasano</nome><codice>D508</codice></comune>
<comune><nome>Fascia</nome><codice>D509</codice></comune>
<comune><nome>Fauglia</nome><codice>D510</codice></comune>
<comune><nome>Faule</nome><codice>D511</codice></comune>
<comune><nome>Favale di Malvaro</nome><codice>D512</codice></comune>
<comune><nome>Favara</nome><codice>D514</codice></comune>
<comune><nome>Faver</nome><codice>D516</codice></comune>
<comune><nome>Favignana</nome><codice>D518</codice></comune>
<comune><nome>Favria</nome><codice>D520</codice></comune>
<comune><nome>Feisoglio</nome><codice>D523</codice></comune>
<comune><nome>Feletto</nome><codice>D524</codice></comune>
<comune><nome>Felino</nome><codice>D526</codice></comune>
<comune><nome>Felitto</nome><codice>D527</codice></comune>
<comune><nome>Felizzano</nome><codice>D528</codice></comune>
<comune><nome>Felonica</nome><codice>D529</codice></comune>
<comune><nome>Feltre</nome><codice>D530</codice></comune>
<comune><nome>Fenegrò</nome><codice>D531</codice></comune>
<comune><nome>Fenestrelle</nome><codice>D532</codice></comune>
<comune><nome>Fénis</nome><codice>D537</codice></comune>
<comune><nome>Ferentillo</nome><codice>D538</codice></comune>
<comune><nome>Ferentino</nome><codice>D539</codice></comune>
<comune><nome>Ferla</nome><codice>D540</codice></comune>
<comune><nome>Fermignano</nome><codice>D541</codice></comune>
<comune><nome>Fermo</nome><codice>D542</codice></comune>
<comune><nome>Ferno</nome><codice>D543</codice></comune>
<comune><nome>Feroleto Antico</nome><codice>D544</codice></comune>
<comune><nome>Feroleto della Chiesa</nome><codice>D545</codice></comune>
<comune><nome>Ferrandina</nome><codice>D547</codice></comune>
<comune><nome>Ferrara</nome><codice>D548</codice></comune>
<comune><nome>Ferrara di Monte Baldo</nome><codice>D549</codice></comune>
<comune><nome>Ferrazzano</nome><codice>D550</codice></comune>
<comune><nome>Ferrera di Varese</nome><codice>D551</codice></comune>
<comune><nome>Ferrera Erbognone</nome><codice>D552</codice></comune>
<comune><nome>Ferrere</nome><codice>D554</codice></comune>
<comune><nome>Ferriere</nome><codice>D555</codice></comune>
<comune><nome>Ferruzzano</nome><codice>D557</codice></comune>
<comune><nome>Fiamignano</nome><codice>D560</codice></comune>
<comune><nome>Fiano</nome><codice>D562</codice></comune>
<comune><nome>Fiano Romano</nome><codice>D561</codice></comune>
<comune><nome>Fiastra</nome><codice>D564</codice></comune>
<comune><nome>Fiavè</nome><codice>D565</codice></comune>
<comune><nome>Ficarazzi</nome><codice>D567</codice></comune>
<comune><nome>Ficarolo</nome><codice>D568</codice></comune>
<comune><nome>Ficarra</nome><codice>D569</codice></comune>
<comune><nome>Ficulle</nome><codice>D570</codice></comune>
<comune><nome>Fidenza</nome><codice>B034</codice></comune>
<comune><nome>Fiè allo Sciliar</nome><codice>D571</codice></comune>
<comune><nome>Fiera di Primiero</nome><codice>D572</codice></comune>
<comune><nome>Fierozzo</nome><codice>D573</codice></comune>
<comune><nome>Fiesco</nome><codice>D574</codice></comune>
<comune><nome>Fiesole</nome><codice>D575</codice></comune>
<comune><nome>Fiesse</nome><codice>D576</codice></comune>
<comune><nome>Fiesso d'Artico</nome><codice>D578</codice></comune>
<comune><nome>Fiesso Umbertiano</nome><codice>D577</codice></comune>
<comune><nome>Figino Serenza</nome><codice>D579</codice></comune>
<comune><nome>Figline Valdarno</nome><codice>D583</codice></comune>
<comune><nome>Figline Vegliaturo</nome><codice>D582</codice></comune>
<comune><nome>Filacciano</nome><codice>D586</codice></comune>
<comune><nome>Filadelfia</nome><codice>D587</codice></comune>
<comune><nome>Filago</nome><codice>D588</codice></comune>
<comune><nome>Filandari</nome><codice>D589</codice></comune>
<comune><nome>Filattiera</nome><codice>D590</codice></comune>
<comune><nome>Filettino</nome><codice>D591</codice></comune>
<comune><nome>Filetto</nome><codice>D592</codice></comune>
<comune><nome>Filiano</nome><codice>D593</codice></comune>
<comune><nome>Filighera</nome><codice>D594</codice></comune>
<comune><nome>Filignano</nome><codice>D595</codice></comune>
<comune><nome>Filogaso</nome><codice>D596</codice></comune>
<comune><nome>Filottrano</nome><codice>D597</codice></comune>
<comune><nome>Finale Emilia</nome><codice>D599</codice></comune>
<comune><nome>Finale Ligure</nome><codice>D600</codice></comune>
<comune><nome>Fino del Monte</nome><codice>D604</codice></comune>
<comune><nome>Fino Mornasco</nome><codice>D605</codice></comune>
<comune><nome>Fiorano al Serio</nome><codice>D606</codice></comune>
<comune><nome>Fiorano Canavese</nome><codice>D608</codice></comune>
<comune><nome>Fiorano Modenese</nome><codice>D607</codice></comune>
<comune><nome>Fiordimonte</nome><codice>D609</codice></comune>
<comune><nome>Fiorenzuola d'Arda</nome><codice>D611</codice></comune>
<comune><nome>Firenze</nome><codice>D612</codice></comune>
<comune><nome>Firenzuola</nome><codice>D613</codice></comune>
<comune><nome>Firmo</nome><codice>D614</codice></comune>
<comune><nome>Fisciano</nome><codice>D615</codice></comune>
<comune><nome>Fiuggi</nome><codice>A310</codice></comune>
<comune><nome>Fiumalbo</nome><codice>D617</codice></comune>
<comune><nome>Fiumara</nome><codice>D619</codice></comune>
<comune><nome>Fiume Veneto</nome><codice>D621</codice></comune>
<comune><nome>Fiumedinisi</nome><codice>D622</codice></comune>
<comune><nome>Fiumefreddo Bruzio</nome><codice>D624</codice></comune>
<comune><nome>Fiumefreddo di Sicilia</nome><codice>D623</codice></comune>
<comune><nome>Fiumicello</nome><codice>D627</codice></comune>
<comune><nome>Fiumicino</nome><codice>M297</codice></comune>
<comune><nome>Fiuminata</nome><codice>D628</codice></comune>
<comune><nome>Fivizzano</nome><codice>D629</codice></comune>
<comune><nome>Flaibano</nome><codice>D630</codice></comune>
<comune><nome>Flavon</nome><codice>D631</codice></comune>
<comune><nome>Flero</nome><codice>D634</codice></comune>
<comune><nome>Floresta</nome><codice>D635</codice></comune>
<comune><nome>Floridia</nome><codice>D636</codice></comune>
<comune><nome>Florinas</nome><codice>D637</codice></comune>
<comune><nome>Flumeri</nome><codice>D638</codice></comune>
<comune><nome>Fluminimaggiore</nome><codice>D639</codice></comune>
<comune><nome>Flussio</nome><codice>D640</codice></comune>
<comune><nome>Fobello</nome><codice>D641</codice></comune>
<comune><nome>Foggia</nome><codice>D643</codice></comune>
<comune><nome>Foglianise</nome><codice>D644</codice></comune>
<comune><nome>Fogliano Redipuglia</nome><codice>D645</codice></comune>
<comune><nome>Foglizzo</nome><codice>D646</codice></comune>
<comune><nome>Foiano della Chiana</nome><codice>D649</codice></comune>
<comune><nome>Foiano di Val Fortore</nome><codice>D650</codice></comune>
<comune><nome>Folgaria</nome><codice>D651</codice></comune>
<comune><nome>Folignano</nome><codice>D652</codice></comune>
<comune><nome>Foligno</nome><codice>D653</codice></comune>
<comune><nome>Follina</nome><codice>D654</codice></comune>
<comune><nome>Follo</nome><codice>D655</codice></comune>
<comune><nome>Follonica</nome><codice>D656</codice></comune>
<comune><nome>Fombio</nome><codice>D660</codice></comune>
<comune><nome>Fondachelli-Fantina</nome><codice>D661</codice></comune>
<comune><nome>Fondi</nome><codice>D662</codice></comune>
<comune><nome>Fondo</nome><codice>D663</codice></comune>
<comune><nome>Fonni</nome><codice>D665</codice></comune>
<comune><nome>Fontainemore</nome><codice>D666</codice></comune>
<comune><nome>Fontana Liri</nome><codice>D667</codice></comune>
<comune><nome>Fontanafredda</nome><codice>D670</codice></comune>
<comune><nome>Fontanarosa</nome><codice>D671</codice></comune>
<comune><nome>Fontanelice</nome><codice>D668</codice></comune>
<comune><nome>Fontanella</nome><codice>D672</codice></comune>
<comune><nome>Fontanellato</nome><codice>D673</codice></comune>
<comune><nome>Fontanelle</nome><codice>D674</codice></comune>
<comune><nome>Fontaneto d'Agogna</nome><codice>D675</codice></comune>
<comune><nome>Fontanetto Po</nome><codice>D676</codice></comune>
<comune><nome>Fontanigorda</nome><codice>D677</codice></comune>
<comune><nome>Fontanile</nome><codice>D678</codice></comune>
<comune><nome>Fontaniva</nome><codice>D679</codice></comune>
<comune><nome>Fonte</nome><codice>D680</codice></comune>
<comune><nome>Fonte Nuova</nome><codice>M309</codice></comune>
<comune><nome>Fontecchio</nome><codice>D681</codice></comune>
<comune><nome>Fontechiari</nome><codice>D682</codice></comune>
<comune><nome>Fontegreca</nome><codice>D683</codice></comune>
<comune><nome>Fonteno</nome><codice>D684</codice></comune>
<comune><nome>Fontevivo</nome><codice>D685</codice></comune>
<comune><nome>Fonzaso</nome><codice>D686</codice></comune>
<comune><nome>Foppolo</nome><codice>D688</codice></comune>
<comune><nome>Forano</nome><codice>D689</codice></comune>
<comune><nome>Force</nome><codice>D691</codice></comune>
<comune><nome>Forchia</nome><codice>D693</codice></comune>
<comune><nome>Forcola</nome><codice>D694</codice></comune>
<comune><nome>Fordongianus</nome><codice>D695</codice></comune>
<comune><nome>Forenza</nome><codice>D696</codice></comune>
<comune><nome>Foresto Sparso</nome><codice>D697</codice></comune>
<comune><nome>Forgaria nel Friuli</nome><codice>D700</codice></comune>
<comune><nome>Forino</nome><codice>D701</codice></comune>
<comune><nome>Forio</nome><codice>D702</codice></comune>
<comune><nome>Forlì</nome><codice>D704</codice></comune>
<comune><nome>Forlì del Sannio</nome><codice>D703</codice></comune>
<comune><nome>Forlimpopoli</nome><codice>D705</codice></comune>
<comune><nome>Formazza</nome><codice>D706</codice></comune>
<comune><nome>Formello</nome><codice>D707</codice></comune>
<comune><nome>Formia</nome><codice>D708</codice></comune>
<comune><nome>Formicola</nome><codice>D709</codice></comune>
<comune><nome>Formigara</nome><codice>D710</codice></comune>
<comune><nome>Formigine</nome><codice>D711</codice></comune>
<comune><nome>Formigliana</nome><codice>D712</codice></comune>
<comune><nome>Formignana</nome><codice>D713</codice></comune>
<comune><nome>Fornace</nome><codice>D714</codice></comune>
<comune><nome>Fornelli</nome><codice>D715</codice></comune>
<comune><nome>Forni Avoltri</nome><codice>D718</codice></comune>
<comune><nome>Forni di Sopra</nome><codice>D719</codice></comune>
<comune><nome>Forni di Sotto</nome><codice>D720</codice></comune>
<comune><nome>Forno Canavese</nome><codice>D725</codice></comune>
<comune><nome>Forno di Zoldo</nome><codice>D726</codice></comune>
<comune><nome>Fornovo di Taro</nome><codice>D728</codice></comune>
<comune><nome>Fornovo San Giovanni</nome><codice>D727</codice></comune>
<comune><nome>Forte dei Marmi</nome><codice>D730</codice></comune>
<comune><nome>Fortezza</nome><codice>D731</codice></comune>
<comune><nome>Fortunago</nome><codice>D732</codice></comune>
<comune><nome>Forza d'Agrò</nome><codice>D733</codice></comune>
<comune><nome>Fosciandora</nome><codice>D734</codice></comune>
<comune><nome>Fosdinovo</nome><codice>D735</codice></comune>
<comune><nome>Fossa</nome><codice>D736</codice></comune>
<comune><nome>Fossacesia</nome><codice>D738</codice></comune>
<comune><nome>Fossalta di Piave</nome><codice>D740</codice></comune>
<comune><nome>Fossalta di Portogruaro</nome><codice>D741</codice></comune>
<comune><nome>Fossalto</nome><codice>D737</codice></comune>
<comune><nome>Fossano</nome><codice>D742</codice></comune>
<comune><nome>Fossato di Vico</nome><codice>D745</codice></comune>
<comune><nome>Fossato Serralta</nome><codice>D744</codice></comune>
<comune><nome>Fossò</nome><codice>D748</codice></comune>
<comune><nome>Fossombrone</nome><codice>D749</codice></comune>
<comune><nome>Foza</nome><codice>D750</codice></comune>
<comune><nome>Frabosa Soprana</nome><codice>D751</codice></comune>
<comune><nome>Frabosa Sottana</nome><codice>D752</codice></comune>
<comune><nome>Fraconalto</nome><codice>D559</codice></comune>
<comune><nome>Fragagnano</nome><codice>D754</codice></comune>
<comune><nome>Fragneto L'Abate</nome><codice>D755</codice></comune>
<comune><nome>Fragneto Monforte</nome><codice>D756</codice></comune>
<comune><nome>Fraine</nome><codice>D757</codice></comune>
<comune><nome>Framura</nome><codice>D758</codice></comune>
<comune><nome>Francavilla al Mare</nome><codice>D763</codice></comune>
<comune><nome>Francavilla Angitola</nome><codice>D762</codice></comune>
<comune><nome>Francavilla Bisio</nome><codice>D759</codice></comune>
<comune><nome>Francavilla d'Ete</nome><codice>D760</codice></comune>
<comune><nome>Francavilla di Sicilia</nome><codice>D765</codice></comune>
<comune><nome>Francavilla Fontana</nome><codice>D761</codice></comune>
<comune><nome>Francavilla in Sinni</nome><codice>D766</codice></comune>
<comune><nome>Francavilla Marittima</nome><codice>D764</codice></comune>
<comune><nome>Francica</nome><codice>D767</codice></comune>
<comune><nome>Francofonte</nome><codice>D768</codice></comune>
<comune><nome>Francolise</nome><codice>D769</codice></comune>
<comune><nome>Frascaro</nome><codice>D770</codice></comune>
<comune><nome>Frascarolo</nome><codice>D771</codice></comune>
<comune><nome>Frascati</nome><codice>D773</codice></comune>
<comune><nome>Frascineto</nome><codice>D774</codice></comune>
<comune><nome>Frassilongo</nome><codice>D775</codice></comune>
<comune><nome>Frassinelle Polesine</nome><codice>D776</codice></comune>
<comune><nome>Frassinello Monferrato</nome><codice>D777</codice></comune>
<comune><nome>Frassineto Po</nome><codice>D780</codice></comune>
<comune><nome>Frassinetto</nome><codice>D781</codice></comune>
<comune><nome>Frassino</nome><codice>D782</codice></comune>
<comune><nome>Frassinoro</nome><codice>D783</codice></comune>
<comune><nome>Frasso Sabino</nome><codice>D785</codice></comune>
<comune><nome>Frasso Telesino</nome><codice>D784</codice></comune>
<comune><nome>Fratta Polesine</nome><codice>D788</codice></comune>
<comune><nome>Fratta Todina</nome><codice>D787</codice></comune>
<comune><nome>Frattamaggiore</nome><codice>D789</codice></comune>
<comune><nome>Frattaminore</nome><codice>D790</codice></comune>
<comune><nome>Fratte Rosa</nome><codice>D791</codice></comune>
<comune><nome>Frazzanò</nome><codice>D793</codice></comune>
<comune><nome>Fregona</nome><codice>D794</codice></comune>
<comune><nome>Fresagrandinaria</nome><codice>D796</codice></comune>
<comune><nome>Fresonara</nome><codice>D797</codice></comune>
<comune><nome>Frigento</nome><codice>D798</codice></comune>
<comune><nome>Frignano</nome><codice>D799</codice></comune>
<comune><nome>Frinco</nome><codice>D802</codice></comune>
<comune><nome>Frisa</nome><codice>D803</codice></comune>
<comune><nome>Frisanco</nome><codice>D804</codice></comune>
<comune><nome>Front</nome><codice>D805</codice></comune>
<comune><nome>Frontino</nome><codice>D807</codice></comune>
<comune><nome>Frontone</nome><codice>D808</codice></comune>
<comune><nome>Frosinone</nome><codice>D810</codice></comune>
<comune><nome>Frosolone</nome><codice>D811</codice></comune>
<comune><nome>Frossasco</nome><codice>D812</codice></comune>
<comune><nome>Frugarolo</nome><codice>D813</codice></comune>
<comune><nome>Fubine</nome><codice>D814</codice></comune>
<comune><nome>Fucecchio</nome><codice>D815</codice></comune>
<comune><nome>Fuipiano Valle Imagna</nome><codice>D817</codice></comune>
<comune><nome>Fumane</nome><codice>D818</codice></comune>
<comune><nome>Fumone</nome><codice>D819</codice></comune>
<comune><nome>Funes</nome><codice>D821</codice></comune>
<comune><nome>Furci</nome><codice>D823</codice></comune>
<comune><nome>Furci Siculo</nome><codice>D824</codice></comune>
<comune><nome>Furnari</nome><codice>D825</codice></comune>
<comune><nome>Furore</nome><codice>D826</codice></comune>
<comune><nome>Furtei</nome><codice>D827</codice></comune>
<comune><nome>Fuscaldo</nome><codice>D828</codice></comune>
<comune><nome>Fusignano</nome><codice>D829</codice></comune>
<comune><nome>Fusine</nome><codice>D830</codice></comune>
<comune><nome>Futani</nome><codice>D832</codice></comune>
<comune><nome>Gabbioneta-Binanuova</nome><codice>D834</codice></comune>
<comune><nome>Gabiano</nome><codice>D835</codice></comune>
<comune><nome>Gabicce Mare</nome><codice>D836</codice></comune>
<comune><nome>Gaby</nome><codice>D839</codice></comune>
<comune><nome>Gadesco-Pieve Delmona</nome><codice>D841</codice></comune>
<comune><nome>Gadoni</nome><codice>D842</codice></comune>
<comune><nome>Gaeta</nome><codice>D843</codice></comune>
<comune><nome>Gaggi</nome><codice>D844</codice></comune>
<comune><nome>Gaggiano</nome><codice>D845</codice></comune>
<comune><nome>Gaggio Montano</nome><codice>D847</codice></comune>
<comune><nome>Gaglianico</nome><codice>D848</codice></comune>
<comune><nome>Gagliano Aterno</nome><codice>D850</codice></comune>
<comune><nome>Gagliano Castelferrato</nome><codice>D849</codice></comune>
<comune><nome>Gagliano del Capo</nome><codice>D851</codice></comune>
<comune><nome>Gagliato</nome><codice>D852</codice></comune>
<comune><nome>Gagliole</nome><codice>D853</codice></comune>
<comune><nome>Gaiarine</nome><codice>D854</codice></comune>
<comune><nome>Gaiba</nome><codice>D855</codice></comune>
<comune><nome>Gaiola</nome><codice>D856</codice></comune>
<comune><nome>Gaiole in Chianti</nome><codice>D858</codice></comune>
<comune><nome>Gairo</nome><codice>D859</codice></comune>
<comune><nome>Gais</nome><codice>D860</codice></comune>
<comune><nome>Galati Mamertino</nome><codice>D861</codice></comune>
<comune><nome>Galatina</nome><codice>D862</codice></comune>
<comune><nome>Galatone</nome><codice>D863</codice></comune>
<comune><nome>Galatro</nome><codice>D864</codice></comune>
<comune><nome>Galbiate</nome><codice>D865</codice></comune>
<comune><nome>Galeata</nome><codice>D867</codice></comune>
<comune><nome>Galgagnano</nome><codice>D868</codice></comune>
<comune><nome>Gallarate</nome><codice>D869</codice></comune>
<comune><nome>Gallese</nome><codice>D870</codice></comune>
<comune><nome>Galliate</nome><codice>D872</codice></comune>
<comune><nome>Galliate Lombardo</nome><codice>D871</codice></comune>
<comune><nome>Galliavola</nome><codice>D873</codice></comune>
<comune><nome>Gallicano</nome><codice>D874</codice></comune>
<comune><nome>Gallicano nel Lazio</nome><codice>D875</codice></comune>
<comune><nome>Gallicchio</nome><codice>D876</codice></comune>
<comune><nome>Galliera</nome><codice>D878</codice></comune>
<comune><nome>Galliera Veneta</nome><codice>D879</codice></comune>
<comune><nome>Gallinaro</nome><codice>D881</codice></comune>
<comune><nome>Gallio</nome><codice>D882</codice></comune>
<comune><nome>Gallipoli</nome><codice>D883</codice></comune>
<comune><nome>Gallo Matese</nome><codice>D884</codice></comune>
<comune><nome>Gallodoro</nome><codice>D885</codice></comune>
<comune><nome>Galluccio</nome><codice>D886</codice></comune>
<comune><nome>Galtellì</nome><codice>D888</codice></comune>
<comune><nome>Galzignano Terme</nome><codice>D889</codice></comune>
<comune><nome>Gamalero</nome><codice>D890</codice></comune>
<comune><nome>Gambara</nome><codice>D891</codice></comune>
<comune><nome>Gambarana</nome><codice>D892</codice></comune>
<comune><nome>Gambasca</nome><codice>D894</codice></comune>
<comune><nome>Gambassi Terme</nome><codice>D895</codice></comune>
<comune><nome>Gambatesa</nome><codice>D896</codice></comune>
<comune><nome>Gambellara</nome><codice>D897</codice></comune>
<comune><nome>Gamberale</nome><codice>D898</codice></comune>
<comune><nome>Gambettola</nome><codice>D899</codice></comune>
<comune><nome>Gambolò</nome><codice>D901</codice></comune>
<comune><nome>Gambugliano</nome><codice>D902</codice></comune>
<comune><nome>Gandellino</nome><codice>D903</codice></comune>
<comune><nome>Gandino</nome><codice>D905</codice></comune>
<comune><nome>Gandosso</nome><codice>D906</codice></comune>
<comune><nome>Gangi</nome><codice>D907</codice></comune>
<comune><nome>Garaguso</nome><codice>D909</codice></comune>
<comune><nome>Garbagna</nome><codice>D910</codice></comune>
<comune><nome>Garbagna Novarese</nome><codice>D911</codice></comune>
<comune><nome>Garbagnate Milanese</nome><codice>D912</codice></comune>
<comune><nome>Garbagnate Monastero</nome><codice>D913</codice></comune>
<comune><nome>Garda</nome><codice>D915</codice></comune>
<comune><nome>Gardone Riviera</nome><codice>D917</codice></comune>
<comune><nome>Gardone Val Trompia</nome><codice>D918</codice></comune>
<comune><nome>Garessio</nome><codice>D920</codice></comune>
<comune><nome>Gargallo</nome><codice>D921</codice></comune>
<comune><nome>Gargazzone</nome><codice>D923</codice></comune>
<comune><nome>Gargnano</nome><codice>D924</codice></comune>
<comune><nome>Garlasco</nome><codice>D925</codice></comune>
<comune><nome>Garlate</nome><codice>D926</codice></comune>
<comune><nome>Garlenda</nome><codice>D927</codice></comune>
<comune><nome>Garniga Terme</nome><codice>D928</codice></comune>
<comune><nome>Garzeno</nome><codice>D930</codice></comune>
<comune><nome>Garzigliana</nome><codice>D931</codice></comune>
<comune><nome>Gasperina</nome><codice>D932</codice></comune>
<comune><nome>Gassino Torinese</nome><codice>D933</codice></comune>
<comune><nome>Gattatico</nome><codice>D934</codice></comune>
<comune><nome>Gatteo</nome><codice>D935</codice></comune>
<comune><nome>Gattico</nome><codice>D937</codice></comune>
<comune><nome>Gattinara</nome><codice>D938</codice></comune>
<comune><nome>Gavardo</nome><codice>D940</codice></comune>
<comune><nome>Gavazzana</nome><codice>D941</codice></comune>
<comune><nome>Gavello</nome><codice>D942</codice></comune>
<comune><nome>Gaverina Terme</nome><codice>D943</codice></comune>
<comune><nome>Gavi</nome><codice>D944</codice></comune>
<comune><nome>Gavignano</nome><codice>D945</codice></comune>
<comune><nome>Gavirate</nome><codice>D946</codice></comune>
<comune><nome>Gavoi</nome><codice>D947</codice></comune>
<comune><nome>Gavorrano</nome><codice>D948</codice></comune>
<comune><nome>Gazoldo degli Ippoliti</nome><codice>D949</codice></comune>
<comune><nome>Gazzada Schianno</nome><codice>D951</codice></comune>
<comune><nome>Gazzaniga</nome><codice>D952</codice></comune>
<comune><nome>Gazzo</nome><codice>D956</codice></comune>
<comune><nome>Gazzo Veronese</nome><codice>D957</codice></comune>
<comune><nome>Gazzola</nome><codice>D958</codice></comune>
<comune><nome>Gazzuolo</nome><codice>D959</codice></comune>
<comune><nome>Gela</nome><codice>D960</codice></comune>
<comune><nome>Gemmano</nome><codice>D961</codice></comune>
<comune><nome>Gemona del Friuli</nome><codice>D962</codice></comune>
<comune><nome>Gemonio</nome><codice>D963</codice></comune>
<comune><nome>Genazzano</nome><codice>D964</codice></comune>
<comune><nome>Genga</nome><codice>D965</codice></comune>
<comune><nome>Genivolta</nome><codice>D966</codice></comune>
<comune><nome>Genola</nome><codice>D967</codice></comune>
<comune><nome>Genoni</nome><codice>D968</codice></comune>
<comune><nome>Genova</nome><codice>D969</codice></comune>
<comune><nome>Genuri</nome><codice>D970</codice></comune>
<comune><nome>Genzano di Lucania</nome><codice>D971</codice></comune>
<comune><nome>Genzano di Roma</nome><codice>D972</codice></comune>
<comune><nome>Genzone</nome><codice>D973</codice></comune>
<comune><nome>Gera Lario</nome><codice>D974</codice></comune>
<comune><nome>Gerace</nome><codice>D975</codice></comune>
<comune><nome>Geraci Siculo</nome><codice>D977</codice></comune>
<comune><nome>Gerano</nome><codice>D978</codice></comune>
<comune><nome>Gerenzago</nome><codice>D980</codice></comune>
<comune><nome>Gerenzano</nome><codice>D981</codice></comune>
<comune><nome>Gergei</nome><codice>D982</codice></comune>
<comune><nome>Germagnano</nome><codice>D983</codice></comune>
<comune><nome>Germagno</nome><codice>D984</codice></comune>
<comune><nome>Germignaga</nome><codice>D987</codice></comune>
<comune><nome>Gerocarne</nome><codice>D988</codice></comune>
<comune><nome>Gerola Alta</nome><codice>D990</codice></comune>
<comune><nome>Gerosa</nome><codice>D991</codice></comune>
<comune><nome>Gerre de' Caprioli</nome><codice>D993</codice></comune>
<comune><nome>Gesico</nome><codice>D994</codice></comune>
<comune><nome>Gessate</nome><codice>D995</codice></comune>
<comune><nome>Gessopalena</nome><codice>D996</codice></comune>
<comune><nome>Gesturi</nome><codice>D997</codice></comune>
<comune><nome>Gesualdo</nome><codice>D998</codice></comune>
<comune><nome>Ghedi</nome><codice>D999</codice></comune>
<comune><nome>Ghemme</nome><codice>E001</codice></comune>
<comune><nome>Ghiffa</nome><codice>E003</codice></comune>
<comune><nome>Ghilarza</nome><codice>E004</codice></comune>
<comune><nome>Ghisalba</nome><codice>E006</codice></comune>
<comune><nome>Ghislarengo</nome><codice>E007</codice></comune>
<comune><nome>Giacciano con Baruchella</nome><codice>E008</codice></comune>
<comune><nome>Giaglione</nome><codice>E009</codice></comune>
<comune><nome>Gianico</nome><codice>E010</codice></comune>
<comune><nome>Giano dell'Umbria</nome><codice>E012</codice></comune>
<comune><nome>Giano Vetusto</nome><codice>E011</codice></comune>
<comune><nome>Giardinello</nome><codice>E013</codice></comune>
<comune><nome>Giardini-Naxos</nome><codice>E014</codice></comune>
<comune><nome>Giarole</nome><codice>E015</codice></comune>
<comune><nome>Giarratana</nome><codice>E016</codice></comune>
<comune><nome>Giarre</nome><codice>E017</codice></comune>
<comune><nome>Giave</nome><codice>E019</codice></comune>
<comune><nome>Giaveno</nome><codice>E020</codice></comune>
<comune><nome>Giavera del Montello</nome><codice>E021</codice></comune>
<comune><nome>Giba</nome><codice>E022</codice></comune>
<comune><nome>Gibellina</nome><codice>E023</codice></comune>
<comune><nome>Gifflenga</nome><codice>E024</codice></comune>
<comune><nome>Giffone</nome><codice>E025</codice></comune>
<comune><nome>Giffoni Sei Casali</nome><codice>E026</codice></comune>
<comune><nome>Giffoni Valle Piana</nome><codice>E027</codice></comune>
<comune><nome>Gignese</nome><codice>E028</codice></comune>
<comune><nome>Gignod</nome><codice>E029</codice></comune>
<comune><nome>Gildone</nome><codice>E030</codice></comune>
<comune><nome>Gimigliano</nome><codice>E031</codice></comune>
<comune><nome>Ginestra</nome><codice>E033</codice></comune>
<comune><nome>Ginestra degli Schiavoni</nome><codice>E034</codice></comune>
<comune><nome>Ginosa</nome><codice>E036</codice></comune>
<comune><nome>Gioi</nome><codice>E037</codice></comune>
<comune><nome>Gioia dei Marsi</nome><codice>E040</codice></comune>
<comune><nome>Gioia del Colle</nome><codice>E038</codice></comune>
<comune><nome>Gioia Sannitica</nome><codice>E039</codice></comune>
<comune><nome>Gioia Tauro</nome><codice>E041</codice></comune>
<comune><nome>Gioiosa Ionica</nome><codice>E044</codice></comune>
<comune><nome>Gioiosa Marea</nome><codice>E043</codice></comune>
<comune><nome>Giove</nome><codice>E045</codice></comune>
<comune><nome>Giovinazzo</nome><codice>E047</codice></comune>
<comune><nome>Giovo</nome><codice>E048</codice></comune>
<comune><nome>Girasole</nome><codice>E049</codice></comune>
<comune><nome>Girifalco</nome><codice>E050</codice></comune>
<comune><nome>Gironico</nome><codice>E051</codice></comune>
<comune><nome>Gissi</nome><codice>E052</codice></comune>
<comune><nome>Giuggianello</nome><codice>E053</codice></comune>
<comune><nome>Giugliano in Campania</nome><codice>E054</codice></comune>
<comune><nome>Giuliana</nome><codice>E055</codice></comune>
<comune><nome>Giuliano di Roma</nome><codice>E057</codice></comune>
<comune><nome>Giuliano Teatino</nome><codice>E056</codice></comune>
<comune><nome>Giulianova</nome><codice>E058</codice></comune>
<comune><nome>Giuncugnano</nome><codice>E059</codice></comune>
<comune><nome>Giungano</nome><codice>E060</codice></comune>
<comune><nome>Giurdignano</nome><codice>E061</codice></comune>
<comune><nome>Giussago</nome><codice>E062</codice></comune>
<comune><nome>Giussano</nome><codice>E063</codice></comune>
<comune><nome>Giustenice</nome><codice>E064</codice></comune>
<comune><nome>Giustino</nome><codice>E065</codice></comune>
<comune><nome>Giusvalla</nome><codice>E066</codice></comune>
<comune><nome>Givoletto</nome><codice>E067</codice></comune>
<comune><nome>Gizzeria</nome><codice>E068</codice></comune>
<comune><nome>Glorenza</nome><codice>E069</codice></comune>
<comune><nome>Godega di Sant'Urbano</nome><codice>E071</codice></comune>
<comune><nome>Godiasco</nome><codice>E072</codice></comune>
<comune><nome>Godrano</nome><codice>E074</codice></comune>
<comune><nome>Goito</nome><codice>E078</codice></comune>
<comune><nome>Golasecca</nome><codice>E079</codice></comune>
<comune><nome>Golferenzo</nome><codice>E081</codice></comune>
<comune><nome>Golfo Aranci</nome><codice>M274</codice></comune>
<comune><nome>Gombito</nome><codice>E082</codice></comune>
<comune><nome>Gonars</nome><codice>E083</codice></comune>
<comune><nome>Goni</nome><codice>E084</codice></comune>
<comune><nome>Gonnesa</nome><codice>E086</codice></comune>
<comune><nome>Gonnoscodina</nome><codice>E087</codice></comune>
<comune><nome>Gonnosfanadiga</nome><codice>E085</codice></comune>
<comune><nome>Gonnosnò</nome><codice>D585</codice></comune>
<comune><nome>Gonnostramatza</nome><codice>E088</codice></comune>
<comune><nome>Gonzaga</nome><codice>E089</codice></comune>
<comune><nome>Gordona</nome><codice>E090</codice></comune>
<comune><nome>Gorga</nome><codice>E091</codice></comune>
<comune><nome>Gorgo al Monticano</nome><codice>E092</codice></comune>
<comune><nome>Gorgoglione</nome><codice>E093</codice></comune>
<comune><nome>Gorgonzola</nome><codice>E094</codice></comune>
<comune><nome>Goriano Sicoli</nome><codice>E096</codice></comune>
<comune><nome>Gorizia</nome><codice>E098</codice></comune>
<comune><nome>Gorla Maggiore</nome><codice>E101</codice></comune>
<comune><nome>Gorla Minore</nome><codice>E102</codice></comune>
<comune><nome>Gorlago</nome><codice>E100</codice></comune>
<comune><nome>Gorle</nome><codice>E103</codice></comune>
<comune><nome>Gornate-Olona</nome><codice>E104</codice></comune>
<comune><nome>Gorno</nome><codice>E106</codice></comune>
<comune><nome>Goro</nome><codice>E107</codice></comune>
<comune><nome>Gorreto</nome><codice>E109</codice></comune>
<comune><nome>Gorzegno</nome><codice>E111</codice></comune>
<comune><nome>Gosaldo</nome><codice>E113</codice></comune>
<comune><nome>Gossolengo</nome><codice>E114</codice></comune>
<comune><nome>Gottasecca</nome><codice>E115</codice></comune>
<comune><nome>Gottolengo</nome><codice>E116</codice></comune>
<comune><nome>Govone</nome><codice>E118</codice></comune>
<comune><nome>Gozzano</nome><codice>E120</codice></comune>
<comune><nome>Gradara</nome><codice>E122</codice></comune>
<comune><nome>Gradisca d'Isonzo</nome><codice>E124</codice></comune>
<comune><nome>Grado</nome><codice>E125</codice></comune>
<comune><nome>Gradoli</nome><codice>E126</codice></comune>
<comune><nome>Graffignana</nome><codice>E127</codice></comune>
<comune><nome>Graffignano</nome><codice>E128</codice></comune>
<comune><nome>Graglia</nome><codice>E130</codice></comune>
<comune><nome>Gragnano</nome><codice>E131</codice></comune>
<comune><nome>Gragnano Trebbiense</nome><codice>E132</codice></comune>
<comune><nome>Grammichele</nome><codice>E133</codice></comune>
<comune><nome>Grana</nome><codice>E134</codice></comune>
<comune><nome>Granaglione</nome><codice>E135</codice></comune>
<comune><nome>Granarolo dell'Emilia</nome><codice>E136</codice></comune>
<comune><nome>Grancona</nome><codice>E138</codice></comune>
<comune><nome>Grandate</nome><codice>E139</codice></comune>
<comune><nome>Grandola ed Uniti</nome><codice>E141</codice></comune>
<comune><nome>Graniti</nome><codice>E142</codice></comune>
<comune><nome>Granozzo con Monticello</nome><codice>E143</codice></comune>
<comune><nome>Grantola</nome><codice>E144</codice></comune>
<comune><nome>Grantorto</nome><codice>E145</codice></comune>
<comune><nome>Granze</nome><codice>E146</codice></comune>
<comune><nome>Grassano</nome><codice>E147</codice></comune>
<comune><nome>Grassobbio</nome><codice>E148</codice></comune>
<comune><nome>Gratteri</nome><codice>E149</codice></comune>
<comune><nome>Grauno</nome><codice>E150</codice></comune>
<comune><nome>Gravedona ed Uniti</nome><codice>M315</codice></comune>
<comune><nome>Gravellona Lomellina</nome><codice>E152</codice></comune>
<comune><nome>Gravellona Toce</nome><codice>E153</codice></comune>
<comune><nome>Gravere</nome><codice>E154</codice></comune>
<comune><nome>Gravina di Catania</nome><codice>E156</codice></comune>
<comune><nome>Gravina in Puglia</nome><codice>E155</codice></comune>
<comune><nome>Grazzanise</nome><codice>E158</codice></comune>
<comune><nome>Grazzano Badoglio</nome><codice>E159</codice></comune>
<comune><nome>Greccio</nome><codice>E160</codice></comune>
<comune><nome>Greci</nome><codice>E161</codice></comune>
<comune><nome>Greggio</nome><codice>E163</codice></comune>
<comune><nome>Gremiasco</nome><codice>E164</codice></comune>
<comune><nome>Gressan</nome><codice>E165</codice></comune>
<comune><nome>Gressoney-la-Trinitè</nome><codice>E167</codice></comune>
<comune><nome>Gressoney-Saint-Jean</nome><codice>E168</codice></comune>
<comune><nome>Greve in Chianti</nome><codice>E169</codice></comune>
<comune><nome>Grezzago</nome><codice>E170</codice></comune>
<comune><nome>Grezzana</nome><codice>E171</codice></comune>
<comune><nome>Griante</nome><codice>E172</codice></comune>
<comune><nome>Gricignano di Aversa</nome><codice>E173</codice></comune>
<comune><nome>Grignasco</nome><codice>E177</codice></comune>
<comune><nome>Grigno</nome><codice>E178</codice></comune>
<comune><nome>Grimacco</nome><codice>E179</codice></comune>
<comune><nome>Grimaldi</nome><codice>E180</codice></comune>
<comune><nome>Grinzane Cavour</nome><codice>E182</codice></comune>
<comune><nome>Grisignano di Zocco</nome><codice>E184</codice></comune>
<comune><nome>Grisolia</nome><codice>E185</codice></comune>
<comune><nome>Grizzana Morandi</nome><codice>E187</codice></comune>
<comune><nome>Grognardo</nome><codice>E188</codice></comune>
<comune><nome>Gromo</nome><codice>E189</codice></comune>
<comune><nome>Grondona</nome><codice>E191</codice></comune>
<comune><nome>Grone</nome><codice>E192</codice></comune>
<comune><nome>Grontardo</nome><codice>E193</codice></comune>
<comune><nome>Gropello Cairoli</nome><codice>E195</codice></comune>
<comune><nome>Gropparello</nome><codice>E196</codice></comune>
<comune><nome>Groscavallo</nome><codice>E199</codice></comune>
<comune><nome>Grosio</nome><codice>E200</codice></comune>
<comune><nome>Grosotto</nome><codice>E201</codice></comune>
<comune><nome>Grosseto</nome><codice>E202</codice></comune>
<comune><nome>Grosso</nome><codice>E203</codice></comune>
<comune><nome>Grottaferrata</nome><codice>E204</codice></comune>
<comune><nome>Grottaglie</nome><codice>E205</codice></comune>
<comune><nome>Grottaminarda</nome><codice>E206</codice></comune>
<comune><nome>Grottammare</nome><codice>E207</codice></comune>
<comune><nome>Grottazzolina</nome><codice>E208</codice></comune>
<comune><nome>Grotte</nome><codice>E209</codice></comune>
<comune><nome>Grotte di Castro</nome><codice>E210</codice></comune>
<comune><nome>Grotteria</nome><codice>E212</codice></comune>
<comune><nome>Grottole</nome><codice>E213</codice></comune>
<comune><nome>Grottolella</nome><codice>E214</codice></comune>
<comune><nome>Gruaro</nome><codice>E215</codice></comune>
<comune><nome>Grugliasco</nome><codice>E216</codice></comune>
<comune><nome>Grumello Cremonese ed Uniti</nome><codice>E217</codice></comune>
<comune><nome>Grumello del Monte</nome><codice>E219</codice></comune>
<comune><nome>Grumento Nova</nome><codice>E221</codice></comune>
<comune><nome>Grumes</nome><codice>E222</codice></comune>
<comune><nome>Grumo Appula</nome><codice>E223</codice></comune>
<comune><nome>Grumo Nevano</nome><codice>E224</codice></comune>
<comune><nome>Grumolo delle Abbadesse</nome><codice>E226</codice></comune>
<comune><nome>Guagnano</nome><codice>E227</codice></comune>
<comune><nome>Gualdo</nome><codice>E228</codice></comune>
<comune><nome>Gualdo Cattaneo</nome><codice>E229</codice></comune>
<comune><nome>Gualdo Tadino</nome><codice>E230</codice></comune>
<comune><nome>Gualtieri</nome><codice>E232</codice></comune>
<comune><nome>Gualtieri Sicaminò</nome><codice>E233</codice></comune>
<comune><nome>Guamaggiore</nome><codice>E234</codice></comune>
<comune><nome>Guanzate</nome><codice>E235</codice></comune>
<comune><nome>Guarcino</nome><codice>E236</codice></comune>
<comune><nome>Guarda Veneta</nome><codice>E240</codice></comune>
<comune><nome>Guardabosone</nome><codice>E237</codice></comune>
<comune><nome>Guardamiglio</nome><codice>E238</codice></comune>
<comune><nome>Guardavalle</nome><codice>E239</codice></comune>
<comune><nome>Guardea</nome><codice>E241</codice></comune>
<comune><nome>Guardia Lombardi</nome><codice>E245</codice></comune>
<comune><nome>Guardia Perticara</nome><codice>E246</codice></comune>
<comune><nome>Guardia Piemontese</nome><codice>E242</codice></comune>
<comune><nome>Guardia Sanframondi</nome><codice>E249</codice></comune>
<comune><nome>Guardiagrele</nome><codice>E243</codice></comune>
<comune><nome>Guardialfiera</nome><codice>E244</codice></comune>
<comune><nome>Guardiaregia</nome><codice>E248</codice></comune>
<comune><nome>Guardistallo</nome><codice>E250</codice></comune>
<comune><nome>Guarene</nome><codice>E251</codice></comune>
<comune><nome>Guasila</nome><codice>E252</codice></comune>
<comune><nome>Guastalla</nome><codice>E253</codice></comune>
<comune><nome>Guazzora</nome><codice>E255</codice></comune>
<comune><nome>Gubbio</nome><codice>E256</codice></comune>
<comune><nome>Gudo Visconti</nome><codice>E258</codice></comune>
<comune><nome>Guglionesi</nome><codice>E259</codice></comune>
<comune><nome>Guidizzolo</nome><codice>E261</codice></comune>
<comune><nome>Guidonia Montecelio</nome><codice>E263</codice></comune>
<comune><nome>Guiglia</nome><codice>E264</codice></comune>
<comune><nome>Guilmi</nome><codice>E266</codice></comune>
<comune><nome>Gurro</nome><codice>E269</codice></comune>
<comune><nome>Guspini</nome><codice>E270</codice></comune>
<comune><nome>Gussago</nome><codice>E271</codice></comune>
<comune><nome>Gussola</nome><codice>E272</codice></comune>
<comune><nome>Hone</nome><codice>E273</codice></comune>
<comune><nome>Idro</nome><codice>E280</codice></comune>
<comune><nome>Iglesias</nome><codice>E281</codice></comune>
<comune><nome>Igliano</nome><codice>E282</codice></comune>
<comune><nome>Ilbono</nome><codice>E283</codice></comune>
<comune><nome>Illasi</nome><codice>E284</codice></comune>
<comune><nome>Illorai</nome><codice>E285</codice></comune>
<comune><nome>Imbersago</nome><codice>E287</codice></comune>
<comune><nome>Imer</nome><codice>E288</codice></comune>
<comune><nome>Imola</nome><codice>E289</codice></comune>
<comune><nome>Imperia</nome><codice>E290</codice></comune>
<comune><nome>Impruneta</nome><codice>E291</codice></comune>
<comune><nome>Inarzo</nome><codice>E292</codice></comune>
<comune><nome>Incisa in Val d'Arno</nome><codice>E296</codice></comune>
<comune><nome>Incisa Scapaccino</nome><codice>E295</codice></comune>
<comune><nome>Incudine</nome><codice>E297</codice></comune>
<comune><nome>Induno Olona</nome><codice>E299</codice></comune>
<comune><nome>Ingria</nome><codice>E301</codice></comune>
<comune><nome>Intragna</nome><codice>E304</codice></comune>
<comune><nome>Introbio</nome><codice>E305</codice></comune>
<comune><nome>Introd</nome><codice>E306</codice></comune>
<comune><nome>Introdacqua</nome><codice>E307</codice></comune>
<comune><nome>Introzzo</nome><codice>E308</codice></comune>
<comune><nome>Inverigo</nome><codice>E309</codice></comune>
<comune><nome>Inverno e Monteleone</nome><codice>E310</codice></comune>
<comune><nome>Inverso Pinasca</nome><codice>E311</codice></comune>
<comune><nome>Inveruno</nome><codice>E313</codice></comune>
<comune><nome>Invorio</nome><codice>E314</codice></comune>
<comune><nome>Inzago</nome><codice>E317</codice></comune>
<comune><nome>Ionadi</nome><codice>E321</codice></comune>
<comune><nome>Irgoli</nome><codice>E323</codice></comune>
<comune><nome>Irma</nome><codice>E325</codice></comune>
<comune><nome>Irsina</nome><codice>E326</codice></comune>
<comune><nome>Isasca</nome><codice>E327</codice></comune>
<comune><nome>Isca sullo Ionio</nome><codice>E328</codice></comune>
<comune><nome>Ischia</nome><codice>E329</codice></comune>
<comune><nome>Ischia di Castro</nome><codice>E330</codice></comune>
<comune><nome>Ischitella</nome><codice>E332</codice></comune>
<comune><nome>Iseo</nome><codice>E333</codice></comune>
<comune><nome>Isera</nome><codice>E334</codice></comune>
<comune><nome>Isernia</nome><codice>E335</codice></comune>
<comune><nome>Isili</nome><codice>E336</codice></comune>
<comune><nome>Isnello</nome><codice>E337</codice></comune>
<comune><nome>Isola d'Asti</nome><codice>E338</codice></comune>
<comune><nome>Isola del Cantone</nome><codice>E341</codice></comune>
<comune><nome>Isola del Giglio</nome><codice>E348</codice></comune>
<comune><nome>Isola del Gran Sasso d'Italia</nome><codice>E343</codice></comune>
<comune><nome>Isola del Liri</nome><codice>E340</codice></comune>
<comune><nome>Isola del Piano</nome><codice>E351</codice></comune>
<comune><nome>Isola della Scala</nome><codice>E349</codice></comune>
<comune><nome>Isola delle Femmine</nome><codice>E350</codice></comune>
<comune><nome>Isola di Capo Rizzuto</nome><codice>E339</codice></comune>
<comune><nome>Isola di Fondra</nome><codice>E353</codice></comune>
<comune><nome>Isola Dovarese</nome><codice>E356</codice></comune>
<comune><nome>Isola Rizza</nome><codice>E358</codice></comune>
<comune><nome>Isola Sant'Antonio</nome><codice>E360</codice></comune>
<comune><nome>Isola Vicentina</nome><codice>E354</codice></comune>
<comune><nome>Isolabella</nome><codice>E345</codice></comune>
<comune><nome>Isolabona</nome><codice>E346</codice></comune>
<comune><nome>Isole Tremiti</nome><codice>E363</codice></comune>
<comune><nome>Isorella</nome><codice>E364</codice></comune>
<comune><nome>Ispani</nome><codice>E365</codice></comune>
<comune><nome>Ispica</nome><codice>E366</codice></comune>
<comune><nome>Ispra</nome><codice>E367</codice></comune>
<comune><nome>Issiglio</nome><codice>E368</codice></comune>
<comune><nome>Issime</nome><codice>E369</codice></comune>
<comune><nome>Isso</nome><codice>E370</codice></comune>
<comune><nome>Issogne</nome><codice>E371</codice></comune>
<comune><nome>Istrana</nome><codice>E373</codice></comune>
<comune><nome>Itala</nome><codice>E374</codice></comune>
<comune><nome>Itri</nome><codice>E375</codice></comune>
<comune><nome>Ittireddu</nome><codice>E376</codice></comune>
<comune><nome>Ittiri</nome><codice>E377</codice></comune>
<comune><nome>Ivano-Fracena</nome><codice>E378</codice></comune>
<comune><nome>Ivrea</nome><codice>E379</codice></comune>
<comune><nome>Izano</nome><codice>E380</codice></comune>
<comune><nome>Jacurso</nome><codice>E274</codice></comune>
<comune><nome>Jelsi</nome><codice>E381</codice></comune>
<comune><nome>Jenne</nome><codice>E382</codice></comune>
<comune><nome>Jerago con Orago</nome><codice>E386</codice></comune>
<comune><nome>Jerzu</nome><codice>E387</codice></comune>
<comune><nome>Jesi</nome><codice>E388</codice></comune>
<comune><nome>Jesolo</nome><codice>C388</codice></comune>
<comune><nome>Jolanda di Savoia</nome><codice>E320</codice></comune>
<comune><nome>Joppolo</nome><codice>E389</codice></comune>
<comune><nome>Joppolo Giancaxio</nome><codice>E390</codice></comune>
<comune><nome>Jovencan</nome><codice>E391</codice></comune>
<comune><nome>La Cassa</nome><codice>E394</codice></comune>
<comune><nome>La Loggia</nome><codice>E423</codice></comune>
<comune><nome>La Maddalena</nome><codice>E425</codice></comune>
<comune><nome>La Magdeleine</nome><codice>A308</codice></comune>
<comune><nome>La Morra</nome><codice>E430</codice></comune>
<comune><nome>La Salle</nome><codice>E458</codice></comune>
<comune><nome>La Spezia</nome><codice>E463</codice></comune>
<comune><nome>La Thuile</nome><codice>E470</codice></comune>
<comune><nome>La Valle</nome><codice>E491</codice></comune>
<comune><nome>La Valle Agordina</nome><codice>E490</codice></comune>
<comune><nome>Labico</nome><codice>E392</codice></comune>
<comune><nome>Labro</nome><codice>E393</codice></comune>
<comune><nome>Lacchiarella</nome><codice>E395</codice></comune>
<comune><nome>Lacco Ameno</nome><codice>E396</codice></comune>
<comune><nome>Lacedonia</nome><codice>E397</codice></comune>
<comune><nome>Laces</nome><codice>E398</codice></comune>
<comune><nome>Laconi</nome><codice>E400</codice></comune>
<comune><nome>Ladispoli</nome><codice>M212</codice></comune>
<comune><nome>Laerru</nome><codice>E401</codice></comune>
<comune><nome>Laganadi</nome><codice>E402</codice></comune>
<comune><nome>Laghi</nome><codice>E403</codice></comune>
<comune><nome>Laglio</nome><codice>E405</codice></comune>
<comune><nome>Lagnasco</nome><codice>E406</codice></comune>
<comune><nome>Lago</nome><codice>E407</codice></comune>
<comune><nome>Lagonegro</nome><codice>E409</codice></comune>
<comune><nome>Lagosanto</nome><codice>E410</codice></comune>
<comune><nome>Lagundo</nome><codice>E412</codice></comune>
<comune><nome>Laigueglia</nome><codice>E414</codice></comune>
<comune><nome>Lainate</nome><codice>E415</codice></comune>
<comune><nome>Laino</nome><codice>E416</codice></comune>
<comune><nome>Laino Borgo</nome><codice>E417</codice></comune>
<comune><nome>Laino Castello</nome><codice>E419</codice></comune>
<comune><nome>Laion</nome><codice>E420</codice></comune>
<comune><nome>Laives</nome><codice>E421</codice></comune>
<comune><nome>Lajatico</nome><codice>E413</codice></comune>
<comune><nome>Lallio</nome><codice>E422</codice></comune>
<comune><nome>Lama dei Peligni</nome><codice>E424</codice></comune>
<comune><nome>Lama Mocogno</nome><codice>E426</codice></comune>
<comune><nome>Lambrugo</nome><codice>E428</codice></comune>
<comune><nome>Lamezia Terme</nome><codice>M208</codice></comune>
<comune><nome>Lamon</nome><codice>E429</codice></comune>
<comune><nome>Lampedusa e Linosa</nome><codice>E431</codice></comune>
<comune><nome>Lamporecchio</nome><codice>E432</codice></comune>
<comune><nome>Lamporo</nome><codice>E433</codice></comune>
<comune><nome>Lana</nome><codice>E434</codice></comune>
<comune><nome>Lanciano</nome><codice>E435</codice></comune>
<comune><nome>Landiona</nome><codice>E436</codice></comune>
<comune><nome>Landriano</nome><codice>E437</codice></comune>
<comune><nome>Langhirano</nome><codice>E438</codice></comune>
<comune><nome>Langosco</nome><codice>E439</codice></comune>
<comune><nome>Lanusei</nome><codice>E441</codice></comune>
<comune><nome>Lanuvio</nome><codice>C767</codice></comune>
<comune><nome>Lanzada</nome><codice>E443</codice></comune>
<comune><nome>Lanzo d'Intelvi</nome><codice>E444</codice></comune>
<comune><nome>Lanzo Torinese</nome><codice>E445</codice></comune>
<comune><nome>Lapedona</nome><codice>E447</codice></comune>
<comune><nome>Lapio</nome><codice>E448</codice></comune>
<comune><nome>Lappano</nome><codice>E450</codice></comune>
<comune><nome>L'Aquila</nome><codice>A345</codice></comune>
<comune><nome>Larciano</nome><codice>E451</codice></comune>
<comune><nome>Lardaro</nome><codice>E452</codice></comune>
<comune><nome>Lardirago</nome><codice>E454</codice></comune>
<comune><nome>Lari</nome><codice>E455</codice></comune>
<comune><nome>Lariano</nome><codice>M207</codice></comune>
<comune><nome>Larino</nome><codice>E456</codice></comune>
<comune><nome>Las Plassas</nome><codice>E464</codice></comune>
<comune><nome>Lasa</nome><codice>E457</codice></comune>
<comune><nome>Lascari</nome><codice>E459</codice></comune>
<comune><nome>Lasino</nome><codice>E461</codice></comune>
<comune><nome>Lasnigo</nome><codice>E462</codice></comune>
<comune><nome>Lastebasse</nome><codice>E465</codice></comune>
<comune><nome>Lastra a Signa</nome><codice>E466</codice></comune>
<comune><nome>Latera</nome><codice>E467</codice></comune>
<comune><nome>Laterina</nome><codice>E468</codice></comune>
<comune><nome>Laterza</nome><codice>E469</codice></comune>
<comune><nome>Latiano</nome><codice>E471</codice></comune>
<comune><nome>Latina</nome><codice>E472</codice></comune>
<comune><nome>Latisana</nome><codice>E473</codice></comune>
<comune><nome>Latronico</nome><codice>E474</codice></comune>
<comune><nome>Lattarico</nome><codice>E475</codice></comune>
<comune><nome>Lauco</nome><codice>E476</codice></comune>
<comune><nome>Laureana Cilento</nome><codice>E480</codice></comune>
<comune><nome>Laureana di Borrello</nome><codice>E479</codice></comune>
<comune><nome>Lauregno</nome><codice>E481</codice></comune>
<comune><nome>Laurenzana</nome><codice>E482</codice></comune>
<comune><nome>Lauria</nome><codice>E483</codice></comune>
<comune><nome>Lauriano</nome><codice>E484</codice></comune>
<comune><nome>Laurino</nome><codice>E485</codice></comune>
<comune><nome>Laurito</nome><codice>E486</codice></comune>
<comune><nome>Lauro</nome><codice>E487</codice></comune>
<comune><nome>Lavagna</nome><codice>E488</codice></comune>
<comune><nome>Lavagno</nome><codice>E489</codice></comune>
<comune><nome>Lavarone</nome><codice>E492</codice></comune>
<comune><nome>Lavello</nome><codice>E493</codice></comune>
<comune><nome>Lavena Ponte Tresa</nome><codice>E494</codice></comune>
<comune><nome>Laveno-Mombello</nome><codice>E496</codice></comune>
<comune><nome>Lavenone</nome><codice>E497</codice></comune>
<comune><nome>Laviano</nome><codice>E498</codice></comune>
<comune><nome>Lavis</nome><codice>E500</codice></comune>
<comune><nome>Lazise</nome><codice>E502</codice></comune>
<comune><nome>Lazzate</nome><codice>E504</codice></comune>
<comune><nome>Lecce</nome><codice>E506</codice></comune>
<comune><nome>Lecce nei Marsi</nome><codice>E505</codice></comune>
<comune><nome>Lecco</nome><codice>E507</codice></comune>
<comune><nome>Ledro</nome><codice>M313</codice></comune>
<comune><nome>Leffe</nome><codice>E509</codice></comune>
<comune><nome>Leggiuno</nome><codice>E510</codice></comune>
<comune><nome>Legnago</nome><codice>E512</codice></comune>
<comune><nome>Legnano</nome><codice>E514</codice></comune>
<comune><nome>Legnaro</nome><codice>E515</codice></comune>
<comune><nome>Lei</nome><codice>E517</codice></comune>
<comune><nome>Leini</nome><codice>E518</codice></comune>
<comune><nome>Leivi</nome><codice>E519</codice></comune>
<comune><nome>Lemie</nome><codice>E520</codice></comune>
<comune><nome>Lendinara</nome><codice>E522</codice></comune>
<comune><nome>Leni</nome><codice>E523</codice></comune>
<comune><nome>Lenna</nome><codice>E524</codice></comune>
<comune><nome>Lenno</nome><codice>E525</codice></comune>
<comune><nome>Leno</nome><codice>E526</codice></comune>
<comune><nome>Lenola</nome><codice>E527</codice></comune>
<comune><nome>Lenta</nome><codice>E528</codice></comune>
<comune><nome>Lentate sul Seveso</nome><codice>E530</codice></comune>
<comune><nome>Lentella</nome><codice>E531</codice></comune>
<comune><nome>Lentiai</nome><codice>C562</codice></comune>
<comune><nome>Lentini</nome><codice>E532</codice></comune>
<comune><nome>Leonessa</nome><codice>E535</codice></comune>
<comune><nome>Leonforte</nome><codice>E536</codice></comune>
<comune><nome>Leporano</nome><codice>E537</codice></comune>
<comune><nome>Lequile</nome><codice>E538</codice></comune>
<comune><nome>Lequio Berria</nome><codice>E540</codice></comune>
<comune><nome>Lequio Tanaro</nome><codice>E539</codice></comune>
<comune><nome>Lercara Friddi</nome><codice>E541</codice></comune>
<comune><nome>Lerici</nome><codice>E542</codice></comune>
<comune><nome>Lerma</nome><codice>E543</codice></comune>
<comune><nome>Lesa</nome><codice>E544</codice></comune>
<comune><nome>Lesegno</nome><codice>E546</codice></comune>
<comune><nome>Lesignano de' Bagni</nome><codice>E547</codice></comune>
<comune><nome>Lesina</nome><codice>E549</codice></comune>
<comune><nome>Lesmo</nome><codice>E550</codice></comune>
<comune><nome>Lessolo</nome><codice>E551</codice></comune>
<comune><nome>Lessona</nome><codice>E552</codice></comune>
<comune><nome>Lestizza</nome><codice>E553</codice></comune>
<comune><nome>Letino</nome><codice>E554</codice></comune>
<comune><nome>Letojanni</nome><codice>E555</codice></comune>
<comune><nome>Lettere</nome><codice>E557</codice></comune>
<comune><nome>Lettomanoppello</nome><codice>E558</codice></comune>
<comune><nome>Lettopalena</nome><codice>E559</codice></comune>
<comune><nome>Levanto</nome><codice>E560</codice></comune>
<comune><nome>Levate</nome><codice>E562</codice></comune>
<comune><nome>Leverano</nome><codice>E563</codice></comune>
<comune><nome>Levice</nome><codice>E564</codice></comune>
<comune><nome>Levico Terme</nome><codice>E565</codice></comune>
<comune><nome>Levone</nome><codice>E566</codice></comune>
<comune><nome>Lezzeno</nome><codice>E569</codice></comune>
<comune><nome>Liberi</nome><codice>E570</codice></comune>
<comune><nome>Librizzi</nome><codice>E571</codice></comune>
<comune><nome>Licata</nome><codice>E573</codice></comune>
<comune><nome>Licciana Nardi</nome><codice>E574</codice></comune>
<comune><nome>Licenza</nome><codice>E576</codice></comune>
<comune><nome>Licodia Eubea</nome><codice>E578</codice></comune>
<comune><nome>Lierna</nome><codice>E581</codice></comune>
<comune><nome>Lignana</nome><codice>E583</codice></comune>
<comune><nome>Lignano Sabbiadoro</nome><codice>E584</codice></comune>
<comune><nome>Ligonchio</nome><codice>E585</codice></comune>
<comune><nome>Ligosullo</nome><codice>E586</codice></comune>
<comune><nome>Lillianes</nome><codice>E587</codice></comune>
<comune><nome>Limana</nome><codice>E588</codice></comune>
<comune><nome>Limatola</nome><codice>E589</codice></comune>
<comune><nome>Limbadi</nome><codice>E590</codice></comune>
<comune><nome>Limbiate</nome><codice>E591</codice></comune>
<comune><nome>Limena</nome><codice>E592</codice></comune>
<comune><nome>Limido Comasco</nome><codice>E593</codice></comune>
<comune><nome>Limina</nome><codice>E594</codice></comune>
<comune><nome>Limone Piemonte</nome><codice>E597</codice></comune>
<comune><nome>Limone sul Garda</nome><codice>E596</codice></comune>
<comune><nome>Limosano</nome><codice>E599</codice></comune>
<comune><nome>Linarolo</nome><codice>E600</codice></comune>
<comune><nome>Linguaglossa</nome><codice>E602</codice></comune>
<comune><nome>Lioni</nome><codice>E605</codice></comune>
<comune><nome>Lipari</nome><codice>E606</codice></comune>
<comune><nome>Lipomo</nome><codice>E607</codice></comune>
<comune><nome>Lirio</nome><codice>E608</codice></comune>
<comune><nome>Liscate</nome><codice>E610</codice></comune>
<comune><nome>Liscia</nome><codice>E611</codice></comune>
<comune><nome>Lisciano Niccone</nome><codice>E613</codice></comune>
<comune><nome>Lisignago</nome><codice>E614</codice></comune>
<comune><nome>Lisio</nome><codice>E615</codice></comune>
<comune><nome>Lissone</nome><codice>E617</codice></comune>
<comune><nome>Liveri</nome><codice>E620</codice></comune>
<comune><nome>Livigno</nome><codice>E621</codice></comune>
<comune><nome>Livinallongo del Col di Lana</nome><codice>E622</codice></comune>
<comune><nome>Livo</nome><codice>E624</codice></comune>
<comune><nome>Livo</nome><codice>E623</codice></comune>
<comune><nome>Livorno</nome><codice>E625</codice></comune>
<comune><nome>Livorno Ferraris</nome><codice>E626</codice></comune>
<comune><nome>Livraga</nome><codice>E627</codice></comune>
<comune><nome>Lizzanello</nome><codice>E629</codice></comune>
<comune><nome>Lizzano</nome><codice>E630</codice></comune>
<comune><nome>Lizzano in Belvedere</nome><codice>A771</codice></comune>
<comune><nome>Loano</nome><codice>E632</codice></comune>
<comune><nome>Loazzolo</nome><codice>E633</codice></comune>
<comune><nome>Locana</nome><codice>E635</codice></comune>
<comune><nome>Locate di Triulzi</nome><codice>E639</codice></comune>
<comune><nome>Locate Varesino</nome><codice>E638</codice></comune>
<comune><nome>Locatello</nome><codice>E640</codice></comune>
<comune><nome>Loceri</nome><codice>E644</codice></comune>
<comune><nome>Locorotondo</nome><codice>E645</codice></comune>
<comune><nome>Locri</nome><codice>D976</codice></comune>
<comune><nome>Loculi</nome><codice>E646</codice></comune>
<comune><nome>Lodè</nome><codice>E647</codice></comune>
<comune><nome>Lodi</nome><codice>E648</codice></comune>
<comune><nome>Lodi Vecchio</nome><codice>E651</codice></comune>
<comune><nome>Lodine</nome><codice>E649</codice></comune>
<comune><nome>Lodrino</nome><codice>E652</codice></comune>
<comune><nome>Lograto</nome><codice>E654</codice></comune>
<comune><nome>Loiano</nome><codice>E655</codice></comune>
<comune><nome>Loiri Porto San Paolo</nome><codice>M275</codice></comune>
<comune><nome>Lomagna</nome><codice>E656</codice></comune>
<comune><nome>Lomazzo</nome><codice>E659</codice></comune>
<comune><nome>Lombardore</nome><codice>E660</codice></comune>
<comune><nome>Lombriasco</nome><codice>E661</codice></comune>
<comune><nome>Lomello</nome><codice>E662</codice></comune>
<comune><nome>Lona-Lases</nome><codice>E664</codice></comune>
<comune><nome>Lonate Ceppino</nome><codice>E665</codice></comune>
<comune><nome>Lonate Pozzolo</nome><codice>E666</codice></comune>
<comune><nome>Lonato del Garda</nome><codice>M312</codice></comune>
<comune><nome>Londa</nome><codice>E668</codice></comune>
<comune><nome>Longano</nome><codice>E669</codice></comune>
<comune><nome>Longare</nome><codice>E671</codice></comune>
<comune><nome>Longarone</nome><codice>E672</codice></comune>
<comune><nome>Longhena</nome><codice>E673</codice></comune>
<comune><nome>Longi</nome><codice>E674</codice></comune>
<comune><nome>Longiano</nome><codice>E675</codice></comune>
<comune><nome>Longobardi</nome><codice>E677</codice></comune>
<comune><nome>Longobucco</nome><codice>E678</codice></comune>
<comune><nome>Longone al Segrino</nome><codice>E679</codice></comune>
<comune><nome>Longone Sabino</nome><codice>E681</codice></comune>
<comune><nome>Lonigo</nome><codice>E682</codice></comune>
<comune><nome>Loranzè</nome><codice>E683</codice></comune>
<comune><nome>Loreggia</nome><codice>E684</codice></comune>
<comune><nome>Loreglia</nome><codice>E685</codice></comune>
<comune><nome>Lorenzago di Cadore</nome><codice>E687</codice></comune>
<comune><nome>Lorenzana</nome><codice>E688</codice></comune>
<comune><nome>Loreo</nome><codice>E689</codice></comune>
<comune><nome>Loreto</nome><codice>E690</codice></comune>
<comune><nome>Loreto Aprutino</nome><codice>E691</codice></comune>
<comune><nome>Loria</nome><codice>E692</codice></comune>
<comune><nome>Loro Ciuffenna</nome><codice>E693</codice></comune>
<comune><nome>Loro Piceno</nome><codice>E694</codice></comune>
<comune><nome>Lorsica</nome><codice>E695</codice></comune>
<comune><nome>Losine</nome><codice>E698</codice></comune>
<comune><nome>Lotzorai</nome><codice>E700</codice></comune>
<comune><nome>Lovere</nome><codice>E704</codice></comune>
<comune><nome>Lovero</nome><codice>E705</codice></comune>
<comune><nome>Lozio</nome><codice>E706</codice></comune>
<comune><nome>Lozza</nome><codice>E707</codice></comune>
<comune><nome>Lozzo Atestino</nome><codice>E709</codice></comune>
<comune><nome>Lozzo di Cadore</nome><codice>E708</codice></comune>
<comune><nome>Lozzolo</nome><codice>E711</codice></comune>
<comune><nome>Lu</nome><codice>E712</codice></comune>
<comune><nome>Lubriano</nome><codice>E713</codice></comune>
<comune><nome>Lucca</nome><codice>E715</codice></comune>
<comune><nome>Lucca Sicula</nome><codice>E714</codice></comune>
<comune><nome>Lucera</nome><codice>E716</codice></comune>
<comune><nome>Lucignano</nome><codice>E718</codice></comune>
<comune><nome>Lucinasco</nome><codice>E719</codice></comune>
<comune><nome>Lucito</nome><codice>E722</codice></comune>
<comune><nome>Luco dei Marsi</nome><codice>E723</codice></comune>
<comune><nome>Lucoli</nome><codice>E724</codice></comune>
<comune><nome>Lugagnano Val D'Arda</nome><codice>E726</codice></comune>
<comune><nome>Lugnacco</nome><codice>E727</codice></comune>
<comune><nome>Lugnano in Teverina</nome><codice>E729</codice></comune>
<comune><nome>Lugo</nome><codice>E730</codice></comune>
<comune><nome>Lugo di Vicenza</nome><codice>E731</codice></comune>
<comune><nome>Luino</nome><codice>E734</codice></comune>
<comune><nome>Luisago</nome><codice>E735</codice></comune>
<comune><nome>Lula</nome><codice>E736</codice></comune>
<comune><nome>Lumarzo</nome><codice>E737</codice></comune>
<comune><nome>Lumezzane</nome><codice>E738</codice></comune>
<comune><nome>Lunamatrona</nome><codice>E742</codice></comune>
<comune><nome>Lunano</nome><codice>E743</codice></comune>
<comune><nome>Lungavilla</nome><codice>B387</codice></comune>
<comune><nome>Lungro</nome><codice>E745</codice></comune>
<comune><nome>Luogosano</nome><codice>E746</codice></comune>
<comune><nome>Luogosanto</nome><codice>E747</codice></comune>
<comune><nome>Lupara</nome><codice>E748</codice></comune>
<comune><nome>Lurago d'Erba</nome><codice>E749</codice></comune>
<comune><nome>Lurago Marinone</nome><codice>E750</codice></comune>
<comune><nome>Lurano</nome><codice>E751</codice></comune>
<comune><nome>Luras</nome><codice>E752</codice></comune>
<comune><nome>Lurate Caccivio</nome><codice>E753</codice></comune>
<comune><nome>Lusciano</nome><codice>E754</codice></comune>
<comune><nome>Luserna</nome><codice>E757</codice></comune>
<comune><nome>Luserna San Giovanni</nome><codice>E758</codice></comune>
<comune><nome>Lusernetta</nome><codice>E759</codice></comune>
<comune><nome>Lusevera</nome><codice>E760</codice></comune>
<comune><nome>Lusia</nome><codice>E761</codice></comune>
<comune><nome>Lusiana</nome><codice>E762</codice></comune>
<comune><nome>Lusigliè</nome><codice>E763</codice></comune>
<comune><nome>Luson</nome><codice>E764</codice></comune>
<comune><nome>Lustra</nome><codice>E767</codice></comune>
<comune><nome>Luvinate</nome><codice>E769</codice></comune>
<comune><nome>Luzzana</nome><codice>E770</codice></comune>
<comune><nome>Luzzara</nome><codice>E772</codice></comune>
<comune><nome>Luzzi</nome><codice>E773</codice></comune>
<comune><nome>Maccagno</nome><codice>E775</codice></comune>
<comune><nome>Maccastorna</nome><codice>E777</codice></comune>
<comune><nome>Macchia d'Isernia</nome><codice>E778</codice></comune>
<comune><nome>Macchia Valfortore</nome><codice>E780</codice></comune>
<comune><nome>Macchiagodena</nome><codice>E779</codice></comune>
<comune><nome>Macello</nome><codice>E782</codice></comune>
<comune><nome>Macerata</nome><codice>E783</codice></comune>
<comune><nome>Macerata Campania</nome><codice>E784</codice></comune>
<comune><nome>Macerata Feltria</nome><codice>E785</codice></comune>
<comune><nome>Macherio</nome><codice>E786</codice></comune>
<comune><nome>Maclodio</nome><codice>E787</codice></comune>
<comune><nome>Macomer</nome><codice>E788</codice></comune>
<comune><nome>Macra</nome><codice>E789</codice></comune>
<comune><nome>Macugnaga</nome><codice>E790</codice></comune>
<comune><nome>Maddaloni</nome><codice>E791</codice></comune>
<comune><nome>Madesimo</nome><codice>E342</codice></comune>
<comune><nome>Madignano</nome><codice>E793</codice></comune>
<comune><nome>Madone</nome><codice>E794</codice></comune>
<comune><nome>Madonna del Sasso</nome><codice>E795</codice></comune>
<comune><nome>Maenza</nome><codice>E798</codice></comune>
<comune><nome>Mafalda</nome><codice>E799</codice></comune>
<comune><nome>Magasa</nome><codice>E800</codice></comune>
<comune><nome>Magenta</nome><codice>E801</codice></comune>
<comune><nome>Maggiora</nome><codice>E803</codice></comune>
<comune><nome>Magherno</nome><codice>E804</codice></comune>
<comune><nome>Magione</nome><codice>E805</codice></comune>
<comune><nome>Magisano</nome><codice>E806</codice></comune>
<comune><nome>Magliano Alfieri</nome><codice>E809</codice></comune>
<comune><nome>Magliano Alpi</nome><codice>E808</codice></comune>
<comune><nome>Magliano de' Marsi</nome><codice>E811</codice></comune>
<comune><nome>Magliano di Tenna</nome><codice>E807</codice></comune>
<comune><nome>Magliano in Toscana</nome><codice>E810</codice></comune>
<comune><nome>Magliano Romano</nome><codice>E813</codice></comune>
<comune><nome>Magliano Sabina</nome><codice>E812</codice></comune>
<comune><nome>Magliano Vetere</nome><codice>E814</codice></comune>
<comune><nome>Maglie</nome><codice>E815</codice></comune>
<comune><nome>Magliolo</nome><codice>E816</codice></comune>
<comune><nome>Maglione</nome><codice>E817</codice></comune>
<comune><nome>Magnacavallo</nome><codice>E818</codice></comune>
<comune><nome>Magnago</nome><codice>E819</codice></comune>
<comune><nome>Magnano</nome><codice>E821</codice></comune>
<comune><nome>Magnano in Riviera</nome><codice>E820</codice></comune>
<comune><nome>Magomadas</nome><codice>E825</codice></comune>
<comune><nome>Magrè sulla Strada del Vino</nome><codice>E829</codice></comune>
<comune><nome>Magreglio</nome><codice>E830</codice></comune>
<comune><nome>Maida</nome><codice>E834</codice></comune>
<comune><nome>Maierà</nome><codice>E835</codice></comune>
<comune><nome>Maierato</nome><codice>E836</codice></comune>
<comune><nome>Maiolati Spontini</nome><codice>E837</codice></comune>
<comune><nome>Maiolo</nome><codice>E838</codice></comune>
<comune><nome>Maiori</nome><codice>E839</codice></comune>
<comune><nome>Mairago</nome><codice>E840</codice></comune>
<comune><nome>Mairano</nome><codice>E841</codice></comune>
<comune><nome>Maissana</nome><codice>E842</codice></comune>
<comune><nome>Majano</nome><codice>E833</codice></comune>
<comune><nome>Malagnino</nome><codice>E843</codice></comune>
<comune><nome>Malalbergo</nome><codice>E844</codice></comune>
<comune><nome>Malborghetto Valbruna</nome><codice>E847</codice></comune>
<comune><nome>Malcesine</nome><codice>E848</codice></comune>
<comune><nome>Malè</nome><codice>E850</codice></comune>
<comune><nome>Malegno</nome><codice>E851</codice></comune>
<comune><nome>Maleo</nome><codice>E852</codice></comune>
<comune><nome>Malesco</nome><codice>E853</codice></comune>
<comune><nome>Maletto</nome><codice>E854</codice></comune>
<comune><nome>Malfa</nome><codice>E855</codice></comune>
<comune><nome>Malgesso</nome><codice>E856</codice></comune>
<comune><nome>Malgrate</nome><codice>E858</codice></comune>
<comune><nome>Malito</nome><codice>E859</codice></comune>
<comune><nome>Mallare</nome><codice>E860</codice></comune>
<comune><nome>Malles Venosta</nome><codice>E862</codice></comune>
<comune><nome>Malnate</nome><codice>E863</codice></comune>
<comune><nome>Malo</nome><codice>E864</codice></comune>
<comune><nome>Malonno</nome><codice>E865</codice></comune>
<comune><nome>Malosco</nome><codice>E866</codice></comune>
<comune><nome>Maltignano</nome><codice>E868</codice></comune>
<comune><nome>Malvagna</nome><codice>E869</codice></comune>
<comune><nome>Malvicino</nome><codice>E870</codice></comune>
<comune><nome>Malvito</nome><codice>E872</codice></comune>
<comune><nome>Mammola</nome><codice>E873</codice></comune>
<comune><nome>Mamoiada</nome><codice>E874</codice></comune>
<comune><nome>Manciano</nome><codice>E875</codice></comune>
<comune><nome>Mandanici</nome><codice>E876</codice></comune>
<comune><nome>Mandas</nome><codice>E877</codice></comune>
<comune><nome>Mandatoriccio</nome><codice>E878</codice></comune>
<comune><nome>Mandela</nome><codice>B632</codice></comune>
<comune><nome>Mandello del Lario</nome><codice>E879</codice></comune>
<comune><nome>Mandello Vitta</nome><codice>E880</codice></comune>
<comune><nome>Manduria</nome><codice>E882</codice></comune>
<comune><nome>Manerba del Garda</nome><codice>E883</codice></comune>
<comune><nome>Manerbio</nome><codice>E884</codice></comune>
<comune><nome>Manfredonia</nome><codice>E885</codice></comune>
<comune><nome>Mango</nome><codice>E887</codice></comune>
<comune><nome>Mangone</nome><codice>E888</codice></comune>
<comune><nome>Maniace</nome><codice>M283</codice></comune>
<comune><nome>Maniago</nome><codice>E889</codice></comune>
<comune><nome>Manocalzati</nome><codice>E891</codice></comune>
<comune><nome>Manoppello</nome><codice>E892</codice></comune>
<comune><nome>Mansuè</nome><codice>E893</codice></comune>
<comune><nome>Manta</nome><codice>E894</codice></comune>
<comune><nome>Mantello</nome><codice>E896</codice></comune>
<comune><nome>Mantova</nome><codice>E897</codice></comune>
<comune><nome>Manzano</nome><codice>E899</codice></comune>
<comune><nome>Manziana</nome><codice>E900</codice></comune>
<comune><nome>Mapello</nome><codice>E901</codice></comune>
<comune><nome>Mara</nome><codice>E902</codice></comune>
<comune><nome>Maracalagonis</nome><codice>E903</codice></comune>
<comune><nome>Maranello</nome><codice>E904</codice></comune>
<comune><nome>Marano di Napoli</nome><codice>E906</codice></comune>
<comune><nome>Marano di Valpolicella</nome><codice>E911</codice></comune>
<comune><nome>Marano Equo</nome><codice>E908</codice></comune>
<comune><nome>Marano Lagunare</nome><codice>E910</codice></comune>
<comune><nome>Marano Marchesato</nome><codice>E914</codice></comune>
<comune><nome>Marano Principato</nome><codice>E915</codice></comune>
<comune><nome>Marano sul Panaro</nome><codice>E905</codice></comune>
<comune><nome>Marano Ticino</nome><codice>E907</codice></comune>
<comune><nome>Marano Vicentino</nome><codice>E912</codice></comune>
<comune><nome>Maranzana</nome><codice>E917</codice></comune>
<comune><nome>Maratea</nome><codice>E919</codice></comune>
<comune><nome>Marcallo con Casone</nome><codice>E921</codice></comune>
<comune><nome>Marcaria</nome><codice>E922</codice></comune>
<comune><nome>Marcedusa</nome><codice>E923</codice></comune>
<comune><nome>Marcellina</nome><codice>E924</codice></comune>
<comune><nome>Marcellinara</nome><codice>E925</codice></comune>
<comune><nome>Marcetelli</nome><codice>E927</codice></comune>
<comune><nome>Marcheno</nome><codice>E928</codice></comune>
<comune><nome>Marchirolo</nome><codice>E929</codice></comune>
<comune><nome>Marciana</nome><codice>E930</codice></comune>
<comune><nome>Marciana Marina</nome><codice>E931</codice></comune>
<comune><nome>Marcianise</nome><codice>E932</codice></comune>
<comune><nome>Marciano della Chiana</nome><codice>E933</codice></comune>
<comune><nome>Marcignago</nome><codice>E934</codice></comune>
<comune><nome>Marcon</nome><codice>E936</codice></comune>
<comune><nome>Marebbe</nome><codice>E938</codice></comune>
<comune><nome>Marene</nome><codice>E939</codice></comune>
<comune><nome>Mareno di Piave</nome><codice>E940</codice></comune>
<comune><nome>Marentino</nome><codice>E941</codice></comune>
<comune><nome>Maretto</nome><codice>E944</codice></comune>
<comune><nome>Margarita</nome><codice>E945</codice></comune>
<comune><nome>Margherita di Savoia</nome><codice>E946</codice></comune>
<comune><nome>Margno</nome><codice>E947</codice></comune>
<comune><nome>Mariana Mantovana</nome><codice>E949</codice></comune>
<comune><nome>Mariano Comense</nome><codice>E951</codice></comune>
<comune><nome>Mariano del Friuli</nome><codice>E952</codice></comune>
<comune><nome>Marianopoli</nome><codice>E953</codice></comune>
<comune><nome>Mariglianella</nome><codice>E954</codice></comune>
<comune><nome>Marigliano</nome><codice>E955</codice></comune>
<comune><nome>Marina di Gioiosa Ionica</nome><codice>E956</codice></comune>
<comune><nome>Marineo</nome><codice>E957</codice></comune>
<comune><nome>Marino</nome><codice>E958</codice></comune>
<comune><nome>Marlengo</nome><codice>E959</codice></comune>
<comune><nome>Marliana</nome><codice>E960</codice></comune>
<comune><nome>Marmentino</nome><codice>E961</codice></comune>
<comune><nome>Marmirolo</nome><codice>E962</codice></comune>
<comune><nome>Marmora</nome><codice>E963</codice></comune>
<comune><nome>Marnate</nome><codice>E965</codice></comune>
<comune><nome>Marone</nome><codice>E967</codice></comune>
<comune><nome>Maropati</nome><codice>E968</codice></comune>
<comune><nome>Marostica</nome><codice>E970</codice></comune>
<comune><nome>Marradi</nome><codice>E971</codice></comune>
<comune><nome>Marrubiu</nome><codice>E972</codice></comune>
<comune><nome>Marsaglia</nome><codice>E973</codice></comune>
<comune><nome>Marsala</nome><codice>E974</codice></comune>
<comune><nome>Marsciano</nome><codice>E975</codice></comune>
<comune><nome>Marsico Nuovo</nome><codice>E976</codice></comune>
<comune><nome>Marsicovetere</nome><codice>E977</codice></comune>
<comune><nome>Marta</nome><codice>E978</codice></comune>
<comune><nome>Martano</nome><codice>E979</codice></comune>
<comune><nome>Martellago</nome><codice>E980</codice></comune>
<comune><nome>Martello</nome><codice>E981</codice></comune>
<comune><nome>Martignacco</nome><codice>E982</codice></comune>
<comune><nome>Martignana di Po</nome><codice>E983</codice></comune>
<comune><nome>Martignano</nome><codice>E984</codice></comune>
<comune><nome>Martina Franca</nome><codice>E986</codice></comune>
<comune><nome>Martinengo</nome><codice>E987</codice></comune>
<comune><nome>Martiniana Po</nome><codice>E988</codice></comune>
<comune><nome>Martinsicuro</nome><codice>E989</codice></comune>
<comune><nome>Martirano</nome><codice>E990</codice></comune>
<comune><nome>Martirano Lombardo</nome><codice>E991</codice></comune>
<comune><nome>Martis</nome><codice>E992</codice></comune>
<comune><nome>Martone</nome><codice>E993</codice></comune>
<comune><nome>Marudo</nome><codice>E994</codice></comune>
<comune><nome>Maruggio</nome><codice>E995</codice></comune>
<comune><nome>Marzabotto</nome><codice>B689</codice></comune>
<comune><nome>Marzano</nome><codice>E999</codice></comune>
<comune><nome>Marzano Appio</nome><codice>E998</codice></comune>
<comune><nome>Marzano di Nola</nome><codice>E997</codice></comune>
<comune><nome>Marzi</nome><codice>F001</codice></comune>
<comune><nome>Marzio</nome><codice>F002</codice></comune>
<comune><nome>Masainas</nome><codice>M270</codice></comune>
<comune><nome>Masate</nome><codice>F003</codice></comune>
<comune><nome>Mascali</nome><codice>F004</codice></comune>
<comune><nome>Mascalucia</nome><codice>F005</codice></comune>
<comune><nome>Maschito</nome><codice>F006</codice></comune>
<comune><nome>Masciago Primo</nome><codice>F007</codice></comune>
<comune><nome>Maser</nome><codice>F009</codice></comune>
<comune><nome>Masera</nome><codice>F010</codice></comune>
<comune><nome>Maserà di Padova</nome><codice>F011</codice></comune>
<comune><nome>Maserada sul Piave</nome><codice>F012</codice></comune>
<comune><nome>Masi</nome><codice>F013</codice></comune>
<comune><nome>Masi Torello</nome><codice>F016</codice></comune>
<comune><nome>Masio</nome><codice>F015</codice></comune>
<comune><nome>Maslianico</nome><codice>F017</codice></comune>
<comune><nome>Mason Vicentino</nome><codice>F019</codice></comune>
<comune><nome>Masone</nome><codice>F020</codice></comune>
<comune><nome>Massa</nome><codice>F023</codice></comune>
<comune><nome>Massa d'Albe</nome><codice>F022</codice></comune>
<comune><nome>Massa di Somma</nome><codice>M289</codice></comune>
<comune><nome>Massa e Cozzile</nome><codice>F025</codice></comune>
<comune><nome>Massa Fermana</nome><codice>F021</codice></comune>
<comune><nome>Massa Fiscaglia</nome><codice>F026</codice></comune>
<comune><nome>Massa Lombarda</nome><codice>F029</codice></comune>
<comune><nome>Massa Lubrense</nome><codice>F030</codice></comune>
<comune><nome>Massa Marittima</nome><codice>F032</codice></comune>
<comune><nome>Massa Martana</nome><codice>F024</codice></comune>
<comune><nome>Massafra</nome><codice>F027</codice></comune>
<comune><nome>Massalengo</nome><codice>F028</codice></comune>
<comune><nome>Massanzago</nome><codice>F033</codice></comune>
<comune><nome>Massarosa</nome><codice>F035</codice></comune>
<comune><nome>Massazza</nome><codice>F037</codice></comune>
<comune><nome>Massello</nome><codice>F041</codice></comune>
<comune><nome>Masserano</nome><codice>F042</codice></comune>
<comune><nome>Massignano</nome><codice>F044</codice></comune>
<comune><nome>Massimeno</nome><codice>F045</codice></comune>
<comune><nome>Massimino</nome><codice>F046</codice></comune>
<comune><nome>Massino Visconti</nome><codice>F047</codice></comune>
<comune><nome>Massiola</nome><codice>F048</codice></comune>
<comune><nome>Masullas</nome><codice>F050</codice></comune>
<comune><nome>Matelica</nome><codice>F051</codice></comune>
<comune><nome>Matera</nome><codice>F052</codice></comune>
<comune><nome>Mathi</nome><codice>F053</codice></comune>
<comune><nome>Matino</nome><codice>F054</codice></comune>
<comune><nome>Matrice</nome><codice>F055</codice></comune>
<comune><nome>Mattie</nome><codice>F058</codice></comune>
<comune><nome>Mattinata</nome><codice>F059</codice></comune>
<comune><nome>Mazara del Vallo</nome><codice>F061</codice></comune>
<comune><nome>Mazzano</nome><codice>F063</codice></comune>
<comune><nome>Mazzano Romano</nome><codice>F064</codice></comune>
<comune><nome>Mazzarino</nome><codice>F065</codice></comune>
<comune><nome>Mazzarrà Sant'Andrea</nome><codice>F066</codice></comune>
<comune><nome>Mazzarrone</nome><codice>M271</codice></comune>
<comune><nome>Mazzè</nome><codice>F067</codice></comune>
<comune><nome>Mazzin</nome><codice>F068</codice></comune>
<comune><nome>Mazzo di Valtellina</nome><codice>F070</codice></comune>
<comune><nome>Meana di Susa</nome><codice>F074</codice></comune>
<comune><nome>Meana Sardo</nome><codice>F073</codice></comune>
<comune><nome>Meda</nome><codice>F078</codice></comune>
<comune><nome>Mede</nome><codice>F080</codice></comune>
<comune><nome>Medea</nome><codice>F081</codice></comune>
<comune><nome>Medesano</nome><codice>F082</codice></comune>
<comune><nome>Medicina</nome><codice>F083</codice></comune>
<comune><nome>Mediglia</nome><codice>F084</codice></comune>
<comune><nome>Medolago</nome><codice>F085</codice></comune>
<comune><nome>Medole</nome><codice>F086</codice></comune>
<comune><nome>Medolla</nome><codice>F087</codice></comune>
<comune><nome>Meduna di Livenza</nome><codice>F088</codice></comune>
<comune><nome>Meduno</nome><codice>F089</codice></comune>
<comune><nome>Megliadino San Fidenzio</nome><codice>F091</codice></comune>
<comune><nome>Megliadino San Vitale</nome><codice>F092</codice></comune>
<comune><nome>Meina</nome><codice>F093</codice></comune>
<comune><nome>Mel</nome><codice>F094</codice></comune>
<comune><nome>Melara</nome><codice>F095</codice></comune>
<comune><nome>Melazzo</nome><codice>F096</codice></comune>
<comune><nome>Meldola</nome><codice>F097</codice></comune>
<comune><nome>Mele</nome><codice>F098</codice></comune>
<comune><nome>Melegnano</nome><codice>F100</codice></comune>
<comune><nome>Melendugno</nome><codice>F101</codice></comune>
<comune><nome>Meleti</nome><codice>F102</codice></comune>
<comune><nome>Melfi</nome><codice>F104</codice></comune>
<comune><nome>Melicuccà</nome><codice>F105</codice></comune>
<comune><nome>Melicucco</nome><codice>F106</codice></comune>
<comune><nome>Melilli</nome><codice>F107</codice></comune>
<comune><nome>Melissa</nome><codice>F108</codice></comune>
<comune><nome>Melissano</nome><codice>F109</codice></comune>
<comune><nome>Melito di Napoli</nome><codice>F111</codice></comune>
<comune><nome>Melito di Porto Salvo</nome><codice>F112</codice></comune>
<comune><nome>Melito Irpino</nome><codice>F110</codice></comune>
<comune><nome>Melizzano</nome><codice>F113</codice></comune>
<comune><nome>Melle</nome><codice>F114</codice></comune>
<comune><nome>Mello</nome><codice>F115</codice></comune>
<comune><nome>Melpignano</nome><codice>F117</codice></comune>
<comune><nome>Meltina</nome><codice>F118</codice></comune>
<comune><nome>Melzo</nome><codice>F119</codice></comune>
<comune><nome>Menaggio</nome><codice>F120</codice></comune>
<comune><nome>Menarola</nome><codice>F121</codice></comune>
<comune><nome>Menconico</nome><codice>F122</codice></comune>
<comune><nome>Mendatica</nome><codice>F123</codice></comune>
<comune><nome>Mendicino</nome><codice>F125</codice></comune>
<comune><nome>Menfi</nome><codice>F126</codice></comune>
<comune><nome>Mentana</nome><codice>F127</codice></comune>
<comune><nome>Meolo</nome><codice>F130</codice></comune>
<comune><nome>Merana</nome><codice>F131</codice></comune>
<comune><nome>Merano</nome><codice>F132</codice></comune>
<comune><nome>Merate</nome><codice>F133</codice></comune>
<comune><nome>Mercallo</nome><codice>F134</codice></comune>
<comune><nome>Mercatello sul Metauro</nome><codice>F135</codice></comune>
<comune><nome>Mercatino Conca</nome><codice>F136</codice></comune>
<comune><nome>Mercato San Severino</nome><codice>F138</codice></comune>
<comune><nome>Mercato Saraceno</nome><codice>F139</codice></comune>
<comune><nome>Mercenasco</nome><codice>F140</codice></comune>
<comune><nome>Mercogliano</nome><codice>F141</codice></comune>
<comune><nome>Mereto di Tomba</nome><codice>F144</codice></comune>
<comune><nome>Mergo</nome><codice>F145</codice></comune>
<comune><nome>Mergozzo</nome><codice>F146</codice></comune>
<comune><nome>Merì</nome><codice>F147</codice></comune>
<comune><nome>Merlara</nome><codice>F148</codice></comune>
<comune><nome>Merlino</nome><codice>F149</codice></comune>
<comune><nome>Merone</nome><codice>F151</codice></comune>
<comune><nome>Mesagne</nome><codice>F152</codice></comune>
<comune><nome>Mese</nome><codice>F153</codice></comune>
<comune><nome>Mesenzana</nome><codice>F154</codice></comune>
<comune><nome>Mesero</nome><codice>F155</codice></comune>
<comune><nome>Mesola</nome><codice>F156</codice></comune>
<comune><nome>Mesoraca</nome><codice>F157</codice></comune>
<comune><nome>Messina</nome><codice>F158</codice></comune>
<comune><nome>Mestrino</nome><codice>F161</codice></comune>
<comune><nome>Meta</nome><codice>F162</codice></comune>
<comune><nome>Meugliano</nome><codice>F164</codice></comune>
<comune><nome>Mezzago</nome><codice>F165</codice></comune>
<comune><nome>Mezzana</nome><codice>F168</codice></comune>
<comune><nome>Mezzana Bigli</nome><codice>F170</codice></comune>
<comune><nome>Mezzana Mortigliengo</nome><codice>F167</codice></comune>
<comune><nome>Mezzana Rabattone</nome><codice>F171</codice></comune>
<comune><nome>Mezzane di Sotto</nome><codice>F172</codice></comune>
<comune><nome>Mezzanego</nome><codice>F173</codice></comune>
<comune><nome>Mezzani</nome><codice>F174</codice></comune>
<comune><nome>Mezzanino</nome><codice>F175</codice></comune>
<comune><nome>Mezzano</nome><codice>F176</codice></comune>
<comune><nome>Mezzegra</nome><codice>F181</codice></comune>
<comune><nome>Mezzenile</nome><codice>F182</codice></comune>
<comune><nome>Mezzocorona</nome><codice>F183</codice></comune>
<comune><nome>Mezzojuso</nome><codice>F184</codice></comune>
<comune><nome>Mezzoldo</nome><codice>F186</codice></comune>
<comune><nome>Mezzolombardo</nome><codice>F187</codice></comune>
<comune><nome>Mezzomerico</nome><codice>F188</codice></comune>
<comune><nome>Miagliano</nome><codice>F189</codice></comune>
<comune><nome>Miane</nome><codice>F190</codice></comune>
<comune><nome>Miasino</nome><codice>F191</codice></comune>
<comune><nome>Miazzina</nome><codice>F192</codice></comune>
<comune><nome>Micigliano</nome><codice>F193</codice></comune>
<comune><nome>Miggiano</nome><codice>F194</codice></comune>
<comune><nome>Miglianico</nome><codice>F196</codice></comune>
<comune><nome>Migliarino</nome><codice>F198</codice></comune>
<comune><nome>Migliaro</nome><codice>F199</codice></comune>
<comune><nome>Miglierina</nome><codice>F200</codice></comune>
<comune><nome>Miglionico</nome><codice>F201</codice></comune>
<comune><nome>Mignanego</nome><codice>F202</codice></comune>
<comune><nome>Mignano Monte Lungo</nome><codice>F203</codice></comune>
<comune><nome>Milano</nome><codice>F205</codice></comune>
<comune><nome>Milazzo</nome><codice>F206</codice></comune>
<comune><nome>Milena</nome><codice>E618</codice></comune>
<comune><nome>Mileto</nome><codice>F207</codice></comune>
<comune><nome>Milis</nome><codice>F208</codice></comune>
<comune><nome>Militello in Val di Catania</nome><codice>F209</codice></comune>
<comune><nome>Militello Rosmarino</nome><codice>F210</codice></comune>
<comune><nome>Millesimo</nome><codice>F213</codice></comune>
<comune><nome>Milo</nome><codice>F214</codice></comune>
<comune><nome>Milzano</nome><codice>F216</codice></comune>
<comune><nome>Mineo</nome><codice>F217</codice></comune>
<comune><nome>Minerbe</nome><codice>F218</codice></comune>
<comune><nome>Minerbio</nome><codice>F219</codice></comune>
<comune><nome>Minervino di Lecce</nome><codice>F221</codice></comune>
<comune><nome>Minervino Murge</nome><codice>F220</codice></comune>
<comune><nome>Minori</nome><codice>F223</codice></comune>
<comune><nome>Minturno</nome><codice>F224</codice></comune>
<comune><nome>Minucciano</nome><codice>F225</codice></comune>
<comune><nome>Mioglia</nome><codice>F226</codice></comune>
<comune><nome>Mira</nome><codice>F229</codice></comune>
<comune><nome>Mirabella Eclano</nome><codice>F230</codice></comune>
<comune><nome>Mirabella Imbaccari</nome><codice>F231</codice></comune>
<comune><nome>Mirabello</nome><codice>F235</codice></comune>
<comune><nome>Mirabello Monferrato</nome><codice>F232</codice></comune>
<comune><nome>Mirabello Sannitico</nome><codice>F233</codice></comune>
<comune><nome>Miradolo Terme</nome><codice>F238</codice></comune>
<comune><nome>Miranda</nome><codice>F239</codice></comune>
<comune><nome>Mirandola</nome><codice>F240</codice></comune>
<comune><nome>Mirano</nome><codice>F241</codice></comune>
<comune><nome>Mirto</nome><codice>F242</codice></comune>
<comune><nome>Misano Adriatico</nome><codice>F244</codice></comune>
<comune><nome>Misano di Gera d'Adda</nome><codice>F243</codice></comune>
<comune><nome>Misilmeri</nome><codice>F246</codice></comune>
<comune><nome>Misinto</nome><codice>F247</codice></comune>
<comune><nome>Missaglia</nome><codice>F248</codice></comune>
<comune><nome>Missanello</nome><codice>F249</codice></comune>
<comune><nome>Misterbianco</nome><codice>F250</codice></comune>
<comune><nome>Mistretta</nome><codice>F251</codice></comune>
<comune><nome>Moasca</nome><codice>F254</codice></comune>
<comune><nome>Moconesi</nome><codice>F256</codice></comune>
<comune><nome>Modena</nome><codice>F257</codice></comune>
<comune><nome>Modica</nome><codice>F258</codice></comune>
<comune><nome>Modigliana</nome><codice>F259</codice></comune>
<comune><nome>Modolo</nome><codice>F261</codice></comune>
<comune><nome>Modugno</nome><codice>F262</codice></comune>
<comune><nome>Moena</nome><codice>F263</codice></comune>
<comune><nome>Moggio</nome><codice>F265</codice></comune>
<comune><nome>Moggio Udinese</nome><codice>F266</codice></comune>
<comune><nome>Moglia</nome><codice>F267</codice></comune>
<comune><nome>Mogliano</nome><codice>F268</codice></comune>
<comune><nome>Mogliano Veneto</nome><codice>F269</codice></comune>
<comune><nome>Mogorella</nome><codice>F270</codice></comune>
<comune><nome>Mogoro</nome><codice>F272</codice></comune>
<comune><nome>Moiano</nome><codice>F274</codice></comune>
<comune><nome>Moimacco</nome><codice>F275</codice></comune>
<comune><nome>Moio Alcantara</nome><codice>F277</codice></comune>
<comune><nome>Moio de' Calvi</nome><codice>F276</codice></comune>
<comune><nome>Moio della Civitella</nome><codice>F278</codice></comune>
<comune><nome>Moiola</nome><codice>F279</codice></comune>
<comune><nome>Mola di Bari</nome><codice>F280</codice></comune>
<comune><nome>Molare</nome><codice>F281</codice></comune>
<comune><nome>Molazzana</nome><codice>F283</codice></comune>
<comune><nome>Molfetta</nome><codice>F284</codice></comune>
<comune><nome>Molina Aterno</nome><codice>M255</codice></comune>
<comune><nome>Molinara</nome><codice>F287</codice></comune>
<comune><nome>Molinella</nome><codice>F288</codice></comune>
<comune><nome>Molini di Triora</nome><codice>F290</codice></comune>
<comune><nome>Molino dei Torti</nome><codice>F293</codice></comune>
<comune><nome>Molise</nome><codice>F294</codice></comune>
<comune><nome>Moliterno</nome><codice>F295</codice></comune>
<comune><nome>Mollia</nome><codice>F297</codice></comune>
<comune><nome>Molochio</nome><codice>F301</codice></comune>
<comune><nome>Molteno</nome><codice>F304</codice></comune>
<comune><nome>Moltrasio</nome><codice>F305</codice></comune>
<comune><nome>Molvena</nome><codice>F306</codice></comune>
<comune><nome>Molveno</nome><codice>F307</codice></comune>
<comune><nome>Mombaldone</nome><codice>F308</codice></comune>
<comune><nome>Mombarcaro</nome><codice>F309</codice></comune>
<comune><nome>Mombaroccio</nome><codice>F310</codice></comune>
<comune><nome>Mombaruzzo</nome><codice>F311</codice></comune>
<comune><nome>Mombasiglio</nome><codice>F312</codice></comune>
<comune><nome>Mombello di Torino</nome><codice>F315</codice></comune>
<comune><nome>Mombello Monferrato</nome><codice>F313</codice></comune>
<comune><nome>Mombercelli</nome><codice>F316</codice></comune>
<comune><nome>Momo</nome><codice>F317</codice></comune>
<comune><nome>Mompantero</nome><codice>F318</codice></comune>
<comune><nome>Mompeo</nome><codice>F319</codice></comune>
<comune><nome>Momperone</nome><codice>F320</codice></comune>
<comune><nome>Monacilioni</nome><codice>F322</codice></comune>
<comune><nome>Monale</nome><codice>F323</codice></comune>
<comune><nome>Monasterace</nome><codice>F324</codice></comune>
<comune><nome>Monastero Bormida</nome><codice>F325</codice></comune>
<comune><nome>Monastero di Lanzo</nome><codice>F327</codice></comune>
<comune><nome>Monastero di Vasco</nome><codice>F326</codice></comune>
<comune><nome>Monasterolo Casotto</nome><codice>F329</codice></comune>
<comune><nome>Monasterolo del Castello</nome><codice>F328</codice></comune>
<comune><nome>Monasterolo di Savigliano</nome><codice>F330</codice></comune>
<comune><nome>Monastier di Treviso</nome><codice>F332</codice></comune>
<comune><nome>Monastir</nome><codice>F333</codice></comune>
<comune><nome>Moncalieri</nome><codice>F335</codice></comune>
<comune><nome>Moncalvo</nome><codice>F336</codice></comune>
<comune><nome>Moncenisio</nome><codice>D553</codice></comune>
<comune><nome>Moncestino</nome><codice>F337</codice></comune>
<comune><nome>Monchiero</nome><codice>F338</codice></comune>
<comune><nome>Monchio delle Corti</nome><codice>F340</codice></comune>
<comune><nome>Monclassico</nome><codice>F341</codice></comune>
<comune><nome>Moncrivello</nome><codice>F342</codice></comune>
<comune><nome>Moncucco Torinese</nome><codice>F343</codice></comune>
<comune><nome>Mondaino</nome><codice>F346</codice></comune>
<comune><nome>Mondavio</nome><codice>F347</codice></comune>
<comune><nome>Mondolfo</nome><codice>F348</codice></comune>
<comune><nome>Mondovì</nome><codice>F351</codice></comune>
<comune><nome>Mondragone</nome><codice>F352</codice></comune>
<comune><nome>Moneglia</nome><codice>F354</codice></comune>
<comune><nome>Monesiglio</nome><codice>F355</codice></comune>
<comune><nome>Monfalcone</nome><codice>F356</codice></comune>
<comune><nome>Monforte d'Alba</nome><codice>F358</codice></comune>
<comune><nome>Monforte San Giorgio</nome><codice>F359</codice></comune>
<comune><nome>Monfumo</nome><codice>F360</codice></comune>
<comune><nome>Mongardino</nome><codice>F361</codice></comune>
<comune><nome>Monghidoro</nome><codice>F363</codice></comune>
<comune><nome>Mongiana</nome><codice>F364</codice></comune>
<comune><nome>Mongiardino Ligure</nome><codice>F365</codice></comune>
<comune><nome>Mongiuffi Melia</nome><codice>F368</codice></comune>
<comune><nome>Mongrando</nome><codice>F369</codice></comune>
<comune><nome>Mongrassano</nome><codice>F370</codice></comune>
<comune><nome>Monguelfo-Tesido</nome><codice>F371</codice></comune>
<comune><nome>Monguzzo</nome><codice>F372</codice></comune>
<comune><nome>Moniga del Garda</nome><codice>F373</codice></comune>
<comune><nome>Monleale</nome><codice>F374</codice></comune>
<comune><nome>Monno</nome><codice>F375</codice></comune>
<comune><nome>Monopoli</nome><codice>F376</codice></comune>
<comune><nome>Monreale</nome><codice>F377</codice></comune>
<comune><nome>Monrupino</nome><codice>F378</codice></comune>
<comune><nome>Monsampietro Morico</nome><codice>F379</codice></comune>
<comune><nome>Monsampolo del Tronto</nome><codice>F380</codice></comune>
<comune><nome>Monsano</nome><codice>F381</codice></comune>
<comune><nome>Monselice</nome><codice>F382</codice></comune>
<comune><nome>Monserrato</nome><codice>F383</codice></comune>
<comune><nome>Monsummano Terme</nome><codice>F384</codice></comune>
<comune><nome>Montà</nome><codice>F385</codice></comune>
<comune><nome>Montabone</nome><codice>F386</codice></comune>
<comune><nome>Montacuto</nome><codice>F387</codice></comune>
<comune><nome>Montafia</nome><codice>F390</codice></comune>
<comune><nome>Montagano</nome><codice>F391</codice></comune>
<comune><nome>Montagna</nome><codice>F392</codice></comune>
<comune><nome>Montagna in Valtellina</nome><codice>F393</codice></comune>
<comune><nome>Montagnana</nome><codice>F394</codice></comune>
<comune><nome>Montagnareale</nome><codice>F395</codice></comune>
<comune><nome>Montagne</nome><codice>F396</codice></comune>
<comune><nome>Montaguto</nome><codice>F397</codice></comune>
<comune><nome>Montaione</nome><codice>F398</codice></comune>
<comune><nome>Montalbano Elicona</nome><codice>F400</codice></comune>
<comune><nome>Montalbano Jonico</nome><codice>F399</codice></comune>
<comune><nome>Montalcino</nome><codice>F402</codice></comune>
<comune><nome>Montaldeo</nome><codice>F403</codice></comune>
<comune><nome>Montaldo Bormida</nome><codice>F404</codice></comune>
<comune><nome>Montaldo di Mondovì</nome><codice>F405</codice></comune>
<comune><nome>Montaldo Roero</nome><codice>F408</codice></comune>
<comune><nome>Montaldo Scarampi</nome><codice>F409</codice></comune>
<comune><nome>Montaldo Torinese</nome><codice>F407</codice></comune>
<comune><nome>Montale</nome><codice>F410</codice></comune>
<comune><nome>Montalenghe</nome><codice>F411</codice></comune>
<comune><nome>Montallegro</nome><codice>F414</codice></comune>
<comune><nome>Montalto delle Marche</nome><codice>F415</codice></comune>
<comune><nome>Montalto di Castro</nome><codice>F419</codice></comune>
<comune><nome>Montalto Dora</nome><codice>F420</codice></comune>
<comune><nome>Montalto Ligure</nome><codice>F406</codice></comune>
<comune><nome>Montalto Pavese</nome><codice>F417</codice></comune>
<comune><nome>Montalto Uffugo</nome><codice>F416</codice></comune>
<comune><nome>Montanaro</nome><codice>F422</codice></comune>
<comune><nome>Montanaso Lombardo</nome><codice>F423</codice></comune>
<comune><nome>Montanera</nome><codice>F424</codice></comune>
<comune><nome>Montano Antilia</nome><codice>F426</codice></comune>
<comune><nome>Montano Lucino</nome><codice>F427</codice></comune>
<comune><nome>Montappone</nome><codice>F428</codice></comune>
<comune><nome>Montaquila</nome><codice>F429</codice></comune>
<comune><nome>Montasola</nome><codice>F430</codice></comune>
<comune><nome>Montauro</nome><codice>F432</codice></comune>
<comune><nome>Montazzoli</nome><codice>F433</codice></comune>
<comune><nome>Monte Argentario</nome><codice>F437</codice></comune>
<comune><nome>Monte Castello di Vibio</nome><codice>F456</codice></comune>
<comune><nome>Monte Cavallo</nome><codice>F460</codice></comune>
<comune><nome>Monte Cerignone</nome><codice>F467</codice></comune>
<comune><nome>Monte Colombo</nome><codice>F476</codice></comune>
<comune><nome>Monte Compatri</nome><codice>F477</codice></comune>
<comune><nome>Monte Cremasco</nome><codice>F434</codice></comune>
<comune><nome>Monte di Malo</nome><codice>F486</codice></comune>
<comune><nome>Monte di Procida</nome><codice>F488</codice></comune>
<comune><nome>Monte Giberto</nome><codice>F517</codice></comune>
<comune><nome>Monte Grimano Terme</nome><codice>F524</codice></comune>
<comune><nome>Monte Isola</nome><codice>F532</codice></comune>
<comune><nome>Monte Marenzo</nome><codice>F561</codice></comune>
<comune><nome>Monte Porzio</nome><codice>F589</codice></comune>
<comune><nome>Monte Porzio Catone</nome><codice>F590</codice></comune>
<comune><nome>Monte Rinaldo</nome><codice>F599</codice></comune>
<comune><nome>Monte Roberto</nome><codice>F600</codice></comune>
<comune><nome>Monte Romano</nome><codice>F603</codice></comune>
<comune><nome>Monte San Biagio</nome><codice>F616</codice></comune>
<comune><nome>Monte San Giacomo</nome><codice>F618</codice></comune>
<comune><nome>Monte San Giovanni Campano</nome><codice>F620</codice></comune>
<comune><nome>Monte San Giovanni in Sabina</nome><codice>F619</codice></comune>
<comune><nome>Monte San Giusto</nome><codice>F621</codice></comune>
<comune><nome>Monte San Martino</nome><codice>F622</codice></comune>
<comune><nome>Monte San Pietrangeli</nome><codice>F626</codice></comune>
<comune><nome>Monte San Pietro</nome><codice>F627</codice></comune>
<comune><nome>Monte San Savino</nome><codice>F628</codice></comune>
<comune><nome>Monte San Vito</nome><codice>F634</codice></comune>
<comune><nome>Monte Santa Maria Tiberina</nome><codice>F629</codice></comune>
<comune><nome>Monte Sant'Angelo</nome><codice>F631</codice></comune>
<comune><nome>Monte Urano</nome><codice>F653</codice></comune>
<comune><nome>Monte Vidon Combatte</nome><codice>F664</codice></comune>
<comune><nome>Monte Vidon Corrado</nome><codice>F665</codice></comune>
<comune><nome>Montebello della Battaglia</nome><codice>F440</codice></comune>
<comune><nome>Montebello di Bertona</nome><codice>F441</codice></comune>
<comune><nome>Montebello Ionico</nome><codice>D746</codice></comune>
<comune><nome>Montebello sul Sangro</nome><codice>B268</codice></comune>
<comune><nome>Montebello Vicentino</nome><codice>F442</codice></comune>
<comune><nome>Montebelluna</nome><codice>F443</codice></comune>
<comune><nome>Montebruno</nome><codice>F445</codice></comune>
<comune><nome>Montebuono</nome><codice>F446</codice></comune>
<comune><nome>Montecalvo in Foglia</nome><codice>F450</codice></comune>
<comune><nome>Montecalvo Irpino</nome><codice>F448</codice></comune>
<comune><nome>Montecalvo Versiggia</nome><codice>F449</codice></comune>
<comune><nome>Montecarlo</nome><codice>F452</codice></comune>
<comune><nome>Montecarotto</nome><codice>F453</codice></comune>
<comune><nome>Montecassiano</nome><codice>F454</codice></comune>
<comune><nome>Montecastello</nome><codice>F455</codice></comune>
<comune><nome>Montecastrilli</nome><codice>F457</codice></comune>
<comune><nome>Montecatini Val di Cecina</nome><codice>F458</codice></comune>
<comune><nome>Montecatini-Terme</nome><codice>A561</codice></comune>
<comune><nome>Montecchia di Crosara</nome><codice>F461</codice></comune>
<comune><nome>Montecchio</nome><codice>F462</codice></comune>
<comune><nome>Montecchio Emilia</nome><codice>F463</codice></comune>
<comune><nome>Montecchio Maggiore</nome><codice>F464</codice></comune>
<comune><nome>Montecchio Precalcino</nome><codice>F465</codice></comune>
<comune><nome>Montechiaro d'Acqui</nome><codice>F469</codice></comune>
<comune><nome>Montechiaro d'Asti</nome><codice>F468</codice></comune>
<comune><nome>Montechiarugolo</nome><codice>F473</codice></comune>
<comune><nome>Monteciccardo</nome><codice>F474</codice></comune>
<comune><nome>Montecilfone</nome><codice>F475</codice></comune>
<comune><nome>Montecopiolo</nome><codice>F478</codice></comune>
<comune><nome>Montecorice</nome><codice>F479</codice></comune>
<comune><nome>Montecorvino Pugliano</nome><codice>F480</codice></comune>
<comune><nome>Montecorvino Rovella</nome><codice>F481</codice></comune>
<comune><nome>Montecosaro</nome><codice>F482</codice></comune>
<comune><nome>Montecrestese</nome><codice>F483</codice></comune>
<comune><nome>Montecreto</nome><codice>F484</codice></comune>
<comune><nome>Montedinove</nome><codice>F487</codice></comune>
<comune><nome>Montedoro</nome><codice>F489</codice></comune>
<comune><nome>Montefalcione</nome><codice>F491</codice></comune>
<comune><nome>Montefalco</nome><codice>F492</codice></comune>
<comune><nome>Montefalcone Appennino</nome><codice>F493</codice></comune>
<comune><nome>Montefalcone di Val Fortore</nome><codice>F494</codice></comune>
<comune><nome>Montefalcone nel Sannio</nome><codice>F495</codice></comune>
<comune><nome>Montefano</nome><codice>F496</codice></comune>
<comune><nome>Montefelcino</nome><codice>F497</codice></comune>
<comune><nome>Monteferrante</nome><codice>F498</codice></comune>
<comune><nome>Montefiascone</nome><codice>F499</codice></comune>
<comune><nome>Montefino</nome><codice>F500</codice></comune>
<comune><nome>Montefiore Conca</nome><codice>F502</codice></comune>
<comune><nome>Montefiore dell'Aso</nome><codice>F501</codice></comune>
<comune><nome>Montefiorino</nome><codice>F503</codice></comune>
<comune><nome>Monteflavio</nome><codice>F504</codice></comune>
<comune><nome>Monteforte Cilento</nome><codice>F507</codice></comune>
<comune><nome>Monteforte d'Alpone</nome><codice>F508</codice></comune>
<comune><nome>Monteforte Irpino</nome><codice>F506</codice></comune>
<comune><nome>Montefortino</nome><codice>F509</codice></comune>
<comune><nome>Montefranco</nome><codice>F510</codice></comune>
<comune><nome>Montefredane</nome><codice>F511</codice></comune>
<comune><nome>Montefusco</nome><codice>F512</codice></comune>
<comune><nome>Montegabbione</nome><codice>F513</codice></comune>
<comune><nome>Montegalda</nome><codice>F514</codice></comune>
<comune><nome>Montegaldella</nome><codice>F515</codice></comune>
<comune><nome>Montegallo</nome><codice>F516</codice></comune>
<comune><nome>Montegioco</nome><codice>F518</codice></comune>
<comune><nome>Montegiordano</nome><codice>F519</codice></comune>
<comune><nome>Montegiorgio</nome><codice>F520</codice></comune>
<comune><nome>Montegranaro</nome><codice>F522</codice></comune>
<comune><nome>Montegridolfo</nome><codice>F523</codice></comune>
<comune><nome>Montegrino Valtravaglia</nome><codice>F526</codice></comune>
<comune><nome>Montegrosso d'Asti</nome><codice>F527</codice></comune>
<comune><nome>Montegrosso Pian Latte</nome><codice>F528</codice></comune>
<comune><nome>Montegrotto Terme</nome><codice>F529</codice></comune>
<comune><nome>Monteiasi</nome><codice>F531</codice></comune>
<comune><nome>Montelabbate</nome><codice>F533</codice></comune>
<comune><nome>Montelanico</nome><codice>F534</codice></comune>
<comune><nome>Montelapiano</nome><codice>F535</codice></comune>
<comune><nome>Monteleone di Fermo</nome><codice>F536</codice></comune>
<comune><nome>Monteleone di Puglia</nome><codice>F538</codice></comune>
<comune><nome>Monteleone di Spoleto</nome><codice>F540</codice></comune>
<comune><nome>Monteleone d'Orvieto</nome><codice>F543</codice></comune>
<comune><nome>Monteleone Rocca Doria</nome><codice>F542</codice></comune>
<comune><nome>Monteleone Sabino</nome><codice>F541</codice></comune>
<comune><nome>Montelepre</nome><codice>F544</codice></comune>
<comune><nome>Montelibretti</nome><codice>F545</codice></comune>
<comune><nome>Montella</nome><codice>F546</codice></comune>
<comune><nome>Montello</nome><codice>F547</codice></comune>
<comune><nome>Montelongo</nome><codice>F548</codice></comune>
<comune><nome>Montelparo</nome><codice>F549</codice></comune>
<comune><nome>Montelupo Albese</nome><codice>F550</codice></comune>
<comune><nome>Montelupo Fiorentino</nome><codice>F551</codice></comune>
<comune><nome>Montelupone</nome><codice>F552</codice></comune>
<comune><nome>Montemaggiore al Metauro</nome><codice>F555</codice></comune>
<comune><nome>Montemaggiore Belsito</nome><codice>F553</codice></comune>
<comune><nome>Montemagno</nome><codice>F556</codice></comune>
<comune><nome>Montemale di Cuneo</nome><codice>F558</codice></comune>
<comune><nome>Montemarano</nome><codice>F559</codice></comune>
<comune><nome>Montemarciano</nome><codice>F560</codice></comune>
<comune><nome>Montemarzino</nome><codice>F562</codice></comune>
<comune><nome>Montemesola</nome><codice>F563</codice></comune>
<comune><nome>Montemezzo</nome><codice>F564</codice></comune>
<comune><nome>Montemignaio</nome><codice>F565</codice></comune>
<comune><nome>Montemiletto</nome><codice>F566</codice></comune>
<comune><nome>Montemilone</nome><codice>F568</codice></comune>
<comune><nome>Montemitro</nome><codice>F569</codice></comune>
<comune><nome>Montemonaco</nome><codice>F570</codice></comune>
<comune><nome>Montemurlo</nome><codice>F572</codice></comune>
<comune><nome>Montemurro</nome><codice>F573</codice></comune>
<comune><nome>Montenars</nome><codice>F574</codice></comune>
<comune><nome>Montenero di Bisaccia</nome><codice>F576</codice></comune>
<comune><nome>Montenero Sabino</nome><codice>F579</codice></comune>
<comune><nome>Montenero Val Cocchiara</nome><codice>F580</codice></comune>
<comune><nome>Montenerodomo</nome><codice>F578</codice></comune>
<comune><nome>Monteodorisio</nome><codice>F582</codice></comune>
<comune><nome>Montepaone</nome><codice>F586</codice></comune>
<comune><nome>Monteparano</nome><codice>F587</codice></comune>
<comune><nome>Monteprandone</nome><codice>F591</codice></comune>
<comune><nome>Montepulciano</nome><codice>F592</codice></comune>
<comune><nome>Monterado</nome><codice>F593</codice></comune>
<comune><nome>Monterchi</nome><codice>F594</codice></comune>
<comune><nome>Montereale</nome><codice>F595</codice></comune>
<comune><nome>Montereale Valcellina</nome><codice>F596</codice></comune>
<comune><nome>Monterenzio</nome><codice>F597</codice></comune>
<comune><nome>Monteriggioni</nome><codice>F598</codice></comune>
<comune><nome>Monteroduni</nome><codice>F601</codice></comune>
<comune><nome>Monteroni d'Arbia</nome><codice>F605</codice></comune>
<comune><nome>Monteroni di Lecce</nome><codice>F604</codice></comune>
<comune><nome>Monterosi</nome><codice>F606</codice></comune>
<comune><nome>Monterosso al Mare</nome><codice>F609</codice></comune>
<comune><nome>Monterosso Almo</nome><codice>F610</codice></comune>
<comune><nome>Monterosso Calabro</nome><codice>F607</codice></comune>
<comune><nome>Monterosso Grana</nome><codice>F608</codice></comune>
<comune><nome>Monterotondo</nome><codice>F611</codice></comune>
<comune><nome>Monterotondo Marittimo</nome><codice>F612</codice></comune>
<comune><nome>Monterubbiano</nome><codice>F614</codice></comune>
<comune><nome>Montesano Salentino</nome><codice>F623</codice></comune>
<comune><nome>Montesano sulla Marcellana</nome><codice>F625</codice></comune>
<comune><nome>Montesarchio</nome><codice>F636</codice></comune>
<comune><nome>Montescaglioso</nome><codice>F637</codice></comune>
<comune><nome>Montescano</nome><codice>F638</codice></comune>
<comune><nome>Montescheno</nome><codice>F639</codice></comune>
<comune><nome>Montescudaio</nome><codice>F640</codice></comune>
<comune><nome>Montescudo</nome><codice>F641</codice></comune>
<comune><nome>Montese</nome><codice>F642</codice></comune>
<comune><nome>Montesegale</nome><codice>F644</codice></comune>
<comune><nome>Montesilvano</nome><codice>F646</codice></comune>
<comune><nome>Montespertoli</nome><codice>F648</codice></comune>
<comune><nome>Monteu da Po</nome><codice>F651</codice></comune>
<comune><nome>Monteu Roero</nome><codice>F654</codice></comune>
<comune><nome>Montevago</nome><codice>F655</codice></comune>
<comune><nome>Montevarchi</nome><codice>F656</codice></comune>
<comune><nome>Montevecchia</nome><codice>F657</codice></comune>
<comune><nome>Monteveglio</nome><codice>F659</codice></comune>
<comune><nome>Monteverde</nome><codice>F660</codice></comune>
<comune><nome>Monteverdi Marittimo</nome><codice>F661</codice></comune>
<comune><nome>Monteviale</nome><codice>F662</codice></comune>
<comune><nome>Montezemolo</nome><codice>F666</codice></comune>
<comune><nome>Monti</nome><codice>F667</codice></comune>
<comune><nome>Montiano</nome><codice>F668</codice></comune>
<comune><nome>Monticelli Brusati</nome><codice>F672</codice></comune>
<comune><nome>Monticelli d'Ongina</nome><codice>F671</codice></comune>
<comune><nome>Monticelli Pavese</nome><codice>F670</codice></comune>
<comune><nome>Monticello Brianza</nome><codice>F674</codice></comune>
<comune><nome>Monticello Conte Otto</nome><codice>F675</codice></comune>
<comune><nome>Monticello d'Alba</nome><codice>F669</codice></comune>
<comune><nome>Montichiari</nome><codice>F471</codice></comune>
<comune><nome>Monticiano</nome><codice>F676</codice></comune>
<comune><nome>Montieri</nome><codice>F677</codice></comune>
<comune><nome>Montiglio Monferrato</nome><codice>M302</codice></comune>
<comune><nome>Montignoso</nome><codice>F679</codice></comune>
<comune><nome>Montirone</nome><codice>F680</codice></comune>
<comune><nome>Montjovet</nome><codice>F367</codice></comune>
<comune><nome>Montodine</nome><codice>F681</codice></comune>
<comune><nome>Montoggio</nome><codice>F682</codice></comune>
<comune><nome>Montone</nome><codice>F685</codice></comune>
<comune><nome>Montopoli di Sabina</nome><codice>F687</codice></comune>
<comune><nome>Montopoli in Val d'Arno</nome><codice>F686</codice></comune>
<comune><nome>Montorfano</nome><codice>F688</codice></comune>
<comune><nome>Montorio al Vomano</nome><codice>F690</codice></comune>
<comune><nome>Montorio nei Frentani</nome><codice>F689</codice></comune>
<comune><nome>Montorio Romano</nome><codice>F692</codice></comune>
<comune><nome>Montoro Inferiore</nome><codice>F693</codice></comune>
<comune><nome>Montoro Superiore</nome><codice>F694</codice></comune>
<comune><nome>Montorso Vicentino</nome><codice>F696</codice></comune>
<comune><nome>Montottone</nome><codice>F697</codice></comune>
<comune><nome>Montresta</nome><codice>F698</codice></comune>
<comune><nome>Montù Beccaria</nome><codice>F701</codice></comune>
<comune><nome>Monvalle</nome><codice>F703</codice></comune>
<comune><nome>Monza</nome><codice>F704</codice></comune>
<comune><nome>Monzambano</nome><codice>F705</codice></comune>
<comune><nome>Monzuno</nome><codice>F706</codice></comune>
<comune><nome>Morano Calabro</nome><codice>F708</codice></comune>
<comune><nome>Morano sul Po</nome><codice>F707</codice></comune>
<comune><nome>Moransengo</nome><codice>F709</codice></comune>
<comune><nome>Moraro</nome><codice>F710</codice></comune>
<comune><nome>Morazzone</nome><codice>F711</codice></comune>
<comune><nome>Morbegno</nome><codice>F712</codice></comune>
<comune><nome>Morbello</nome><codice>F713</codice></comune>
<comune><nome>Morciano di Leuca</nome><codice>F716</codice></comune>
<comune><nome>Morciano di Romagna</nome><codice>F715</codice></comune>
<comune><nome>Morcone</nome><codice>F717</codice></comune>
<comune><nome>Mordano</nome><codice>F718</codice></comune>
<comune><nome>Morengo</nome><codice>F720</codice></comune>
<comune><nome>Mores</nome><codice>F721</codice></comune>
<comune><nome>Moresco</nome><codice>F722</codice></comune>
<comune><nome>Moretta</nome><codice>F723</codice></comune>
<comune><nome>Morfasso</nome><codice>F724</codice></comune>
<comune><nome>Morgano</nome><codice>F725</codice></comune>
<comune><nome>Morgex</nome><codice>F726</codice></comune>
<comune><nome>Morgongiori</nome><codice>F727</codice></comune>
<comune><nome>Mori</nome><codice>F728</codice></comune>
<comune><nome>Moriago della Battaglia</nome><codice>F729</codice></comune>
<comune><nome>Moricone</nome><codice>F730</codice></comune>
<comune><nome>Morigerati</nome><codice>F731</codice></comune>
<comune><nome>Morimondo</nome><codice>D033</codice></comune>
<comune><nome>Morino</nome><codice>F732</codice></comune>
<comune><nome>Moriondo Torinese</nome><codice>F733</codice></comune>
<comune><nome>Morlupo</nome><codice>F734</codice></comune>
<comune><nome>Mormanno</nome><codice>F735</codice></comune>
<comune><nome>Mornago</nome><codice>F736</codice></comune>
<comune><nome>Mornese</nome><codice>F737</codice></comune>
<comune><nome>Mornico al Serio</nome><codice>F738</codice></comune>
<comune><nome>Mornico Losana</nome><codice>F739</codice></comune>
<comune><nome>Morolo</nome><codice>F740</codice></comune>
<comune><nome>Morozzo</nome><codice>F743</codice></comune>
<comune><nome>Morra De Sanctis</nome><codice>F744</codice></comune>
<comune><nome>Morro d'Alba</nome><codice>F745</codice></comune>
<comune><nome>Morro d'Oro</nome><codice>F747</codice></comune>
<comune><nome>Morro Reatino</nome><codice>F746</codice></comune>
<comune><nome>Morrone del Sannio</nome><codice>F748</codice></comune>
<comune><nome>Morrovalle</nome><codice>F749</codice></comune>
<comune><nome>Morsano al Tagliamento</nome><codice>F750</codice></comune>
<comune><nome>Morsasco</nome><codice>F751</codice></comune>
<comune><nome>Mortara</nome><codice>F754</codice></comune>
<comune><nome>Mortegliano</nome><codice>F756</codice></comune>
<comune><nome>Morterone</nome><codice>F758</codice></comune>
<comune><nome>Moruzzo</nome><codice>F760</codice></comune>
<comune><nome>Moscazzano</nome><codice>F761</codice></comune>
<comune><nome>Moschiano</nome><codice>F762</codice></comune>
<comune><nome>Mosciano Sant'Angelo</nome><codice>F764</codice></comune>
<comune><nome>Moscufo</nome><codice>F765</codice></comune>
<comune><nome>Moso in Passiria</nome><codice>F766</codice></comune>
<comune><nome>Mossa</nome><codice>F767</codice></comune>
<comune><nome>Mossano</nome><codice>F768</codice></comune>
<comune><nome>Mosso</nome><codice>M304</codice></comune>
<comune><nome>Motta Baluffi</nome><codice>F771</codice></comune>
<comune><nome>Motta Camastra</nome><codice>F772</codice></comune>
<comune><nome>Motta d'Affermo</nome><codice>F773</codice></comune>
<comune><nome>Motta de' Conti</nome><codice>F774</codice></comune>
<comune><nome>Motta di Livenza</nome><codice>F770</codice></comune>
<comune><nome>Motta Montecorvino</nome><codice>F777</codice></comune>
<comune><nome>Motta San Giovanni</nome><codice>F779</codice></comune>
<comune><nome>Motta Santa Lucia</nome><codice>F780</codice></comune>
<comune><nome>Motta Sant'Anastasia</nome><codice>F781</codice></comune>
<comune><nome>Motta Visconti</nome><codice>F783</codice></comune>
<comune><nome>Mottafollone</nome><codice>F775</codice></comune>
<comune><nome>Mottalciata</nome><codice>F776</codice></comune>
<comune><nome>Motteggiana</nome><codice>B012</codice></comune>
<comune><nome>Mottola</nome><codice>F784</codice></comune>
<comune><nome>Mozzagrogna</nome><codice>F785</codice></comune>
<comune><nome>Mozzanica</nome><codice>F786</codice></comune>
<comune><nome>Mozzate</nome><codice>F788</codice></comune>
<comune><nome>Mozzecane</nome><codice>F789</codice></comune>
<comune><nome>Mozzo</nome><codice>F791</codice></comune>
<comune><nome>Muccia</nome><codice>F793</codice></comune>
<comune><nome>Muggia</nome><codice>F795</codice></comune>
<comune><nome>Muggiò</nome><codice>F797</codice></comune>
<comune><nome>Mugnano del Cardinale</nome><codice>F798</codice></comune>
<comune><nome>Mugnano di Napoli</nome><codice>F799</codice></comune>
<comune><nome>Mulazzano</nome><codice>F801</codice></comune>
<comune><nome>Mulazzo</nome><codice>F802</codice></comune>
<comune><nome>Mura</nome><codice>F806</codice></comune>
<comune><nome>Muravera</nome><codice>F808</codice></comune>
<comune><nome>Murazzano</nome><codice>F809</codice></comune>
<comune><nome>Murello</nome><codice>F811</codice></comune>
<comune><nome>Murialdo</nome><codice>F813</codice></comune>
<comune><nome>Murisengo</nome><codice>F814</codice></comune>
<comune><nome>Murlo</nome><codice>F815</codice></comune>
<comune><nome>Muro Leccese</nome><codice>F816</codice></comune>
<comune><nome>Muro Lucano</nome><codice>F817</codice></comune>
<comune><nome>Muros</nome><codice>F818</codice></comune>
<comune><nome>Muscoline</nome><codice>F820</codice></comune>
<comune><nome>Musei</nome><codice>F822</codice></comune>
<comune><nome>Musile di Piave</nome><codice>F826</codice></comune>
<comune><nome>Musso</nome><codice>F828</codice></comune>
<comune><nome>Mussolente</nome><codice>F829</codice></comune>
<comune><nome>Mussomeli</nome><codice>F830</codice></comune>
<comune><nome>Muzzana del Turgnano</nome><codice>F832</codice></comune>
<comune><nome>Muzzano</nome><codice>F833</codice></comune>
<comune><nome>Nago-Torbole</nome><codice>F835</codice></comune>
<comune><nome>Nalles</nome><codice>F836</codice></comune>
<comune><nome>Nanno</nome><codice>F837</codice></comune>
<comune><nome>Nanto</nome><codice>F838</codice></comune>
<comune><nome>Napoli</nome><codice>F839</codice></comune>
<comune><nome>Narbolia</nome><codice>F840</codice></comune>
<comune><nome>Narcao</nome><codice>F841</codice></comune>
<comune><nome>Nardò</nome><codice>F842</codice></comune>
<comune><nome>Nardodipace</nome><codice>F843</codice></comune>
<comune><nome>Narni</nome><codice>F844</codice></comune>
<comune><nome>Naro</nome><codice>F845</codice></comune>
<comune><nome>Narzole</nome><codice>F846</codice></comune>
<comune><nome>Nasino</nome><codice>F847</codice></comune>
<comune><nome>Naso</nome><codice>F848</codice></comune>
<comune><nome>Naturno</nome><codice>F849</codice></comune>
<comune><nome>Nave</nome><codice>F851</codice></comune>
<comune><nome>Nave San Rocco</nome><codice>F853</codice></comune>
<comune><nome>Navelli</nome><codice>F852</codice></comune>
<comune><nome>Naz-Sciaves</nome><codice>F856</codice></comune>
<comune><nome>Nazzano</nome><codice>F857</codice></comune>
<comune><nome>Ne</nome><codice>F858</codice></comune>
<comune><nome>Nebbiuno</nome><codice>F859</codice></comune>
<comune><nome>Negrar</nome><codice>F861</codice></comune>
<comune><nome>Neirone</nome><codice>F862</codice></comune>
<comune><nome>Neive</nome><codice>F863</codice></comune>
<comune><nome>Nembro</nome><codice>F864</codice></comune>
<comune><nome>Nemi</nome><codice>F865</codice></comune>
<comune><nome>Nemoli</nome><codice>F866</codice></comune>
<comune><nome>Neoneli</nome><codice>F867</codice></comune>
<comune><nome>Nepi</nome><codice>F868</codice></comune>
<comune><nome>Nereto</nome><codice>F870</codice></comune>
<comune><nome>Nerola</nome><codice>F871</codice></comune>
<comune><nome>Nervesa della Battaglia</nome><codice>F872</codice></comune>
<comune><nome>Nerviano</nome><codice>F874</codice></comune>
<comune><nome>Nespolo</nome><codice>F876</codice></comune>
<comune><nome>Nesso</nome><codice>F877</codice></comune>
<comune><nome>Netro</nome><codice>F878</codice></comune>
<comune><nome>Nettuno</nome><codice>F880</codice></comune>
<comune><nome>Neviano</nome><codice>F881</codice></comune>
<comune><nome>Neviano degli Arduini</nome><codice>F882</codice></comune>
<comune><nome>Neviglie</nome><codice>F883</codice></comune>
<comune><nome>Niardo</nome><codice>F884</codice></comune>
<comune><nome>Nibbiano</nome><codice>F885</codice></comune>
<comune><nome>Nibbiola</nome><codice>F886</codice></comune>
<comune><nome>Nibionno</nome><codice>F887</codice></comune>
<comune><nome>Nichelino</nome><codice>F889</codice></comune>
<comune><nome>Nicolosi</nome><codice>F890</codice></comune>
<comune><nome>Nicorvo</nome><codice>F891</codice></comune>
<comune><nome>Nicosia</nome><codice>F892</codice></comune>
<comune><nome>Nicotera</nome><codice>F893</codice></comune>
<comune><nome>Niella Belbo</nome><codice>F894</codice></comune>
<comune><nome>Niella Tanaro</nome><codice>F895</codice></comune>
<comune><nome>Nimis</nome><codice>F898</codice></comune>
<comune><nome>Niscemi</nome><codice>F899</codice></comune>
<comune><nome>Nissoria</nome><codice>F900</codice></comune>
<comune><nome>Nizza di Sicilia</nome><codice>F901</codice></comune>
<comune><nome>Nizza Monferrato</nome><codice>F902</codice></comune>
<comune><nome>Noale</nome><codice>F904</codice></comune>
<comune><nome>Noasca</nome><codice>F906</codice></comune>
<comune><nome>Nocara</nome><codice>F907</codice></comune>
<comune><nome>Nocciano</nome><codice>F908</codice></comune>
<comune><nome>Nocera Inferiore</nome><codice>F912</codice></comune>
<comune><nome>Nocera Superiore</nome><codice>F913</codice></comune>
<comune><nome>Nocera Terinese</nome><codice>F910</codice></comune>
<comune><nome>Nocera Umbra</nome><codice>F911</codice></comune>
<comune><nome>Noceto</nome><codice>F914</codice></comune>
<comune><nome>Noci</nome><codice>F915</codice></comune>
<comune><nome>Nociglia</nome><codice>F916</codice></comune>
<comune><nome>Noepoli</nome><codice>F917</codice></comune>
<comune><nome>Nogara</nome><codice>F918</codice></comune>
<comune><nome>Nogaredo</nome><codice>F920</codice></comune>
<comune><nome>Nogarole Rocca</nome><codice>F921</codice></comune>
<comune><nome>Nogarole Vicentino</nome><codice>F922</codice></comune>
<comune><nome>Noicàttaro</nome><codice>F923</codice></comune>
<comune><nome>Nola</nome><codice>F924</codice></comune>
<comune><nome>Nole</nome><codice>F925</codice></comune>
<comune><nome>Noli</nome><codice>F926</codice></comune>
<comune><nome>Nomaglio</nome><codice>F927</codice></comune>
<comune><nome>Nomi</nome><codice>F929</codice></comune>
<comune><nome>Nonantola</nome><codice>F930</codice></comune>
<comune><nome>None</nome><codice>F931</codice></comune>
<comune><nome>Nonio</nome><codice>F932</codice></comune>
<comune><nome>Noragugume</nome><codice>F933</codice></comune>
<comune><nome>Norbello</nome><codice>F934</codice></comune>
<comune><nome>Norcia</nome><codice>F935</codice></comune>
<comune><nome>Norma</nome><codice>F937</codice></comune>
<comune><nome>Nosate</nome><codice>F939</codice></comune>
<comune><nome>Notaresco</nome><codice>F942</codice></comune>
<comune><nome>Noto</nome><codice>F943</codice></comune>
<comune><nome>Nova Levante</nome><codice>F949</codice></comune>
<comune><nome>Nova Milanese</nome><codice>F944</codice></comune>
<comune><nome>Nova Ponente</nome><codice>F950</codice></comune>
<comune><nome>Nova Siri</nome><codice>A942</codice></comune>
<comune><nome>Novafeltria</nome><codice>F137</codice></comune>
<comune><nome>Novaledo</nome><codice>F947</codice></comune>
<comune><nome>Novalesa</nome><codice>F948</codice></comune>
<comune><nome>Novara</nome><codice>F952</codice></comune>
<comune><nome>Novara di Sicilia</nome><codice>F951</codice></comune>
<comune><nome>Novate Mezzola</nome><codice>F956</codice></comune>
<comune><nome>Novate Milanese</nome><codice>F955</codice></comune>
<comune><nome>Nove</nome><codice>F957</codice></comune>
<comune><nome>Novedrate</nome><codice>F958</codice></comune>
<comune><nome>Novellara</nome><codice>F960</codice></comune>
<comune><nome>Novello</nome><codice>F961</codice></comune>
<comune><nome>Noventa di Piave</nome><codice>F963</codice></comune>
<comune><nome>Noventa Padovana</nome><codice>F962</codice></comune>
<comune><nome>Noventa Vicentina</nome><codice>F964</codice></comune>
<comune><nome>Novi di Modena</nome><codice>F966</codice></comune>
<comune><nome>Novi Ligure</nome><codice>F965</codice></comune>
<comune><nome>Novi Velia</nome><codice>F967</codice></comune>
<comune><nome>Noviglio</nome><codice>F968</codice></comune>
<comune><nome>Novoli</nome><codice>F970</codice></comune>
<comune><nome>Nucetto</nome><codice>F972</codice></comune>
<comune><nome>Nughedu San Nicolò</nome><codice>F975</codice></comune>
<comune><nome>Nughedu Santa Vittoria</nome><codice>F974</codice></comune>
<comune><nome>Nule</nome><codice>F976</codice></comune>
<comune><nome>Nulvi</nome><codice>F977</codice></comune>
<comune><nome>Numana</nome><codice>F978</codice></comune>
<comune><nome>Nuoro</nome><codice>F979</codice></comune>
<comune><nome>Nurachi</nome><codice>F980</codice></comune>
<comune><nome>Nuragus</nome><codice>F981</codice></comune>
<comune><nome>Nurallao</nome><codice>F982</codice></comune>
<comune><nome>Nuraminis</nome><codice>F983</codice></comune>
<comune><nome>Nureci</nome><codice>F985</codice></comune>
<comune><nome>Nurri</nome><codice>F986</codice></comune>
<comune><nome>Nus</nome><codice>F987</codice></comune>
<comune><nome>Nusco</nome><codice>F988</codice></comune>
<comune><nome>Nuvolento</nome><codice>F989</codice></comune>
<comune><nome>Nuvolera</nome><codice>F990</codice></comune>
<comune><nome>Nuxis</nome><codice>F991</codice></comune>
<comune><nome>Occhieppo Inferiore</nome><codice>F992</codice></comune>
<comune><nome>Occhieppo Superiore</nome><codice>F993</codice></comune>
<comune><nome>Occhiobello</nome><codice>F994</codice></comune>
<comune><nome>Occimiano</nome><codice>F995</codice></comune>
<comune><nome>Ocre</nome><codice>F996</codice></comune>
<comune><nome>Odalengo Grande</nome><codice>F997</codice></comune>
<comune><nome>Odalengo Piccolo</nome><codice>F998</codice></comune>
<comune><nome>Oderzo</nome><codice>F999</codice></comune>
<comune><nome>Odolo</nome><codice>G001</codice></comune>
<comune><nome>Ofena</nome><codice>G002</codice></comune>
<comune><nome>Offagna</nome><codice>G003</codice></comune>
<comune><nome>Offanengo</nome><codice>G004</codice></comune>
<comune><nome>Offida</nome><codice>G005</codice></comune>
<comune><nome>Offlaga</nome><codice>G006</codice></comune>
<comune><nome>Oggebbio</nome><codice>G007</codice></comune>
<comune><nome>Oggiona con Santo Stefano</nome><codice>G008</codice></comune>
<comune><nome>Oggiono</nome><codice>G009</codice></comune>
<comune><nome>Oglianico</nome><codice>G010</codice></comune>
<comune><nome>Ogliastro Cilento</nome><codice>G011</codice></comune>
<comune><nome>Olbia</nome><codice>G015</codice></comune>
<comune><nome>Olcenengo</nome><codice>G016</codice></comune>
<comune><nome>Oldenico</nome><codice>G018</codice></comune>
<comune><nome>Oleggio</nome><codice>G019</codice></comune>
<comune><nome>Oleggio Castello</nome><codice>G020</codice></comune>
<comune><nome>Olevano di Lomellina</nome><codice>G021</codice></comune>
<comune><nome>Olevano Romano</nome><codice>G022</codice></comune>
<comune><nome>Olevano sul Tusciano</nome><codice>G023</codice></comune>
<comune><nome>Olgiate Comasco</nome><codice>G025</codice></comune>
<comune><nome>Olgiate Molgora</nome><codice>G026</codice></comune>
<comune><nome>Olgiate Olona</nome><codice>G028</codice></comune>
<comune><nome>Olginate</nome><codice>G030</codice></comune>
<comune><nome>Oliena</nome><codice>G031</codice></comune>
<comune><nome>Oliva Gessi</nome><codice>G032</codice></comune>
<comune><nome>Olivadi</nome><codice>G034</codice></comune>
<comune><nome>Oliveri</nome><codice>G036</codice></comune>
<comune><nome>Oliveto Citra</nome><codice>G039</codice></comune>
<comune><nome>Oliveto Lario</nome><codice>G040</codice></comune>
<comune><nome>Oliveto Lucano</nome><codice>G037</codice></comune>
<comune><nome>Olivetta San Michele</nome><codice>G041</codice></comune>
<comune><nome>Olivola</nome><codice>G042</codice></comune>
<comune><nome>Ollastra</nome><codice>G043</codice></comune>
<comune><nome>Ollolai</nome><codice>G044</codice></comune>
<comune><nome>Ollomont</nome><codice>G045</codice></comune>
<comune><nome>Olmedo</nome><codice>G046</codice></comune>
<comune><nome>Olmeneta</nome><codice>G047</codice></comune>
<comune><nome>Olmo al Brembo</nome><codice>G049</codice></comune>
<comune><nome>Olmo Gentile</nome><codice>G048</codice></comune>
<comune><nome>Oltre il Colle</nome><codice>G050</codice></comune>
<comune><nome>Oltressenda Alta</nome><codice>G054</codice></comune>
<comune><nome>Oltrona di San Mamette</nome><codice>G056</codice></comune>
<comune><nome>Olzai</nome><codice>G058</codice></comune>
<comune><nome>Ome</nome><codice>G061</codice></comune>
<comune><nome>Omegna</nome><codice>G062</codice></comune>
<comune><nome>Omignano</nome><codice>G063</codice></comune>
<comune><nome>Onanì</nome><codice>G064</codice></comune>
<comune><nome>Onano</nome><codice>G065</codice></comune>
<comune><nome>Oncino</nome><codice>G066</codice></comune>
<comune><nome>Oneta</nome><codice>G068</codice></comune>
<comune><nome>Onifai</nome><codice>G070</codice></comune>
<comune><nome>Oniferi</nome><codice>G071</codice></comune>
<comune><nome>Ono San Pietro</nome><codice>G074</codice></comune>
<comune><nome>Onore</nome><codice>G075</codice></comune>
<comune><nome>Onzo</nome><codice>G076</codice></comune>
<comune><nome>Opera</nome><codice>G078</codice></comune>
<comune><nome>Opi</nome><codice>G079</codice></comune>
<comune><nome>Oppeano</nome><codice>G080</codice></comune>
<comune><nome>Oppido Lucano</nome><codice>G081</codice></comune>
<comune><nome>Oppido Mamertina</nome><codice>G082</codice></comune>
<comune><nome>Ora</nome><codice>G083</codice></comune>
<comune><nome>Orani</nome><codice>G084</codice></comune>
<comune><nome>Oratino</nome><codice>G086</codice></comune>
<comune><nome>Orbassano</nome><codice>G087</codice></comune>
<comune><nome>Orbetello</nome><codice>G088</codice></comune>
<comune><nome>Orciano di Pesaro</nome><codice>G089</codice></comune>
<comune><nome>Orciano Pisano</nome><codice>G090</codice></comune>
<comune><nome>Orco Feglino</nome><codice>D522</codice></comune>
<comune><nome>Ordona</nome><codice>M266</codice></comune>
<comune><nome>Orero</nome><codice>G093</codice></comune>
<comune><nome>Orgiano</nome><codice>G095</codice></comune>
<comune><nome>Orgosolo</nome><codice>G097</codice></comune>
<comune><nome>Oria</nome><codice>G098</codice></comune>
<comune><nome>Oricola</nome><codice>G102</codice></comune>
<comune><nome>Origgio</nome><codice>G103</codice></comune>
<comune><nome>Orino</nome><codice>G105</codice></comune>
<comune><nome>Orio al Serio</nome><codice>G108</codice></comune>
<comune><nome>Orio Canavese</nome><codice>G109</codice></comune>
<comune><nome>Orio Litta</nome><codice>G107</codice></comune>
<comune><nome>Oriolo</nome><codice>G110</codice></comune>
<comune><nome>Oriolo Romano</nome><codice>G111</codice></comune>
<comune><nome>Oristano</nome><codice>G113</codice></comune>
<comune><nome>Ormea</nome><codice>G114</codice></comune>
<comune><nome>Ormelle</nome><codice>G115</codice></comune>
<comune><nome>Ornago</nome><codice>G116</codice></comune>
<comune><nome>Ornavasso</nome><codice>G117</codice></comune>
<comune><nome>Ornica</nome><codice>G118</codice></comune>
<comune><nome>Orosei</nome><codice>G119</codice></comune>
<comune><nome>Orotelli</nome><codice>G120</codice></comune>
<comune><nome>Orria</nome><codice>G121</codice></comune>
<comune><nome>Orroli</nome><codice>G122</codice></comune>
<comune><nome>Orsago</nome><codice>G123</codice></comune>
<comune><nome>Orsara Bormida</nome><codice>G124</codice></comune>
<comune><nome>Orsara di Puglia</nome><codice>G125</codice></comune>
<comune><nome>Orsenigo</nome><codice>G126</codice></comune>
<comune><nome>Orsogna</nome><codice>G128</codice></comune>
<comune><nome>Orsomarso</nome><codice>G129</codice></comune>
<comune><nome>Orta di Atella</nome><codice>G130</codice></comune>
<comune><nome>Orta Nova</nome><codice>G131</codice></comune>
<comune><nome>Orta San Giulio</nome><codice>G134</codice></comune>
<comune><nome>Ortacesus</nome><codice>G133</codice></comune>
<comune><nome>Orte</nome><codice>G135</codice></comune>
<comune><nome>Ortelle</nome><codice>G136</codice></comune>
<comune><nome>Ortezzano</nome><codice>G137</codice></comune>
<comune><nome>Ortignano Raggiolo</nome><codice>G139</codice></comune>
<comune><nome>Ortisei</nome><codice>G140</codice></comune>
<comune><nome>Ortona</nome><codice>G141</codice></comune>
<comune><nome>Ortona dei Marsi</nome><codice>G142</codice></comune>
<comune><nome>Ortonovo</nome><codice>G143</codice></comune>
<comune><nome>Ortovero</nome><codice>G144</codice></comune>
<comune><nome>Ortucchio</nome><codice>G145</codice></comune>
<comune><nome>Ortueri</nome><codice>G146</codice></comune>
<comune><nome>Orune</nome><codice>G147</codice></comune>
<comune><nome>Orvieto</nome><codice>G148</codice></comune>
<comune><nome>Orvinio</nome><codice>B595</codice></comune>
<comune><nome>Orzinuovi</nome><codice>G149</codice></comune>
<comune><nome>Orzivecchi</nome><codice>G150</codice></comune>
<comune><nome>Osasco</nome><codice>G151</codice></comune>
<comune><nome>Osasio</nome><codice>G152</codice></comune>
<comune><nome>Oschiri</nome><codice>G153</codice></comune>
<comune><nome>Osidda</nome><codice>G154</codice></comune>
<comune><nome>Osiglia</nome><codice>G155</codice></comune>
<comune><nome>Osilo</nome><codice>G156</codice></comune>
<comune><nome>Osimo</nome><codice>G157</codice></comune>
<comune><nome>Osini</nome><codice>G158</codice></comune>
<comune><nome>Osio Sopra</nome><codice>G159</codice></comune>
<comune><nome>Osio Sotto</nome><codice>G160</codice></comune>
<comune><nome>Osmate</nome><codice>E529</codice></comune>
<comune><nome>Osnago</nome><codice>G161</codice></comune>
<comune><nome>Osoppo</nome><codice>G163</codice></comune>
<comune><nome>Ospedaletti</nome><codice>G164</codice></comune>
<comune><nome>Ospedaletto</nome><codice>G168</codice></comune>
<comune><nome>Ospedaletto d'Alpinolo</nome><codice>G165</codice></comune>
<comune><nome>Ospedaletto Euganeo</nome><codice>G167</codice></comune>
<comune><nome>Ospedaletto Lodigiano</nome><codice>G166</codice></comune>
<comune><nome>Ospitale di Cadore</nome><codice>G169</codice></comune>
<comune><nome>Ospitaletto</nome><codice>G170</codice></comune>
<comune><nome>Ossago Lodigiano</nome><codice>G171</codice></comune>
<comune><nome>Ossana</nome><codice>G173</codice></comune>
<comune><nome>Ossi</nome><codice>G178</codice></comune>
<comune><nome>Ossimo</nome><codice>G179</codice></comune>
<comune><nome>Ossona</nome><codice>G181</codice></comune>
<comune><nome>Ossuccio</nome><codice>G182</codice></comune>
<comune><nome>Ostana</nome><codice>G183</codice></comune>
<comune><nome>Ostellato</nome><codice>G184</codice></comune>
<comune><nome>Ostiano</nome><codice>G185</codice></comune>
<comune><nome>Ostiglia</nome><codice>G186</codice></comune>
<comune><nome>Ostra</nome><codice>F401</codice></comune>
<comune><nome>Ostra Vetere</nome><codice>F581</codice></comune>
<comune><nome>Ostuni</nome><codice>G187</codice></comune>
<comune><nome>Otranto</nome><codice>G188</codice></comune>
<comune><nome>Otricoli</nome><codice>G189</codice></comune>
<comune><nome>Ottana</nome><codice>G191</codice></comune>
<comune><nome>Ottati</nome><codice>G192</codice></comune>
<comune><nome>Ottaviano</nome><codice>G190</codice></comune>
<comune><nome>Ottiglio</nome><codice>G193</codice></comune>
<comune><nome>Ottobiano</nome><codice>G194</codice></comune>
<comune><nome>Ottone</nome><codice>G195</codice></comune>
<comune><nome>Oulx</nome><codice>G196</codice></comune>
<comune><nome>Ovada</nome><codice>G197</codice></comune>
<comune><nome>Ovaro</nome><codice>G198</codice></comune>
<comune><nome>Oviglio</nome><codice>G199</codice></comune>
<comune><nome>Ovindoli</nome><codice>G200</codice></comune>
<comune><nome>Ovodda</nome><codice>G201</codice></comune>
<comune><nome>Oyace</nome><codice>G012</codice></comune>
<comune><nome>Ozegna</nome><codice>G202</codice></comune>
<comune><nome>Ozieri</nome><codice>G203</codice></comune>
<comune><nome>Ozzano dell'Emilia</nome><codice>G205</codice></comune>
<comune><nome>Ozzano Monferrato</nome><codice>G204</codice></comune>
<comune><nome>Ozzero</nome><codice>G206</codice></comune>
<comune><nome>Pabillonis</nome><codice>G207</codice></comune>
<comune><nome>Pace del Mela</nome><codice>G209</codice></comune>
<comune><nome>Paceco</nome><codice>G208</codice></comune>
<comune><nome>Pacentro</nome><codice>G210</codice></comune>
<comune><nome>Pachino</nome><codice>G211</codice></comune>
<comune><nome>Paciano</nome><codice>G212</codice></comune>
<comune><nome>Padenghe sul Garda</nome><codice>G213</codice></comune>
<comune><nome>Padergnone</nome><codice>G214</codice></comune>
<comune><nome>Paderna</nome><codice>G215</codice></comune>
<comune><nome>Paderno d'Adda</nome><codice>G218</codice></comune>
<comune><nome>Paderno del Grappa</nome><codice>G221</codice></comune>
<comune><nome>Paderno Dugnano</nome><codice>G220</codice></comune>
<comune><nome>Paderno Franciacorta</nome><codice>G217</codice></comune>
<comune><nome>Paderno Ponchielli</nome><codice>G222</codice></comune>
<comune><nome>Padova</nome><codice>G224</codice></comune>
<comune><nome>Padria</nome><codice>G225</codice></comune>
<comune><nome>Padru</nome><codice>M301</codice></comune>
<comune><nome>Padula</nome><codice>G226</codice></comune>
<comune><nome>Paduli</nome><codice>G227</codice></comune>
<comune><nome>Paesana</nome><codice>G228</codice></comune>
<comune><nome>Paese</nome><codice>G229</codice></comune>
<comune><nome>Pagani</nome><codice>G230</codice></comune>
<comune><nome>Paganico Sabino</nome><codice>G232</codice></comune>
<comune><nome>Pagazzano</nome><codice>G233</codice></comune>
<comune><nome>Pagliara</nome><codice>G234</codice></comune>
<comune><nome>Paglieta</nome><codice>G237</codice></comune>
<comune><nome>Pagnacco</nome><codice>G238</codice></comune>
<comune><nome>Pagno</nome><codice>G240</codice></comune>
<comune><nome>Pagnona</nome><codice>G241</codice></comune>
<comune><nome>Pago del Vallo di Lauro</nome><codice>G242</codice></comune>
<comune><nome>Pago Veiano</nome><codice>G243</codice></comune>
<comune><nome>Paisco Loveno</nome><codice>G247</codice></comune>
<comune><nome>Paitone</nome><codice>G248</codice></comune>
<comune><nome>Paladina</nome><codice>G249</codice></comune>
<comune><nome>Palagano</nome><codice>G250</codice></comune>
<comune><nome>Palagianello</nome><codice>G251</codice></comune>
<comune><nome>Palagiano</nome><codice>G252</codice></comune>
<comune><nome>Palagonia</nome><codice>G253</codice></comune>
<comune><nome>Palaia</nome><codice>G254</codice></comune>
<comune><nome>Palanzano</nome><codice>G255</codice></comune>
<comune><nome>Palata</nome><codice>G257</codice></comune>
<comune><nome>Palau</nome><codice>G258</codice></comune>
<comune><nome>Palazzago</nome><codice>G259</codice></comune>
<comune><nome>Palazzo Adriano</nome><codice>G263</codice></comune>
<comune><nome>Palazzo Canavese</nome><codice>G262</codice></comune>
<comune><nome>Palazzo Pignano</nome><codice>G260</codice></comune>
<comune><nome>Palazzo San Gervasio</nome><codice>G261</codice></comune>
<comune><nome>Palazzolo Acreide</nome><codice>G267</codice></comune>
<comune><nome>Palazzolo dello Stella</nome><codice>G268</codice></comune>
<comune><nome>Palazzolo sull'Oglio</nome><codice>G264</codice></comune>
<comune><nome>Palazzolo Vercellese</nome><codice>G266</codice></comune>
<comune><nome>Palazzuolo sul Senio</nome><codice>G270</codice></comune>
<comune><nome>Palena</nome><codice>G271</codice></comune>
<comune><nome>Palermiti</nome><codice>G272</codice></comune>
<comune><nome>Palermo</nome><codice>G273</codice></comune>
<comune><nome>Palestrina</nome><codice>G274</codice></comune>
<comune><nome>Palestro</nome><codice>G275</codice></comune>
<comune><nome>Paliano</nome><codice>G276</codice></comune>
<comune><nome>Palizzi</nome><codice>G277</codice></comune>
<comune><nome>Pallagorio</nome><codice>G278</codice></comune>
<comune><nome>Pallanzeno</nome><codice>G280</codice></comune>
<comune><nome>Pallare</nome><codice>G281</codice></comune>
<comune><nome>Palma Campania</nome><codice>G283</codice></comune>
<comune><nome>Palma di Montechiaro</nome><codice>G282</codice></comune>
<comune><nome>Palmanova</nome><codice>G284</codice></comune>
<comune><nome>Palmariggi</nome><codice>G285</codice></comune>
<comune><nome>Palmas Arborea</nome><codice>G286</codice></comune>
<comune><nome>Palmi</nome><codice>G288</codice></comune>
<comune><nome>Palmiano</nome><codice>G289</codice></comune>
<comune><nome>Palmoli</nome><codice>G290</codice></comune>
<comune><nome>Palo del Colle</nome><codice>G291</codice></comune>
<comune><nome>Palombara Sabina</nome><codice>G293</codice></comune>
<comune><nome>Palombaro</nome><codice>G294</codice></comune>
<comune><nome>Palomonte</nome><codice>G292</codice></comune>
<comune><nome>Palosco</nome><codice>G295</codice></comune>
<comune><nome>Palù</nome><codice>G297</codice></comune>
<comune><nome>Palù del Fersina</nome><codice>G296</codice></comune>
<comune><nome>Paludi</nome><codice>G298</codice></comune>
<comune><nome>Paluzza</nome><codice>G300</codice></comune>
<comune><nome>Pamparato</nome><codice>G302</codice></comune>
<comune><nome>Pancalieri</nome><codice>G303</codice></comune>
<comune><nome>Pancarana</nome><codice>G304</codice></comune>
<comune><nome>Panchià</nome><codice>G305</codice></comune>
<comune><nome>Pandino</nome><codice>G306</codice></comune>
<comune><nome>Panettieri</nome><codice>G307</codice></comune>
<comune><nome>Panicale</nome><codice>G308</codice></comune>
<comune><nome>Pannarano</nome><codice>G311</codice></comune>
<comune><nome>Panni</nome><codice>G312</codice></comune>
<comune><nome>Pantelleria</nome><codice>G315</codice></comune>
<comune><nome>Pantigliate</nome><codice>G316</codice></comune>
<comune><nome>Paola</nome><codice>G317</codice></comune>
<comune><nome>Paolisi</nome><codice>G318</codice></comune>
<comune><nome>Papasidero</nome><codice>G320</codice></comune>
<comune><nome>Papozze</nome><codice>G323</codice></comune>
<comune><nome>Parabiago</nome><codice>G324</codice></comune>
<comune><nome>Parabita</nome><codice>G325</codice></comune>
<comune><nome>Paratico</nome><codice>G327</codice></comune>
<comune><nome>Parcines</nome><codice>G328</codice></comune>
<comune><nome>Parè</nome><codice>G329</codice></comune>
<comune><nome>Parella</nome><codice>G330</codice></comune>
<comune><nome>Parenti</nome><codice>G331</codice></comune>
<comune><nome>Parete</nome><codice>G333</codice></comune>
<comune><nome>Pareto</nome><codice>G334</codice></comune>
<comune><nome>Parghelia</nome><codice>G335</codice></comune>
<comune><nome>Parlasco</nome><codice>G336</codice></comune>
<comune><nome>Parma</nome><codice>G337</codice></comune>
<comune><nome>Parodi Ligure</nome><codice>G338</codice></comune>
<comune><nome>Paroldo</nome><codice>G339</codice></comune>
<comune><nome>Parolise</nome><codice>G340</codice></comune>
<comune><nome>Parona</nome><codice>G342</codice></comune>
<comune><nome>Parrano</nome><codice>G344</codice></comune>
<comune><nome>Parre</nome><codice>G346</codice></comune>
<comune><nome>Partanna</nome><codice>G347</codice></comune>
<comune><nome>Partinico</nome><codice>G348</codice></comune>
<comune><nome>Paruzzaro</nome><codice>G349</codice></comune>
<comune><nome>Parzanica</nome><codice>G350</codice></comune>
<comune><nome>Pasian di Prato</nome><codice>G352</codice></comune>
<comune><nome>Pasiano di Pordenone</nome><codice>G353</codice></comune>
<comune><nome>Paspardo</nome><codice>G354</codice></comune>
<comune><nome>Passerano Marmorito</nome><codice>G358</codice></comune>
<comune><nome>Passignano sul Trasimeno</nome><codice>G359</codice></comune>
<comune><nome>Passirano</nome><codice>G361</codice></comune>
<comune><nome>Pastena</nome><codice>G362</codice></comune>
<comune><nome>Pastorano</nome><codice>G364</codice></comune>
<comune><nome>Pastrengo</nome><codice>G365</codice></comune>
<comune><nome>Pasturana</nome><codice>G367</codice></comune>
<comune><nome>Pasturo</nome><codice>G368</codice></comune>
<comune><nome>Paterno</nome><codice>M269</codice></comune>
<comune><nome>Paternò</nome><codice>G371</codice></comune>
<comune><nome>Paterno Calabro</nome><codice>G372</codice></comune>
<comune><nome>Paternopoli</nome><codice>G370</codice></comune>
<comune><nome>Patrica</nome><codice>G374</codice></comune>
<comune><nome>Pattada</nome><codice>G376</codice></comune>
<comune><nome>Patti</nome><codice>G377</codice></comune>
<comune><nome>Patù</nome><codice>G378</codice></comune>
<comune><nome>Pau</nome><codice>G379</codice></comune>
<comune><nome>Paularo</nome><codice>G381</codice></comune>
<comune><nome>Pauli Arbarei</nome><codice>G382</codice></comune>
<comune><nome>Paulilatino</nome><codice>G384</codice></comune>
<comune><nome>Paullo</nome><codice>G385</codice></comune>
<comune><nome>Paupisi</nome><codice>G386</codice></comune>
<comune><nome>Pavarolo</nome><codice>G387</codice></comune>
<comune><nome>Pavia</nome><codice>G388</codice></comune>
<comune><nome>Pavia di Udine</nome><codice>G389</codice></comune>
<comune><nome>Pavone Canavese</nome><codice>G392</codice></comune>
<comune><nome>Pavone del Mella</nome><codice>G391</codice></comune>
<comune><nome>Pavullo nel Frignano</nome><codice>G393</codice></comune>
<comune><nome>Pazzano</nome><codice>G394</codice></comune>
<comune><nome>Peccioli</nome><codice>G395</codice></comune>
<comune><nome>Pecco</nome><codice>G396</codice></comune>
<comune><nome>Pecetto di Valenza</nome><codice>G397</codice></comune>
<comune><nome>Pecetto Torinese</nome><codice>G398</codice></comune>
<comune><nome>Pecorara</nome><codice>G399</codice></comune>
<comune><nome>Pedace</nome><codice>G400</codice></comune>
<comune><nome>Pedara</nome><codice>G402</codice></comune>
<comune><nome>Pedaso</nome><codice>G403</codice></comune>
<comune><nome>Pedavena</nome><codice>G404</codice></comune>
<comune><nome>Pedemonte</nome><codice>G406</codice></comune>
<comune><nome>Pederobba</nome><codice>G408</codice></comune>
<comune><nome>Pedesina</nome><codice>G410</codice></comune>
<comune><nome>Pedivigliano</nome><codice>G411</codice></comune>
<comune><nome>Pedrengo</nome><codice>G412</codice></comune>
<comune><nome>Peglio</nome><codice>G415</codice></comune>
<comune><nome>Peglio</nome><codice>G416</codice></comune>
<comune><nome>Pegognaga</nome><codice>G417</codice></comune>
<comune><nome>Peia</nome><codice>G418</codice></comune>
<comune><nome>Peio</nome><codice>G419</codice></comune>
<comune><nome>Pelago</nome><codice>G420</codice></comune>
<comune><nome>Pella</nome><codice>G421</codice></comune>
<comune><nome>Pellegrino Parmense</nome><codice>G424</codice></comune>
<comune><nome>Pellezzano</nome><codice>G426</codice></comune>
<comune><nome>Pellio Intelvi</nome><codice>G427</codice></comune>
<comune><nome>Pellizzano</nome><codice>G428</codice></comune>
<comune><nome>Pelugo</nome><codice>G429</codice></comune>
<comune><nome>Penango</nome><codice>G430</codice></comune>
<comune><nome>Penna in Teverina</nome><codice>G432</codice></comune>
<comune><nome>Penna San Giovanni</nome><codice>G436</codice></comune>
<comune><nome>Penna Sant'Andrea</nome><codice>G437</codice></comune>
<comune><nome>Pennabilli</nome><codice>G433</codice></comune>
<comune><nome>Pennadomo</nome><codice>G434</codice></comune>
<comune><nome>Pennapiedimonte</nome><codice>G435</codice></comune>
<comune><nome>Penne</nome><codice>G438</codice></comune>
<comune><nome>Pentone</nome><codice>G439</codice></comune>
<comune><nome>Perano</nome><codice>G441</codice></comune>
<comune><nome>Perarolo di Cadore</nome><codice>G442</codice></comune>
<comune><nome>Perca</nome><codice>G443</codice></comune>
<comune><nome>Percile</nome><codice>G444</codice></comune>
<comune><nome>Perdasdefogu</nome><codice>G445</codice></comune>
<comune><nome>Perdaxius</nome><codice>G446</codice></comune>
<comune><nome>Perdifumo</nome><codice>G447</codice></comune>
<comune><nome>Perego</nome><codice>G448</codice></comune>
<comune><nome>Pereto</nome><codice>G449</codice></comune>
<comune><nome>Perfugas</nome><codice>G450</codice></comune>
<comune><nome>Pergine Valdarno</nome><codice>G451</codice></comune>
<comune><nome>Pergine Valsugana</nome><codice>G452</codice></comune>
<comune><nome>Pergola</nome><codice>G453</codice></comune>
<comune><nome>Perinaldo</nome><codice>G454</codice></comune>
<comune><nome>Perito</nome><codice>G455</codice></comune>
<comune><nome>Perledo</nome><codice>G456</codice></comune>
<comune><nome>Perletto</nome><codice>G457</codice></comune>
<comune><nome>Perlo</nome><codice>G458</codice></comune>
<comune><nome>Perloz</nome><codice>G459</codice></comune>
<comune><nome>Pernumia</nome><codice>G461</codice></comune>
<comune><nome>Pero</nome><codice>C013</codice></comune>
<comune><nome>Perosa Argentina</nome><codice>G463</codice></comune>
<comune><nome>Perosa Canavese</nome><codice>G462</codice></comune>
<comune><nome>Perrero</nome><codice>G465</codice></comune>
<comune><nome>Persico Dosimo</nome><codice>G469</codice></comune>
<comune><nome>Pertengo</nome><codice>G471</codice></comune>
<comune><nome>Pertica Alta</nome><codice>G474</codice></comune>
<comune><nome>Pertica Bassa</nome><codice>G475</codice></comune>
<comune><nome>Pertosa</nome><codice>G476</codice></comune>
<comune><nome>Pertusio</nome><codice>G477</codice></comune>
<comune><nome>Perugia</nome><codice>G478</codice></comune>
<comune><nome>Pesaro</nome><codice>G479</codice></comune>
<comune><nome>Pescaglia</nome><codice>G480</codice></comune>
<comune><nome>Pescantina</nome><codice>G481</codice></comune>
<comune><nome>Pescara</nome><codice>G482</codice></comune>
<comune><nome>Pescarolo ed Uniti</nome><codice>G483</codice></comune>
<comune><nome>Pescasseroli</nome><codice>G484</codice></comune>
<comune><nome>Pescate</nome><codice>G485</codice></comune>
<comune><nome>Pesche</nome><codice>G486</codice></comune>
<comune><nome>Peschici</nome><codice>G487</codice></comune>
<comune><nome>Peschiera Borromeo</nome><codice>G488</codice></comune>
<comune><nome>Peschiera del Garda</nome><codice>G489</codice></comune>
<comune><nome>Pescia</nome><codice>G491</codice></comune>
<comune><nome>Pescina</nome><codice>G492</codice></comune>
<comune><nome>Pesco Sannita</nome><codice>G494</codice></comune>
<comune><nome>Pescocostanzo</nome><codice>G493</codice></comune>
<comune><nome>Pescolanciano</nome><codice>G495</codice></comune>
<comune><nome>Pescopagano</nome><codice>G496</codice></comune>
<comune><nome>Pescopennataro</nome><codice>G497</codice></comune>
<comune><nome>Pescorocchiano</nome><codice>G498</codice></comune>
<comune><nome>Pescosansonesco</nome><codice>G499</codice></comune>
<comune><nome>Pescosolido</nome><codice>G500</codice></comune>
<comune><nome>Pessano con Bornago</nome><codice>G502</codice></comune>
<comune><nome>Pessina Cremonese</nome><codice>G504</codice></comune>
<comune><nome>Pessinetto</nome><codice>G505</codice></comune>
<comune><nome>Petacciato</nome><codice>G506</codice></comune>
<comune><nome>Petilia Policastro</nome><codice>G508</codice></comune>
<comune><nome>Petina</nome><codice>G509</codice></comune>
<comune><nome>Petralia Soprana</nome><codice>G510</codice></comune>
<comune><nome>Petralia Sottana</nome><codice>G511</codice></comune>
<comune><nome>Petrella Salto</nome><codice>G513</codice></comune>
<comune><nome>Petrella Tifernina</nome><codice>G512</codice></comune>
<comune><nome>Petriano</nome><codice>G514</codice></comune>
<comune><nome>Petriolo</nome><codice>G515</codice></comune>
<comune><nome>Petritoli</nome><codice>G516</codice></comune>
<comune><nome>Petrizzi</nome><codice>G517</codice></comune>
<comune><nome>Petronà</nome><codice>G518</codice></comune>
<comune><nome>Petrosino</nome><codice>M281</codice></comune>
<comune><nome>Petruro Irpino</nome><codice>G519</codice></comune>
<comune><nome>Pettenasco</nome><codice>G520</codice></comune>
<comune><nome>Pettinengo</nome><codice>G521</codice></comune>
<comune><nome>Pettineo</nome><codice>G522</codice></comune>
<comune><nome>Pettoranello del Molise</nome><codice>G523</codice></comune>
<comune><nome>Pettorano sul Gizio</nome><codice>G524</codice></comune>
<comune><nome>Pettorazza Grimani</nome><codice>G525</codice></comune>
<comune><nome>Peveragno</nome><codice>G526</codice></comune>
<comune><nome>Pezzana</nome><codice>G528</codice></comune>
<comune><nome>Pezzaze</nome><codice>G529</codice></comune>
<comune><nome>Pezzolo Valle Uzzone</nome><codice>G532</codice></comune>
<comune><nome>Piacenza</nome><codice>G535</codice></comune>
<comune><nome>Piacenza d'Adige</nome><codice>G534</codice></comune>
<comune><nome>Piadena</nome><codice>G536</codice></comune>
<comune><nome>Piagge</nome><codice>G537</codice></comune>
<comune><nome>Piaggine</nome><codice>G538</codice></comune>
<comune><nome>Pian Camuno</nome><codice>G546</codice></comune>
<comune><nome>Pian di Sco</nome><codice>G552</codice></comune>
<comune><nome>Piana Crixia</nome><codice>G542</codice></comune>
<comune><nome>Piana degli Albanesi</nome><codice>G543</codice></comune>
<comune><nome>Piana di Monte Verna</nome><codice>G541</codice></comune>
<comune><nome>Piancastagnaio</nome><codice>G547</codice></comune>
<comune><nome>Piancogno</nome><codice>G549</codice></comune>
<comune><nome>Piandimeleto</nome><codice>G551</codice></comune>
<comune><nome>Piane Crati</nome><codice>G553</codice></comune>
<comune><nome>Pianella</nome><codice>G555</codice></comune>
<comune><nome>Pianello del Lario</nome><codice>G556</codice></comune>
<comune><nome>Pianello Val Tidone</nome><codice>G557</codice></comune>
<comune><nome>Pianengo</nome><codice>G558</codice></comune>
<comune><nome>Pianezza</nome><codice>G559</codice></comune>
<comune><nome>Pianezze</nome><codice>G560</codice></comune>
<comune><nome>Pianfei</nome><codice>G561</codice></comune>
<comune><nome>Pianico</nome><codice>G564</codice></comune>
<comune><nome>Pianiga</nome><codice>G565</codice></comune>
<comune><nome>Piano di Sorrento</nome><codice>G568</codice></comune>
<comune><nome>Pianopoli</nome><codice>D546</codice></comune>
<comune><nome>Pianoro</nome><codice>G570</codice></comune>
<comune><nome>Piansano</nome><codice>G571</codice></comune>
<comune><nome>Piantedo</nome><codice>G572</codice></comune>
<comune><nome>Piario</nome><codice>G574</codice></comune>
<comune><nome>Piasco</nome><codice>G575</codice></comune>
<comune><nome>Piateda</nome><codice>G576</codice></comune>
<comune><nome>Piatto</nome><codice>G577</codice></comune>
<comune><nome>Piazza al Serchio</nome><codice>G582</codice></comune>
<comune><nome>Piazza Armerina</nome><codice>G580</codice></comune>
<comune><nome>Piazza Brembana</nome><codice>G579</codice></comune>
<comune><nome>Piazzatorre</nome><codice>G583</codice></comune>
<comune><nome>Piazzola sul Brenta</nome><codice>G587</codice></comune>
<comune><nome>Piazzolo</nome><codice>G588</codice></comune>
<comune><nome>Picciano</nome><codice>G589</codice></comune>
<comune><nome>Picerno</nome><codice>G590</codice></comune>
<comune><nome>Picinisco</nome><codice>G591</codice></comune>
<comune><nome>Pico</nome><codice>G592</codice></comune>
<comune><nome>Piea</nome><codice>G593</codice></comune>
<comune><nome>Piedicavallo</nome><codice>G594</codice></comune>
<comune><nome>Piedimonte Etneo</nome><codice>G597</codice></comune>
<comune><nome>Piedimonte Matese</nome><codice>G596</codice></comune>
<comune><nome>Piedimonte San Germano</nome><codice>G598</codice></comune>
<comune><nome>Piedimulera</nome><codice>G600</codice></comune>
<comune><nome>Piegaro</nome><codice>G601</codice></comune>
<comune><nome>Pienza</nome><codice>G602</codice></comune>
<comune><nome>Pieranica</nome><codice>G603</codice></comune>
<comune><nome>Pietra de' Giorgi</nome><codice>G612</codice></comune>
<comune><nome>Pietra Ligure</nome><codice>G605</codice></comune>
<comune><nome>Pietra Marazzi</nome><codice>G619</codice></comune>
<comune><nome>Pietrabbondante</nome><codice>G606</codice></comune>
<comune><nome>Pietrabruna</nome><codice>G607</codice></comune>
<comune><nome>Pietracamela</nome><codice>G608</codice></comune>
<comune><nome>Pietracatella</nome><codice>G609</codice></comune>
<comune><nome>Pietracupa</nome><codice>G610</codice></comune>
<comune><nome>Pietradefusi</nome><codice>G611</codice></comune>
<comune><nome>Pietraferrazzana</nome><codice>G613</codice></comune>
<comune><nome>Pietrafitta</nome><codice>G615</codice></comune>
<comune><nome>Pietragalla</nome><codice>G616</codice></comune>
<comune><nome>Pietralunga</nome><codice>G618</codice></comune>
<comune><nome>Pietramelara</nome><codice>G620</codice></comune>
<comune><nome>Pietramontecorvino</nome><codice>G604</codice></comune>
<comune><nome>Pietranico</nome><codice>G621</codice></comune>
<comune><nome>Pietrapaola</nome><codice>G622</codice></comune>
<comune><nome>Pietrapertosa</nome><codice>G623</codice></comune>
<comune><nome>Pietraperzia</nome><codice>G624</codice></comune>
<comune><nome>Pietraporzio</nome><codice>G625</codice></comune>
<comune><nome>Pietraroja</nome><codice>G626</codice></comune>
<comune><nome>Pietrarubbia</nome><codice>G627</codice></comune>
<comune><nome>Pietrasanta</nome><codice>G628</codice></comune>
<comune><nome>Pietrastornina</nome><codice>G629</codice></comune>
<comune><nome>Pietravairano</nome><codice>G630</codice></comune>
<comune><nome>Pietrelcina</nome><codice>G631</codice></comune>
<comune><nome>Pieve a Nievole</nome><codice>G636</codice></comune>
<comune><nome>Pieve Albignola</nome><codice>G635</codice></comune>
<comune><nome>Pieve d'Alpago</nome><codice>G638</codice></comune>
<comune><nome>Pieve del Cairo</nome><codice>G639</codice></comune>
<comune><nome>Pieve di Bono</nome><codice>G641</codice></comune>
<comune><nome>Pieve di Cadore</nome><codice>G642</codice></comune>
<comune><nome>Pieve di Cento</nome><codice>G643</codice></comune>
<comune><nome>Pieve di Coriano</nome><codice>G633</codice></comune>
<comune><nome>Pieve di Soligo</nome><codice>G645</codice></comune>
<comune><nome>Pieve di Teco</nome><codice>G632</codice></comune>
<comune><nome>Pieve d'Olmi</nome><codice>G647</codice></comune>
<comune><nome>Pieve Emanuele</nome><codice>G634</codice></comune>
<comune><nome>Pieve Fissiraga</nome><codice>G096</codice></comune>
<comune><nome>Pieve Fosciana</nome><codice>G648</codice></comune>
<comune><nome>Pieve Ligure</nome><codice>G646</codice></comune>
<comune><nome>Pieve Porto Morone</nome><codice>G650</codice></comune>
<comune><nome>Pieve San Giacomo</nome><codice>G651</codice></comune>
<comune><nome>Pieve Santo Stefano</nome><codice>G653</codice></comune>
<comune><nome>Pieve Tesino</nome><codice>G656</codice></comune>
<comune><nome>Pieve Torina</nome><codice>G657</codice></comune>
<comune><nome>Pieve Vergonte</nome><codice>G658</codice></comune>
<comune><nome>Pievebovigliana</nome><codice>G637</codice></comune>
<comune><nome>Pievepelago</nome><codice>G649</codice></comune>
<comune><nome>Piglio</nome><codice>G659</codice></comune>
<comune><nome>Pigna</nome><codice>G660</codice></comune>
<comune><nome>Pignataro Interamna</nome><codice>G662</codice></comune>
<comune><nome>Pignataro Maggiore</nome><codice>G661</codice></comune>
<comune><nome>Pignola</nome><codice>G663</codice></comune>
<comune><nome>Pignone</nome><codice>G664</codice></comune>
<comune><nome>Pigra</nome><codice>G665</codice></comune>
<comune><nome>Pila</nome><codice>G666</codice></comune>
<comune><nome>Pimentel</nome><codice>G669</codice></comune>
<comune><nome>Pimonte</nome><codice>G670</codice></comune>
<comune><nome>Pinarolo Po</nome><codice>G671</codice></comune>
<comune><nome>Pinasca</nome><codice>G672</codice></comune>
<comune><nome>Pincara</nome><codice>G673</codice></comune>
<comune><nome>Pinerolo</nome><codice>G674</codice></comune>
<comune><nome>Pineto</nome><codice>F831</codice></comune>
<comune><nome>Pino d'Asti</nome><codice>G676</codice></comune>
<comune><nome>Pino sulla Sponda del Lago Maggiore</nome><codice>G677</codice></comune>
<comune><nome>Pino Torinese</nome><codice>G678</codice></comune>
<comune><nome>Pinzano al Tagliamento</nome><codice>G680</codice></comune>
<comune><nome>Pinzolo</nome><codice>G681</codice></comune>
<comune><nome>Piobbico</nome><codice>G682</codice></comune>
<comune><nome>Piobesi d'Alba</nome><codice>G683</codice></comune>
<comune><nome>Piobesi Torinese</nome><codice>G684</codice></comune>
<comune><nome>Piode</nome><codice>G685</codice></comune>
<comune><nome>Pioltello</nome><codice>G686</codice></comune>
<comune><nome>Piombino</nome><codice>G687</codice></comune>
<comune><nome>Piombino Dese</nome><codice>G688</codice></comune>
<comune><nome>Pioraco</nome><codice>G690</codice></comune>
<comune><nome>Piossasco</nome><codice>G691</codice></comune>
<comune><nome>Piovà Massaia</nome><codice>G692</codice></comune>
<comune><nome>Piove di Sacco</nome><codice>G693</codice></comune>
<comune><nome>Piovene Rocchette</nome><codice>G694</codice></comune>
<comune><nome>Piovera</nome><codice>G695</codice></comune>
<comune><nome>Piozzano</nome><codice>G696</codice></comune>
<comune><nome>Piozzo</nome><codice>G697</codice></comune>
<comune><nome>Piraino</nome><codice>G699</codice></comune>
<comune><nome>Pisa</nome><codice>G702</codice></comune>
<comune><nome>Pisano</nome><codice>G703</codice></comune>
<comune><nome>Piscina</nome><codice>G705</codice></comune>
<comune><nome>Piscinas</nome><codice>M291</codice></comune>
<comune><nome>Pisciotta</nome><codice>G707</codice></comune>
<comune><nome>Pisogne</nome><codice>G710</codice></comune>
<comune><nome>Pisoniano</nome><codice>G704</codice></comune>
<comune><nome>Pisticci</nome><codice>G712</codice></comune>
<comune><nome>Pistoia</nome><codice>G713</codice></comune>
<comune><nome>Piteglio</nome><codice>G715</codice></comune>
<comune><nome>Pitigliano</nome><codice>G716</codice></comune>
<comune><nome>Piubega</nome><codice>G717</codice></comune>
<comune><nome>Piuro</nome><codice>G718</codice></comune>
<comune><nome>Piverone</nome><codice>G719</codice></comune>
<comune><nome>Pizzale</nome><codice>G720</codice></comune>
<comune><nome>Pizzighettone</nome><codice>G721</codice></comune>
<comune><nome>Pizzo</nome><codice>G722</codice></comune>
<comune><nome>Pizzoferrato</nome><codice>G724</codice></comune>
<comune><nome>Pizzoli</nome><codice>G726</codice></comune>
<comune><nome>Pizzone</nome><codice>G727</codice></comune>
<comune><nome>Pizzoni</nome><codice>G728</codice></comune>
<comune><nome>Placanica</nome><codice>G729</codice></comune>
<comune><nome>Plataci</nome><codice>G733</codice></comune>
<comune><nome>Platania</nome><codice>G734</codice></comune>
<comune><nome>Platì</nome><codice>G735</codice></comune>
<comune><nome>Plaus</nome><codice>G299</codice></comune>
<comune><nome>Plesio</nome><codice>G737</codice></comune>
<comune><nome>Ploaghe</nome><codice>G740</codice></comune>
<comune><nome>Plodio</nome><codice>G741</codice></comune>
<comune><nome>Pocapaglia</nome><codice>G742</codice></comune>
<comune><nome>Pocenia</nome><codice>G743</codice></comune>
<comune><nome>Podenzana</nome><codice>G746</codice></comune>
<comune><nome>Podenzano</nome><codice>G747</codice></comune>
<comune><nome>Pofi</nome><codice>G749</codice></comune>
<comune><nome>Poggiardo</nome><codice>G751</codice></comune>
<comune><nome>Poggibonsi</nome><codice>G752</codice></comune>
<comune><nome>Poggio a Caiano</nome><codice>G754</codice></comune>
<comune><nome>Poggio Berni</nome><codice>G755</codice></comune>
<comune><nome>Poggio Bustone</nome><codice>G756</codice></comune>
<comune><nome>Poggio Catino</nome><codice>G757</codice></comune>
<comune><nome>Poggio Imperiale</nome><codice>G761</codice></comune>
<comune><nome>Poggio Mirteto</nome><codice>G763</codice></comune>
<comune><nome>Poggio Moiano</nome><codice>G764</codice></comune>
<comune><nome>Poggio Nativo</nome><codice>G765</codice></comune>
<comune><nome>Poggio Picenze</nome><codice>G766</codice></comune>
<comune><nome>Poggio Renatico</nome><codice>G768</codice></comune>
<comune><nome>Poggio Rusco</nome><codice>G753</codice></comune>
<comune><nome>Poggio San Lorenzo</nome><codice>G770</codice></comune>
<comune><nome>Poggio San Marcello</nome><codice>G771</codice></comune>
<comune><nome>Poggio San Vicino</nome><codice>D566</codice></comune>
<comune><nome>Poggio Sannita</nome><codice>B317</codice></comune>
<comune><nome>Poggiodomo</nome><codice>G758</codice></comune>
<comune><nome>Poggiofiorito</nome><codice>G760</codice></comune>
<comune><nome>Poggiomarino</nome><codice>G762</codice></comune>
<comune><nome>Poggioreale</nome><codice>G767</codice></comune>
<comune><nome>Poggiorsini</nome><codice>G769</codice></comune>
<comune><nome>Poggiridenti</nome><codice>G431</codice></comune>
<comune><nome>Pogliano Milanese</nome><codice>G772</codice></comune>
<comune><nome>Pognana Lario</nome><codice>G773</codice></comune>
<comune><nome>Pognano</nome><codice>G774</codice></comune>
<comune><nome>Pogno</nome><codice>G775</codice></comune>
<comune><nome>Poirino</nome><codice>G777</codice></comune>
<comune><nome>Pojana Maggiore</nome><codice>G776</codice></comune>
<comune><nome>Polaveno</nome><codice>G779</codice></comune>
<comune><nome>Polcenigo</nome><codice>G780</codice></comune>
<comune><nome>Polesella</nome><codice>G782</codice></comune>
<comune><nome>Polesine Parmense</nome><codice>G783</codice></comune>
<comune><nome>Poli</nome><codice>G784</codice></comune>
<comune><nome>Polia</nome><codice>G785</codice></comune>
<comune><nome>Policoro</nome><codice>G786</codice></comune>
<comune><nome>Polignano a Mare</nome><codice>G787</codice></comune>
<comune><nome>Polinago</nome><codice>G789</codice></comune>
<comune><nome>Polino</nome><codice>G790</codice></comune>
<comune><nome>Polistena</nome><codice>G791</codice></comune>
<comune><nome>Polizzi Generosa</nome><codice>G792</codice></comune>
<comune><nome>Polla</nome><codice>G793</codice></comune>
<comune><nome>Pollein</nome><codice>G794</codice></comune>
<comune><nome>Pollena Trocchia</nome><codice>G795</codice></comune>
<comune><nome>Pollenza</nome><codice>F567</codice></comune>
<comune><nome>Pollica</nome><codice>G796</codice></comune>
<comune><nome>Pollina</nome><codice>G797</codice></comune>
<comune><nome>Pollone</nome><codice>G798</codice></comune>
<comune><nome>Pollutri</nome><codice>G799</codice></comune>
<comune><nome>Polonghera</nome><codice>G800</codice></comune>
<comune><nome>Polpenazze del Garda</nome><codice>G801</codice></comune>
<comune><nome>Polverara</nome><codice>G802</codice></comune>
<comune><nome>Polverigi</nome><codice>G803</codice></comune>
<comune><nome>Pomarance</nome><codice>G804</codice></comune>
<comune><nome>Pomaretto</nome><codice>G805</codice></comune>
<comune><nome>Pomarico</nome><codice>G806</codice></comune>
<comune><nome>Pomaro Monferrato</nome><codice>G807</codice></comune>
<comune><nome>Pomarolo</nome><codice>G808</codice></comune>
<comune><nome>Pombia</nome><codice>G809</codice></comune>
<comune><nome>Pomezia</nome><codice>G811</codice></comune>
<comune><nome>Pomigliano d'Arco</nome><codice>G812</codice></comune>
<comune><nome>Pompei</nome><codice>G813</codice></comune>
<comune><nome>Pompeiana</nome><codice>G814</codice></comune>
<comune><nome>Pompiano</nome><codice>G815</codice></comune>
<comune><nome>Pomponesco</nome><codice>G816</codice></comune>
<comune><nome>Pompu</nome><codice>G817</codice></comune>
<comune><nome>Poncarale</nome><codice>G818</codice></comune>
<comune><nome>Ponderano</nome><codice>G820</codice></comune>
<comune><nome>Ponna</nome><codice>G821</codice></comune>
<comune><nome>Ponsacco</nome><codice>G822</codice></comune>
<comune><nome>Ponso</nome><codice>G823</codice></comune>
<comune><nome>Pontassieve</nome><codice>G825</codice></comune>
<comune><nome>Pontboset</nome><codice>G545</codice></comune>
<comune><nome>Pont-Canavese</nome><codice>G826</codice></comune>
<comune><nome>Ponte</nome><codice>G827</codice></comune>
<comune><nome>Ponte Buggianese</nome><codice>G833</codice></comune>
<comune><nome>Ponte dell'Olio</nome><codice>G842</codice></comune>
<comune><nome>Ponte di Legno</nome><codice>G844</codice></comune>
<comune><nome>Ponte di Piave</nome><codice>G846</codice></comune>
<comune><nome>Ponte Gardena</nome><codice>G830</codice></comune>
<comune><nome>Ponte in Valtellina</nome><codice>G829</codice></comune>
<comune><nome>Ponte Lambro</nome><codice>G847</codice></comune>
<comune><nome>Ponte nelle Alpi</nome><codice>B662</codice></comune>
<comune><nome>Ponte Nizza</nome><codice>G851</codice></comune>
<comune><nome>Ponte Nossa</nome><codice>F941</codice></comune>
<comune><nome>Ponte San Nicolò</nome><codice>G855</codice></comune>
<comune><nome>Ponte San Pietro</nome><codice>G856</codice></comune>
<comune><nome>Pontebba</nome><codice>G831</codice></comune>
<comune><nome>Pontecagnano Faiano</nome><codice>G834</codice></comune>
<comune><nome>Pontecchio Polesine</nome><codice>G836</codice></comune>
<comune><nome>Pontechianale</nome><codice>G837</codice></comune>
<comune><nome>Pontecorvo</nome><codice>G838</codice></comune>
<comune><nome>Pontecurone</nome><codice>G839</codice></comune>
<comune><nome>Pontedassio</nome><codice>G840</codice></comune>
<comune><nome>Pontedera</nome><codice>G843</codice></comune>
<comune><nome>Pontelandolfo</nome><codice>G848</codice></comune>
<comune><nome>Pontelatone</nome><codice>G849</codice></comune>
<comune><nome>Pontelongo</nome><codice>G850</codice></comune>
<comune><nome>Pontenure</nome><codice>G852</codice></comune>
<comune><nome>Ponteranica</nome><codice>G853</codice></comune>
<comune><nome>Pontestura</nome><codice>G858</codice></comune>
<comune><nome>Pontevico</nome><codice>G859</codice></comune>
<comune><nome>Pontey</nome><codice>G860</codice></comune>
<comune><nome>Ponti</nome><codice>G861</codice></comune>
<comune><nome>Ponti sul Mincio</nome><codice>G862</codice></comune>
<comune><nome>Pontida</nome><codice>G864</codice></comune>
<comune><nome>Pontinia</nome><codice>G865</codice></comune>
<comune><nome>Pontinvrea</nome><codice>G866</codice></comune>
<comune><nome>Pontirolo Nuovo</nome><codice>G867</codice></comune>
<comune><nome>Pontoglio</nome><codice>G869</codice></comune>
<comune><nome>Pontremoli</nome><codice>G870</codice></comune>
<comune><nome>Pont-Saint-Martin</nome><codice>G854</codice></comune>
<comune><nome>Ponza</nome><codice>G871</codice></comune>
<comune><nome>Ponzano di Fermo</nome><codice>G873</codice></comune>
<comune><nome>Ponzano Monferrato</nome><codice>G872</codice></comune>
<comune><nome>Ponzano Romano</nome><codice>G874</codice></comune>
<comune><nome>Ponzano Veneto</nome><codice>G875</codice></comune>
<comune><nome>Ponzone</nome><codice>G877</codice></comune>
<comune><nome>Popoli</nome><codice>G878</codice></comune>
<comune><nome>Poppi</nome><codice>G879</codice></comune>
<comune><nome>Porano</nome><codice>G881</codice></comune>
<comune><nome>Porcari</nome><codice>G882</codice></comune>
<comune><nome>Porcia</nome><codice>G886</codice></comune>
<comune><nome>Pordenone</nome><codice>G888</codice></comune>
<comune><nome>Porlezza</nome><codice>G889</codice></comune>
<comune><nome>Pornassio</nome><codice>G890</codice></comune>
<comune><nome>Porpetto</nome><codice>G891</codice></comune>
<comune><nome>Porretta Terme</nome><codice>A558</codice></comune>
<comune><nome>Portacomaro</nome><codice>G894</codice></comune>
<comune><nome>Portalbera</nome><codice>G895</codice></comune>
<comune><nome>Porte</nome><codice>G900</codice></comune>
<comune><nome>Portici</nome><codice>G902</codice></comune>
<comune><nome>Portico di Caserta</nome><codice>G903</codice></comune>
<comune><nome>Portico e San Benedetto</nome><codice>G904</codice></comune>
<comune><nome>Portigliola</nome><codice>G905</codice></comune>
<comune><nome>Porto Azzurro</nome><codice>E680</codice></comune>
<comune><nome>Porto Ceresio</nome><codice>G906</codice></comune>
<comune><nome>Porto Cesareo</nome><codice>M263</codice></comune>
<comune><nome>Porto Empedocle</nome><codice>F299</codice></comune>
<comune><nome>Porto Mantovano</nome><codice>G917</codice></comune>
<comune><nome>Porto Recanati</nome><codice>G919</codice></comune>
<comune><nome>Porto San Giorgio</nome><codice>G920</codice></comune>
<comune><nome>Porto Sant'Elpidio</nome><codice>G921</codice></comune>
<comune><nome>Porto Tolle</nome><codice>G923</codice></comune>
<comune><nome>Porto Torres</nome><codice>G924</codice></comune>
<comune><nome>Porto Valtravaglia</nome><codice>G907</codice></comune>
<comune><nome>Porto Viro</nome><codice>G926</codice></comune>
<comune><nome>Portobuffolè</nome><codice>G909</codice></comune>
<comune><nome>Portocannone</nome><codice>G910</codice></comune>
<comune><nome>Portoferraio</nome><codice>G912</codice></comune>
<comune><nome>Portofino</nome><codice>G913</codice></comune>
<comune><nome>Portogruaro</nome><codice>G914</codice></comune>
<comune><nome>Portomaggiore</nome><codice>G916</codice></comune>
<comune><nome>Portopalo di Capo Passero</nome><codice>M257</codice></comune>
<comune><nome>Portoscuso</nome><codice>G922</codice></comune>
<comune><nome>Portovenere</nome><codice>G925</codice></comune>
<comune><nome>Portula</nome><codice>G927</codice></comune>
<comune><nome>Posada</nome><codice>G929</codice></comune>
<comune><nome>Posina</nome><codice>G931</codice></comune>
<comune><nome>Positano</nome><codice>G932</codice></comune>
<comune><nome>Possagno</nome><codice>G933</codice></comune>
<comune><nome>Posta</nome><codice>G934</codice></comune>
<comune><nome>Posta Fibreno</nome><codice>G935</codice></comune>
<comune><nome>Postal</nome><codice>G936</codice></comune>
<comune><nome>Postalesio</nome><codice>G937</codice></comune>
<comune><nome>Postiglione</nome><codice>G939</codice></comune>
<comune><nome>Postua</nome><codice>G940</codice></comune>
<comune><nome>Potenza</nome><codice>G942</codice></comune>
<comune><nome>Potenza Picena</nome><codice>F632</codice></comune>
<comune><nome>Pove del Grappa</nome><codice>G943</codice></comune>
<comune><nome>Povegliano</nome><codice>G944</codice></comune>
<comune><nome>Povegliano Veronese</nome><codice>G945</codice></comune>
<comune><nome>Poviglio</nome><codice>G947</codice></comune>
<comune><nome>Povoletto</nome><codice>G949</codice></comune>
<comune><nome>Pozza di Fassa</nome><codice>G950</codice></comune>
<comune><nome>Pozzaglia Sabina</nome><codice>G951</codice></comune>
<comune><nome>Pozzaglio ed Uniti</nome><codice>B914</codice></comune>
<comune><nome>Pozzallo</nome><codice>G953</codice></comune>
<comune><nome>Pozzilli</nome><codice>G954</codice></comune>
<comune><nome>Pozzo d'Adda</nome><codice>G955</codice></comune>
<comune><nome>Pozzol Groppo</nome><codice>G960</codice></comune>
<comune><nome>Pozzolengo</nome><codice>G959</codice></comune>
<comune><nome>Pozzoleone</nome><codice>G957</codice></comune>
<comune><nome>Pozzolo Formigaro</nome><codice>G961</codice></comune>
<comune><nome>Pozzomaggiore</nome><codice>G962</codice></comune>
<comune><nome>Pozzonovo</nome><codice>G963</codice></comune>
<comune><nome>Pozzuoli</nome><codice>G964</codice></comune>
<comune><nome>Pozzuolo del Friuli</nome><codice>G966</codice></comune>
<comune><nome>Pozzuolo Martesana</nome><codice>G965</codice></comune>
<comune><nome>Pradalunga</nome><codice>G968</codice></comune>
<comune><nome>Pradamano</nome><codice>G969</codice></comune>
<comune><nome>Pradleves</nome><codice>G970</codice></comune>
<comune><nome>Pragelato</nome><codice>G973</codice></comune>
<comune><nome>Praia a Mare</nome><codice>G975</codice></comune>
<comune><nome>Praiano</nome><codice>G976</codice></comune>
<comune><nome>Pralboino</nome><codice>G977</codice></comune>
<comune><nome>Prali</nome><codice>G978</codice></comune>
<comune><nome>Pralormo</nome><codice>G979</codice></comune>
<comune><nome>Pralungo</nome><codice>G980</codice></comune>
<comune><nome>Pramaggiore</nome><codice>G981</codice></comune>
<comune><nome>Pramollo</nome><codice>G982</codice></comune>
<comune><nome>Prarolo</nome><codice>G985</codice></comune>
<comune><nome>Prarostino</nome><codice>G986</codice></comune>
<comune><nome>Prasco</nome><codice>G987</codice></comune>
<comune><nome>Prascorsano</nome><codice>G988</codice></comune>
<comune><nome>Praso</nome><codice>G989</codice></comune>
<comune><nome>Prata Camportaccio</nome><codice>G993</codice></comune>
<comune><nome>Prata d'Ansidonia</nome><codice>G992</codice></comune>
<comune><nome>Prata di Pordenone</nome><codice>G994</codice></comune>
<comune><nome>Prata di Principato Ultra</nome><codice>G990</codice></comune>
<comune><nome>Prata Sannita</nome><codice>G991</codice></comune>
<comune><nome>Pratella</nome><codice>G995</codice></comune>
<comune><nome>Pratiglione</nome><codice>G997</codice></comune>
<comune><nome>Prato</nome><codice>G999</codice></comune>
<comune><nome>Prato allo Stelvio</nome><codice>H004</codice></comune>
<comune><nome>Prato Carnico</nome><codice>H002</codice></comune>
<comune><nome>Prato Sesia</nome><codice>H001</codice></comune>
<comune><nome>Pratola Peligna</nome><codice>H007</codice></comune>
<comune><nome>Pratola Serra</nome><codice>H006</codice></comune>
<comune><nome>Pratovecchio</nome><codice>H008</codice></comune>
<comune><nome>Pravisdomini</nome><codice>H010</codice></comune>
<comune><nome>Pray</nome><codice>G974</codice></comune>
<comune><nome>Prazzo</nome><codice>H011</codice></comune>
<comune><nome>Precenicco</nome><codice>H014</codice></comune>
<comune><nome>Preci</nome><codice>H015</codice></comune>
<comune><nome>Predappio</nome><codice>H017</codice></comune>
<comune><nome>Predazzo</nome><codice>H018</codice></comune>
<comune><nome>Predoi</nome><codice>H019</codice></comune>
<comune><nome>Predore</nome><codice>H020</codice></comune>
<comune><nome>Predosa</nome><codice>H021</codice></comune>
<comune><nome>Preganziol</nome><codice>H022</codice></comune>
<comune><nome>Pregnana Milanese</nome><codice>H026</codice></comune>
<comune><nome>Prelà</nome><codice>H027</codice></comune>
<comune><nome>Premana</nome><codice>H028</codice></comune>
<comune><nome>Premariacco</nome><codice>H029</codice></comune>
<comune><nome>Premeno</nome><codice>H030</codice></comune>
<comune><nome>Premia</nome><codice>H033</codice></comune>
<comune><nome>Premilcuore</nome><codice>H034</codice></comune>
<comune><nome>Premolo</nome><codice>H036</codice></comune>
<comune><nome>Premosello-Chiovenda</nome><codice>H037</codice></comune>
<comune><nome>Preone</nome><codice>H038</codice></comune>
<comune><nome>Preore</nome><codice>H039</codice></comune>
<comune><nome>Prepotto</nome><codice>H040</codice></comune>
<comune><nome>Prè-Saint-Didier</nome><codice>H042</codice></comune>
<comune><nome>Preseglie</nome><codice>H043</codice></comune>
<comune><nome>Presenzano</nome><codice>H045</codice></comune>
<comune><nome>Presezzo</nome><codice>H046</codice></comune>
<comune><nome>Presicce</nome><codice>H047</codice></comune>
<comune><nome>Pressana</nome><codice>H048</codice></comune>
<comune><nome>Prestine</nome><codice>H050</codice></comune>
<comune><nome>Pretoro</nome><codice>H052</codice></comune>
<comune><nome>Prevalle</nome><codice>H055</codice></comune>
<comune><nome>Prezza</nome><codice>H056</codice></comune>
<comune><nome>Prezzo</nome><codice>H057</codice></comune>
<comune><nome>Priero</nome><codice>H059</codice></comune>
<comune><nome>Prignano Cilento</nome><codice>H062</codice></comune>
<comune><nome>Prignano sulla Secchia</nome><codice>H061</codice></comune>
<comune><nome>Primaluna</nome><codice>H063</codice></comune>
<comune><nome>Priocca</nome><codice>H068</codice></comune>
<comune><nome>Priola</nome><codice>H069</codice></comune>
<comune><nome>Priolo Gargallo</nome><codice>M279</codice></comune>
<comune><nome>Priverno</nome><codice>G698</codice></comune>
<comune><nome>Prizzi</nome><codice>H070</codice></comune>
<comune><nome>Proceno</nome><codice>H071</codice></comune>
<comune><nome>Procida</nome><codice>H072</codice></comune>
<comune><nome>Propata</nome><codice>H073</codice></comune>
<comune><nome>Proserpio</nome><codice>H074</codice></comune>
<comune><nome>Prossedi</nome><codice>H076</codice></comune>
<comune><nome>Provaglio d'Iseo</nome><codice>H078</codice></comune>
<comune><nome>Provaglio Val Sabbia</nome><codice>H077</codice></comune>
<comune><nome>Proves</nome><codice>H081</codice></comune>
<comune><nome>Provvidenti</nome><codice>H083</codice></comune>
<comune><nome>Prunetto</nome><codice>H085</codice></comune>
<comune><nome>Puegnago sul Garda</nome><codice>H086</codice></comune>
<comune><nome>Puglianello</nome><codice>H087</codice></comune>
<comune><nome>Pula</nome><codice>H088</codice></comune>
<comune><nome>Pulfero</nome><codice>H089</codice></comune>
<comune><nome>Pulsano</nome><codice>H090</codice></comune>
<comune><nome>Pumenengo</nome><codice>H091</codice></comune>
<comune><nome>Puos d'Alpago</nome><codice>H092</codice></comune>
<comune><nome>Pusiano</nome><codice>H094</codice></comune>
<comune><nome>Putifigari</nome><codice>H095</codice></comune>
<comune><nome>Putignano</nome><codice>H096</codice></comune>
<comune><nome>Quadrelle</nome><codice>H097</codice></comune>
<comune><nome>Quadri</nome><codice>H098</codice></comune>
<comune><nome>Quagliuzzo</nome><codice>H100</codice></comune>
<comune><nome>Qualiano</nome><codice>H101</codice></comune>
<comune><nome>Quaranti</nome><codice>H102</codice></comune>
<comune><nome>Quaregna</nome><codice>H103</codice></comune>
<comune><nome>Quargnento</nome><codice>H104</codice></comune>
<comune><nome>Quarna Sopra</nome><codice>H106</codice></comune>
<comune><nome>Quarna Sotto</nome><codice>H107</codice></comune>
<comune><nome>Quarona</nome><codice>H108</codice></comune>
<comune><nome>Quarrata</nome><codice>H109</codice></comune>
<comune><nome>Quart</nome><codice>H110</codice></comune>
<comune><nome>Quarto</nome><codice>H114</codice></comune>
<comune><nome>Quarto d'Altino</nome><codice>H117</codice></comune>
<comune><nome>Quartu Sant'Elena</nome><codice>H118</codice></comune>
<comune><nome>Quartucciu</nome><codice>H119</codice></comune>
<comune><nome>Quassolo</nome><codice>H120</codice></comune>
<comune><nome>Quattordio</nome><codice>H121</codice></comune>
<comune><nome>Quattro Castella</nome><codice>H122</codice></comune>
<comune><nome>Quero</nome><codice>H124</codice></comune>
<comune><nome>Quiliano</nome><codice>H126</codice></comune>
<comune><nome>Quincinetto</nome><codice>H127</codice></comune>
<comune><nome>Quindici</nome><codice>H128</codice></comune>
<comune><nome>Quingentole</nome><codice>H129</codice></comune>
<comune><nome>Quintano</nome><codice>H130</codice></comune>
<comune><nome>Quinto di Treviso</nome><codice>H131</codice></comune>
<comune><nome>Quinto Vercellese</nome><codice>H132</codice></comune>
<comune><nome>Quinto Vicentino</nome><codice>H134</codice></comune>
<comune><nome>Quinzano d'Oglio</nome><codice>H140</codice></comune>
<comune><nome>Quistello</nome><codice>H143</codice></comune>
<comune><nome>Quittengo</nome><codice>H145</codice></comune>
<comune><nome>Rabbi</nome><codice>H146</codice></comune>
<comune><nome>Racale</nome><codice>H147</codice></comune>
<comune><nome>Racalmuto</nome><codice>H148</codice></comune>
<comune><nome>Racconigi</nome><codice>H150</codice></comune>
<comune><nome>Raccuja</nome><codice>H151</codice></comune>
<comune><nome>Racines</nome><codice>H152</codice></comune>
<comune><nome>Radda in Chianti</nome><codice>H153</codice></comune>
<comune><nome>Raddusa</nome><codice>H154</codice></comune>
<comune><nome>Radicofani</nome><codice>H156</codice></comune>
<comune><nome>Radicondoli</nome><codice>H157</codice></comune>
<comune><nome>Raffadali</nome><codice>H159</codice></comune>
<comune><nome>Ragalna</nome><codice>M287</codice></comune>
<comune><nome>Ragogna</nome><codice>H161</codice></comune>
<comune><nome>Ragoli</nome><codice>H162</codice></comune>
<comune><nome>Ragusa</nome><codice>H163</codice></comune>
<comune><nome>Raiano</nome><codice>H166</codice></comune>
<comune><nome>Ramacca</nome><codice>H168</codice></comune>
<comune><nome>Ramiseto</nome><codice>G654</codice></comune>
<comune><nome>Ramponio Verna</nome><codice>H171</codice></comune>
<comune><nome>Rancio Valcuvia</nome><codice>H173</codice></comune>
<comune><nome>Ranco</nome><codice>H174</codice></comune>
<comune><nome>Randazzo</nome><codice>H175</codice></comune>
<comune><nome>Ranica</nome><codice>H176</codice></comune>
<comune><nome>Ranzanico</nome><codice>H177</codice></comune>
<comune><nome>Ranzo</nome><codice>H180</codice></comune>
<comune><nome>Rapagnano</nome><codice>H182</codice></comune>
<comune><nome>Rapallo</nome><codice>H183</codice></comune>
<comune><nome>Rapino</nome><codice>H184</codice></comune>
<comune><nome>Rapolano Terme</nome><codice>H185</codice></comune>
<comune><nome>Rapolla</nome><codice>H186</codice></comune>
<comune><nome>Rapone</nome><codice>H187</codice></comune>
<comune><nome>Rassa</nome><codice>H188</codice></comune>
<comune><nome>Rasun Anterselva</nome><codice>H189</codice></comune>
<comune><nome>Rasura</nome><codice>H192</codice></comune>
<comune><nome>Ravanusa</nome><codice>H194</codice></comune>
<comune><nome>Ravarino</nome><codice>H195</codice></comune>
<comune><nome>Ravascletto</nome><codice>H196</codice></comune>
<comune><nome>Ravello</nome><codice>H198</codice></comune>
<comune><nome>Ravenna</nome><codice>H199</codice></comune>
<comune><nome>Raveo</nome><codice>H200</codice></comune>
<comune><nome>Raviscanina</nome><codice>H202</codice></comune>
<comune><nome>Re</nome><codice>H203</codice></comune>
<comune><nome>Rea</nome><codice>H204</codice></comune>
<comune><nome>Realmonte</nome><codice>H205</codice></comune>
<comune><nome>Reana del Rojale</nome><codice>H206</codice></comune>
<comune><nome>Reano</nome><codice>H207</codice></comune>
<comune><nome>Recale</nome><codice>H210</codice></comune>
<comune><nome>Recanati</nome><codice>H211</codice></comune>
<comune><nome>Recco</nome><codice>H212</codice></comune>
<comune><nome>Recetto</nome><codice>H213</codice></comune>
<comune><nome>Recoaro Terme</nome><codice>H214</codice></comune>
<comune><nome>Redavalle</nome><codice>H216</codice></comune>
<comune><nome>Redondesco</nome><codice>H218</codice></comune>
<comune><nome>Refrancore</nome><codice>H219</codice></comune>
<comune><nome>Refrontolo</nome><codice>H220</codice></comune>
<comune><nome>Regalbuto</nome><codice>H221</codice></comune>
<comune><nome>Reggello</nome><codice>H222</codice></comune>
<comune><nome>Reggio Calabria</nome><codice>H224</codice></comune>
<comune><nome>Reggio Emilia</nome><codice>H223</codice></comune>
<comune><nome>Reggiolo</nome><codice>H225</codice></comune>
<comune><nome>Reino</nome><codice>H227</codice></comune>
<comune><nome>Reitano</nome><codice>H228</codice></comune>
<comune><nome>Remanzacco</nome><codice>H229</codice></comune>
<comune><nome>Remedello</nome><codice>H230</codice></comune>
<comune><nome>Renate</nome><codice>H233</codice></comune>
<comune><nome>Rende</nome><codice>H235</codice></comune>
<comune><nome>Renon</nome><codice>H236</codice></comune>
<comune><nome>Resana</nome><codice>H238</codice></comune>
<comune><nome>Rescaldina</nome><codice>H240</codice></comune>
<comune><nome>Resia</nome><codice>H242</codice></comune>
<comune><nome>Resiutta</nome><codice>H244</codice></comune>
<comune><nome>Resuttano</nome><codice>H245</codice></comune>
<comune><nome>Retorbido</nome><codice>H246</codice></comune>
<comune><nome>Revello</nome><codice>H247</codice></comune>
<comune><nome>Revere</nome><codice>H248</codice></comune>
<comune><nome>Revigliasco d'Asti</nome><codice>H250</codice></comune>
<comune><nome>Revine Lago</nome><codice>H253</codice></comune>
<comune><nome>Revò</nome><codice>H254</codice></comune>
<comune><nome>Rezzago</nome><codice>H255</codice></comune>
<comune><nome>Rezzato</nome><codice>H256</codice></comune>
<comune><nome>Rezzo</nome><codice>H257</codice></comune>
<comune><nome>Rezzoaglio</nome><codice>H258</codice></comune>
<comune><nome>Rhemes-Notre-Dame</nome><codice>H262</codice></comune>
<comune><nome>Rhemes-Saint-Georges</nome><codice>H263</codice></comune>
<comune><nome>Rho</nome><codice>H264</codice></comune>
<comune><nome>Riace</nome><codice>H265</codice></comune>
<comune><nome>Rialto</nome><codice>H266</codice></comune>
<comune><nome>Riano</nome><codice>H267</codice></comune>
<comune><nome>Riardo</nome><codice>H268</codice></comune>
<comune><nome>Ribera</nome><codice>H269</codice></comune>
<comune><nome>Ribordone</nome><codice>H270</codice></comune>
<comune><nome>Ricadi</nome><codice>H271</codice></comune>
<comune><nome>Ricaldone</nome><codice>H272</codice></comune>
<comune><nome>Riccia</nome><codice>H273</codice></comune>
<comune><nome>Riccione</nome><codice>H274</codice></comune>
<comune><nome>Riccò del Golfo di Spezia</nome><codice>H275</codice></comune>
<comune><nome>Ricengo</nome><codice>H276</codice></comune>
<comune><nome>Ricigliano</nome><codice>H277</codice></comune>
<comune><nome>Riese Pio X</nome><codice>H280</codice></comune>
<comune><nome>Riesi</nome><codice>H281</codice></comune>
<comune><nome>Rieti</nome><codice>H282</codice></comune>
<comune><nome>Rifiano</nome><codice>H284</codice></comune>
<comune><nome>Rifreddo</nome><codice>H285</codice></comune>
<comune><nome>Rignano Flaminio</nome><codice>H288</codice></comune>
<comune><nome>Rignano Garganico</nome><codice>H287</codice></comune>
<comune><nome>Rignano sull'Arno</nome><codice>H286</codice></comune>
<comune><nome>Rigolato</nome><codice>H289</codice></comune>
<comune><nome>Rima San Giuseppe</nome><codice>H291</codice></comune>
<comune><nome>Rimasco</nome><codice>H292</codice></comune>
<comune><nome>Rimella</nome><codice>H293</codice></comune>
<comune><nome>Rimini</nome><codice>H294</codice></comune>
<comune><nome>Rio di Pusteria</nome><codice>H299</codice></comune>
<comune><nome>Rio Marina</nome><codice>H305</codice></comune>
<comune><nome>Rio nell'Elba</nome><codice>H297</codice></comune>
<comune><nome>Rio Saliceto</nome><codice>H298</codice></comune>
<comune><nome>Riofreddo</nome><codice>H300</codice></comune>
<comune><nome>Riola Sardo</nome><codice>H301</codice></comune>
<comune><nome>Riolo Terme</nome><codice>H302</codice></comune>
<comune><nome>Riolunato</nome><codice>H303</codice></comune>
<comune><nome>Riomaggiore</nome><codice>H304</codice></comune>
<comune><nome>Rionero in Vulture</nome><codice>H307</codice></comune>
<comune><nome>Rionero Sannitico</nome><codice>H308</codice></comune>
<comune><nome>Ripa Teatina</nome><codice>H320</codice></comune>
<comune><nome>Ripabottoni</nome><codice>H311</codice></comune>
<comune><nome>Ripacandida</nome><codice>H312</codice></comune>
<comune><nome>Ripalimosani</nome><codice>H313</codice></comune>
<comune><nome>Ripalta Arpina</nome><codice>H314</codice></comune>
<comune><nome>Ripalta Cremasca</nome><codice>H315</codice></comune>
<comune><nome>Ripalta Guerina</nome><codice>H316</codice></comune>
<comune><nome>Riparbella</nome><codice>H319</codice></comune>
<comune><nome>Ripatransone</nome><codice>H321</codice></comune>
<comune><nome>Ripe</nome><codice>H322</codice></comune>
<comune><nome>Ripe San Ginesio</nome><codice>H323</codice></comune>
<comune><nome>Ripi</nome><codice>H324</codice></comune>
<comune><nome>Riposto</nome><codice>H325</codice></comune>
<comune><nome>Rittana</nome><codice>H326</codice></comune>
<comune><nome>Riva del Garda</nome><codice>H330</codice></comune>
<comune><nome>Riva di Solto</nome><codice>H331</codice></comune>
<comune><nome>Riva Ligure</nome><codice>H328</codice></comune>
<comune><nome>Riva Presso Chieri</nome><codice>H337</codice></comune>
<comune><nome>Riva Valdobbia</nome><codice>H329</codice></comune>
<comune><nome>Rivalba</nome><codice>H333</codice></comune>
<comune><nome>Rivalta Bormida</nome><codice>H334</codice></comune>
<comune><nome>Rivalta di Torino</nome><codice>H335</codice></comune>
<comune><nome>Rivamonte Agordino</nome><codice>H327</codice></comune>
<comune><nome>Rivanazzano Terme</nome><codice>H336</codice></comune>
<comune><nome>Rivara</nome><codice>H338</codice></comune>
<comune><nome>Rivarolo Canavese</nome><codice>H340</codice></comune>
<comune><nome>Rivarolo del Re ed Uniti</nome><codice>H341</codice></comune>
<comune><nome>Rivarolo Mantovano</nome><codice>H342</codice></comune>
<comune><nome>Rivarone</nome><codice>H343</codice></comune>
<comune><nome>Rivarossa</nome><codice>H344</codice></comune>
<comune><nome>Rive</nome><codice>H346</codice></comune>
<comune><nome>Rive D'Arcano</nome><codice>H347</codice></comune>
<comune><nome>Rivello</nome><codice>H348</codice></comune>
<comune><nome>Rivergaro</nome><codice>H350</codice></comune>
<comune><nome>Rivignano</nome><codice>H352</codice></comune>
<comune><nome>Rivisondoli</nome><codice>H353</codice></comune>
<comune><nome>Rivodutri</nome><codice>H354</codice></comune>
<comune><nome>Rivoli</nome><codice>H355</codice></comune>
<comune><nome>Rivoli Veronese</nome><codice>H356</codice></comune>
<comune><nome>Rivolta d'Adda</nome><codice>H357</codice></comune>
<comune><nome>Rizziconi</nome><codice>H359</codice></comune>
<comune><nome>Ro</nome><codice>H360</codice></comune>
<comune><nome>Roana</nome><codice>H361</codice></comune>
<comune><nome>Roaschia</nome><codice>H362</codice></comune>
<comune><nome>Roascio</nome><codice>H363</codice></comune>
<comune><nome>Roasio</nome><codice>H365</codice></comune>
<comune><nome>Roatto</nome><codice>H366</codice></comune>
<comune><nome>Robassomero</nome><codice>H367</codice></comune>
<comune><nome>Robbiate</nome><codice>G223</codice></comune>
<comune><nome>Robbio</nome><codice>H369</codice></comune>
<comune><nome>Robecchetto con Induno</nome><codice>H371</codice></comune>
<comune><nome>Robecco d'Oglio</nome><codice>H372</codice></comune>
<comune><nome>Robecco Pavese</nome><codice>H375</codice></comune>
<comune><nome>Robecco sul Naviglio</nome><codice>H373</codice></comune>
<comune><nome>Robella</nome><codice>H376</codice></comune>
<comune><nome>Robilante</nome><codice>H377</codice></comune>
<comune><nome>Roburent</nome><codice>H378</codice></comune>
<comune><nome>Rocca Canavese</nome><codice>H386</codice></comune>
<comune><nome>Rocca Canterano</nome><codice>H387</codice></comune>
<comune><nome>Rocca Cigliè</nome><codice>H391</codice></comune>
<comune><nome>Rocca d'Arazzo</nome><codice>H392</codice></comune>
<comune><nome>Rocca d'Arce</nome><codice>H393</codice></comune>
<comune><nome>Rocca de' Baldi</nome><codice>H395</codice></comune>
<comune><nome>Rocca de' Giorgi</nome><codice>H396</codice></comune>
<comune><nome>Rocca D'Evandro</nome><codice>H398</codice></comune>
<comune><nome>Rocca di Botte</nome><codice>H399</codice></comune>
<comune><nome>Rocca di Cambio</nome><codice>H400</codice></comune>
<comune><nome>Rocca di Cave</nome><codice>H401</codice></comune>
<comune><nome>Rocca di Mezzo</nome><codice>H402</codice></comune>
<comune><nome>Rocca di Neto</nome><codice>H403</codice></comune>
<comune><nome>Rocca di Papa</nome><codice>H404</codice></comune>
<comune><nome>Rocca Grimalda</nome><codice>H414</codice></comune>
<comune><nome>Rocca Imperiale</nome><codice>H416</codice></comune>
<comune><nome>Rocca Massima</nome><codice>H421</codice></comune>
<comune><nome>Rocca Pia</nome><codice>H429</codice></comune>
<comune><nome>Rocca Pietore</nome><codice>H379</codice></comune>
<comune><nome>Rocca Priora</nome><codice>H432</codice></comune>
<comune><nome>Rocca San Casciano</nome><codice>H437</codice></comune>
<comune><nome>Rocca San Felice</nome><codice>H438</codice></comune>
<comune><nome>Rocca San Giovanni</nome><codice>H439</codice></comune>
<comune><nome>Rocca Santa Maria</nome><codice>H440</codice></comune>
<comune><nome>Rocca Santo Stefano</nome><codice>H441</codice></comune>
<comune><nome>Rocca Sinibalda</nome><codice>H446</codice></comune>
<comune><nome>Rocca Susella</nome><codice>H450</codice></comune>
<comune><nome>Roccabascerana</nome><codice>H382</codice></comune>
<comune><nome>Roccabernarda</nome><codice>H383</codice></comune>
<comune><nome>Roccabianca</nome><codice>H384</codice></comune>
<comune><nome>Roccabruna</nome><codice>H385</codice></comune>
<comune><nome>Roccacasale</nome><codice>H389</codice></comune>
<comune><nome>Roccadaspide</nome><codice>H394</codice></comune>
<comune><nome>Roccafiorita</nome><codice>H405</codice></comune>
<comune><nome>Roccafluvione</nome><codice>H390</codice></comune>
<comune><nome>Roccaforte del Greco</nome><codice>H408</codice></comune>
<comune><nome>Roccaforte Ligure</nome><codice>H406</codice></comune>
<comune><nome>Roccaforte Mondovì</nome><codice>H407</codice></comune>
<comune><nome>Roccaforzata</nome><codice>H409</codice></comune>
<comune><nome>Roccafranca</nome><codice>H410</codice></comune>
<comune><nome>Roccagiovine</nome><codice>H411</codice></comune>
<comune><nome>Roccagloriosa</nome><codice>H412</codice></comune>
<comune><nome>Roccagorga</nome><codice>H413</codice></comune>
<comune><nome>Roccalbegna</nome><codice>H417</codice></comune>
<comune><nome>Roccalumera</nome><codice>H418</codice></comune>
<comune><nome>Roccamandolfi</nome><codice>H420</codice></comune>
<comune><nome>Roccamena</nome><codice>H422</codice></comune>
<comune><nome>Roccamonfina</nome><codice>H423</codice></comune>
<comune><nome>Roccamontepiano</nome><codice>H424</codice></comune>
<comune><nome>Roccamorice</nome><codice>H425</codice></comune>
<comune><nome>Roccanova</nome><codice>H426</codice></comune>
<comune><nome>Roccantica</nome><codice>H427</codice></comune>
<comune><nome>Roccapalumba</nome><codice>H428</codice></comune>
<comune><nome>Roccapiemonte</nome><codice>H431</codice></comune>
<comune><nome>Roccarainola</nome><codice>H433</codice></comune>
<comune><nome>Roccaraso</nome><codice>H434</codice></comune>
<comune><nome>Roccaromana</nome><codice>H436</codice></comune>
<comune><nome>Roccascalegna</nome><codice>H442</codice></comune>
<comune><nome>Roccasecca</nome><codice>H443</codice></comune>
<comune><nome>Roccasecca dei Volsci</nome><codice>H444</codice></comune>
<comune><nome>Roccasicura</nome><codice>H445</codice></comune>
<comune><nome>Roccasparvera</nome><codice>H447</codice></comune>
<comune><nome>Roccaspinalveti</nome><codice>H448</codice></comune>
<comune><nome>Roccastrada</nome><codice>H449</codice></comune>
<comune><nome>Roccavaldina</nome><codice>H380</codice></comune>
<comune><nome>Roccaverano</nome><codice>H451</codice></comune>
<comune><nome>Roccavignale</nome><codice>H452</codice></comune>
<comune><nome>Roccavione</nome><codice>H453</codice></comune>
<comune><nome>Roccavivara</nome><codice>H454</codice></comune>
<comune><nome>Roccella Ionica</nome><codice>H456</codice></comune>
<comune><nome>Roccella Valdemone</nome><codice>H455</codice></comune>
<comune><nome>Rocchetta a Volturno</nome><codice>H458</codice></comune>
<comune><nome>Rocchetta Belbo</nome><codice>H462</codice></comune>
<comune><nome>Rocchetta di Vara</nome><codice>H461</codice></comune>
<comune><nome>Rocchetta e Croce</nome><codice>H459</codice></comune>
<comune><nome>Rocchetta Ligure</nome><codice>H465</codice></comune>
<comune><nome>Rocchetta Nervina</nome><codice>H460</codice></comune>
<comune><nome>Rocchetta Palafea</nome><codice>H466</codice></comune>
<comune><nome>Rocchetta Sant'Antonio</nome><codice>H467</codice></comune>
<comune><nome>Rocchetta Tanaro</nome><codice>H468</codice></comune>
<comune><nome>Rodano</nome><codice>H470</codice></comune>
<comune><nome>Roddi</nome><codice>H472</codice></comune>
<comune><nome>Roddino</nome><codice>H473</codice></comune>
<comune><nome>Rodello</nome><codice>H474</codice></comune>
<comune><nome>Rodengo</nome><codice>H475</codice></comune>
<comune><nome>Rodengo Saiano</nome><codice>H477</codice></comune>
<comune><nome>Rodero</nome><codice>H478</codice></comune>
<comune><nome>Rodi Garganico</nome><codice>H480</codice></comune>
<comune><nome>Rodì Milici</nome><codice>H479</codice></comune>
<comune><nome>Rodigo</nome><codice>H481</codice></comune>
<comune><nome>Roè Volciano</nome><codice>H484</codice></comune>
<comune><nome>Rofrano</nome><codice>H485</codice></comune>
<comune><nome>Rogeno</nome><codice>H486</codice></comune>
<comune><nome>Roggiano Gravina</nome><codice>H488</codice></comune>
<comune><nome>Roghudi</nome><codice>H489</codice></comune>
<comune><nome>Rogliano</nome><codice>H490</codice></comune>
<comune><nome>Rognano</nome><codice>H491</codice></comune>
<comune><nome>Rogno</nome><codice>H492</codice></comune>
<comune><nome>Rogolo</nome><codice>H493</codice></comune>
<comune><nome>Roiate</nome><codice>H494</codice></comune>
<comune><nome>Roio del Sangro</nome><codice>H495</codice></comune>
<comune><nome>Roisan</nome><codice>H497</codice></comune>
<comune><nome>Roletto</nome><codice>H498</codice></comune>
<comune><nome>Rolo</nome><codice>H500</codice></comune>
<comune><nome>Roma</nome><codice>H501</codice></comune>
<comune><nome>Romagnano al Monte</nome><codice>H503</codice></comune>
<comune><nome>Romagnano Sesia</nome><codice>H502</codice></comune>
<comune><nome>Romagnese</nome><codice>H505</codice></comune>
<comune><nome>Romallo</nome><codice>H506</codice></comune>
<comune><nome>Romana</nome><codice>H507</codice></comune>
<comune><nome>Romanengo</nome><codice>H508</codice></comune>
<comune><nome>Romano Canavese</nome><codice>H511</codice></comune>
<comune><nome>Romano d'Ezzelino</nome><codice>H512</codice></comune>
<comune><nome>Romano di Lombardia</nome><codice>H509</codice></comune>
<comune><nome>Romans d'Isonzo</nome><codice>H514</codice></comune>
<comune><nome>Rombiolo</nome><codice>H516</codice></comune>
<comune><nome>Romeno</nome><codice>H517</codice></comune>
<comune><nome>Romentino</nome><codice>H518</codice></comune>
<comune><nome>Rometta</nome><codice>H519</codice></comune>
<comune><nome>Ronago</nome><codice>H521</codice></comune>
<comune><nome>Roncà</nome><codice>H522</codice></comune>
<comune><nome>Roncade</nome><codice>H523</codice></comune>
<comune><nome>Roncadelle</nome><codice>H525</codice></comune>
<comune><nome>Roncaro</nome><codice>H527</codice></comune>
<comune><nome>Roncegno Terme</nome><codice>H528</codice></comune>
<comune><nome>Roncello</nome><codice>H529</codice></comune>
<comune><nome>Ronchi dei Legionari</nome><codice>H531</codice></comune>
<comune><nome>Ronchi Valsugana</nome><codice>H532</codice></comune>
<comune><nome>Ronchis</nome><codice>H533</codice></comune>
<comune><nome>Ronciglione</nome><codice>H534</codice></comune>
<comune><nome>Ronco all'Adige</nome><codice>H540</codice></comune>
<comune><nome>Ronco Biellese</nome><codice>H538</codice></comune>
<comune><nome>Ronco Briantino</nome><codice>H537</codice></comune>
<comune><nome>Ronco Canavese</nome><codice>H539</codice></comune>
<comune><nome>Ronco Scrivia</nome><codice>H536</codice></comune>
<comune><nome>Roncobello</nome><codice>H535</codice></comune>
<comune><nome>Roncoferraro</nome><codice>H541</codice></comune>
<comune><nome>Roncofreddo</nome><codice>H542</codice></comune>
<comune><nome>Roncola</nome><codice>H544</codice></comune>
<comune><nome>Roncone</nome><codice>H545</codice></comune>
<comune><nome>Rondanina</nome><codice>H546</codice></comune>
<comune><nome>Rondissone</nome><codice>H547</codice></comune>
<comune><nome>Ronsecco</nome><codice>H549</codice></comune>
<comune><nome>Ronzo-Chienis</nome><codice>M303</codice></comune>
<comune><nome>Ronzone</nome><codice>H552</codice></comune>
<comune><nome>Roppolo</nome><codice>H553</codice></comune>
<comune><nome>Rorà</nome><codice>H554</codice></comune>
<comune><nome>Rosà</nome><codice>H556</codice></comune>
<comune><nome>Rosarno</nome><codice>H558</codice></comune>
<comune><nome>Rosasco</nome><codice>H559</codice></comune>
<comune><nome>Rosate</nome><codice>H560</codice></comune>
<comune><nome>Rosazza</nome><codice>H561</codice></comune>
<comune><nome>Rosciano</nome><codice>H562</codice></comune>
<comune><nome>Roscigno</nome><codice>H564</codice></comune>
<comune><nome>Rose</nome><codice>H565</codice></comune>
<comune><nome>Rosello</nome><codice>H566</codice></comune>
<comune><nome>Roseto Capo Spulico</nome><codice>H572</codice></comune>
<comune><nome>Roseto degli Abruzzi</nome><codice>F585</codice></comune>
<comune><nome>Roseto Valfortore</nome><codice>H568</codice></comune>
<comune><nome>Rosignano Marittimo</nome><codice>H570</codice></comune>
<comune><nome>Rosignano Monferrato</nome><codice>H569</codice></comune>
<comune><nome>Rosolina</nome><codice>H573</codice></comune>
<comune><nome>Rosolini</nome><codice>H574</codice></comune>
<comune><nome>Rosora</nome><codice>H575</codice></comune>
<comune><nome>Rossa</nome><codice>H577</codice></comune>
<comune><nome>Rossana</nome><codice>H578</codice></comune>
<comune><nome>Rossano</nome><codice>H579</codice></comune>
<comune><nome>Rossano Veneto</nome><codice>H580</codice></comune>
<comune><nome>Rossiglione</nome><codice>H581</codice></comune>
<comune><nome>Rosta</nome><codice>H583</codice></comune>
<comune><nome>Rota d'Imagna</nome><codice>H584</codice></comune>
<comune><nome>Rota Greca</nome><codice>H585</codice></comune>
<comune><nome>Rotella</nome><codice>H588</codice></comune>
<comune><nome>Rotello</nome><codice>H589</codice></comune>
<comune><nome>Rotonda</nome><codice>H590</codice></comune>
<comune><nome>Rotondella</nome><codice>H591</codice></comune>
<comune><nome>Rotondi</nome><codice>H592</codice></comune>
<comune><nome>Rottofreno</nome><codice>H593</codice></comune>
<comune><nome>Rotzo</nome><codice>H594</codice></comune>
<comune><nome>Roure</nome><codice>H555</codice></comune>
<comune><nome>Rovagnate</nome><codice>H596</codice></comune>
<comune><nome>Rovasenda</nome><codice>H364</codice></comune>
<comune><nome>Rovato</nome><codice>H598</codice></comune>
<comune><nome>Rovegno</nome><codice>H599</codice></comune>
<comune><nome>Rovellasca</nome><codice>H601</codice></comune>
<comune><nome>Rovello Porro</nome><codice>H602</codice></comune>
<comune><nome>Roverbella</nome><codice>H604</codice></comune>
<comune><nome>Roverchiara</nome><codice>H606</codice></comune>
<comune><nome>Roverè della Luna</nome><codice>H607</codice></comune>
<comune><nome>Roverè Veronese</nome><codice>H608</codice></comune>
<comune><nome>Roveredo di Guà</nome><codice>H610</codice></comune>
<comune><nome>Roveredo in Piano</nome><codice>H609</codice></comune>
<comune><nome>Rovereto</nome><codice>H612</codice></comune>
<comune><nome>Rovescala</nome><codice>H614</codice></comune>
<comune><nome>Rovetta</nome><codice>H615</codice></comune>
<comune><nome>Roviano</nome><codice>H618</codice></comune>
<comune><nome>Rovigo</nome><codice>H620</codice></comune>
<comune><nome>Rovito</nome><codice>H621</codice></comune>
<comune><nome>Rovolon</nome><codice>H622</codice></comune>
<comune><nome>Rozzano</nome><codice>H623</codice></comune>
<comune><nome>Rubano</nome><codice>H625</codice></comune>
<comune><nome>Rubiana</nome><codice>H627</codice></comune>
<comune><nome>Rubiera</nome><codice>H628</codice></comune>
<comune><nome>Ruda</nome><codice>H629</codice></comune>
<comune><nome>Rudiano</nome><codice>H630</codice></comune>
<comune><nome>Rueglio</nome><codice>H631</codice></comune>
<comune><nome>Ruffano</nome><codice>H632</codice></comune>
<comune><nome>Ruffia</nome><codice>H633</codice></comune>
<comune><nome>Ruffrè-Mendola</nome><codice>H634</codice></comune>
<comune><nome>Rufina</nome><codice>H635</codice></comune>
<comune><nome>Ruinas</nome><codice>F271</codice></comune>
<comune><nome>Ruino</nome><codice>H637</codice></comune>
<comune><nome>Rumo</nome><codice>H639</codice></comune>
<comune><nome>Ruoti</nome><codice>H641</codice></comune>
<comune><nome>Russi</nome><codice>H642</codice></comune>
<comune><nome>Rutigliano</nome><codice>H643</codice></comune>
<comune><nome>Rutino</nome><codice>H644</codice></comune>
<comune><nome>Ruviano</nome><codice>H165</codice></comune>
<comune><nome>Ruvo del Monte</nome><codice>H646</codice></comune>
<comune><nome>Ruvo di Puglia</nome><codice>H645</codice></comune>
<comune><nome>Sabaudia</nome><codice>H647</codice></comune>
<comune><nome>Sabbia</nome><codice>H648</codice></comune>
<comune><nome>Sabbio Chiese</nome><codice>H650</codice></comune>
<comune><nome>Sabbioneta</nome><codice>H652</codice></comune>
<comune><nome>Sacco</nome><codice>H654</codice></comune>
<comune><nome>Saccolongo</nome><codice>H655</codice></comune>
<comune><nome>Sacile</nome><codice>H657</codice></comune>
<comune><nome>Sacrofano</nome><codice>H658</codice></comune>
<comune><nome>Sadali</nome><codice>H659</codice></comune>
<comune><nome>Sagama</nome><codice>H661</codice></comune>
<comune><nome>Sagliano Micca</nome><codice>H662</codice></comune>
<comune><nome>Sagrado</nome><codice>H665</codice></comune>
<comune><nome>Sagron Mis</nome><codice>H666</codice></comune>
<comune><nome>Saint-Christophe</nome><codice>H669</codice></comune>
<comune><nome>Saint-Denis</nome><codice>H670</codice></comune>
<comune><nome>Saint-Marcel</nome><codice>H671</codice></comune>
<comune><nome>Saint-Nicolas</nome><codice>H672</codice></comune>
<comune><nome>Saint-Oyen</nome><codice>H673</codice></comune>
<comune><nome>Saint-Pierre</nome><codice>H674</codice></comune>
<comune><nome>Saint-Rhémy-en-Bosses</nome><codice>H675</codice></comune>
<comune><nome>Saint-Vincent</nome><codice>H676</codice></comune>
<comune><nome>Sala Baganza</nome><codice>H682</codice></comune>
<comune><nome>Sala Biellese</nome><codice>H681</codice></comune>
<comune><nome>Sala Bolognese</nome><codice>H678</codice></comune>
<comune><nome>Sala Comacina</nome><codice>H679</codice></comune>
<comune><nome>Sala Consilina</nome><codice>H683</codice></comune>
<comune><nome>Sala Monferrato</nome><codice>H677</codice></comune>
<comune><nome>Salandra</nome><codice>H687</codice></comune>
<comune><nome>Salaparuta</nome><codice>H688</codice></comune>
<comune><nome>Salara</nome><codice>H689</codice></comune>
<comune><nome>Salasco</nome><codice>H690</codice></comune>
<comune><nome>Salassa</nome><codice>H691</codice></comune>
<comune><nome>Salbertrand</nome><codice>H684</codice></comune>
<comune><nome>Salcedo</nome><codice>F810</codice></comune>
<comune><nome>Salcito</nome><codice>H693</codice></comune>
<comune><nome>Sale</nome><codice>H694</codice></comune>
<comune><nome>Sale delle Langhe</nome><codice>H695</codice></comune>
<comune><nome>Sale Marasino</nome><codice>H699</codice></comune>
<comune><nome>Sale San Giovanni</nome><codice>H704</codice></comune>
<comune><nome>Salemi</nome><codice>H700</codice></comune>
<comune><nome>Salento</nome><codice>H686</codice></comune>
<comune><nome>Salerano Canavese</nome><codice>H702</codice></comune>
<comune><nome>Salerano sul Lambro</nome><codice>H701</codice></comune>
<comune><nome>Salerno</nome><codice>H703</codice></comune>
<comune><nome>Saletto</nome><codice>H705</codice></comune>
<comune><nome>Salgareda</nome><codice>H706</codice></comune>
<comune><nome>Sali Vercellese</nome><codice>H707</codice></comune>
<comune><nome>Salice Salentino</nome><codice>H708</codice></comune>
<comune><nome>Saliceto</nome><codice>H710</codice></comune>
<comune><nome>Salisano</nome><codice>H713</codice></comune>
<comune><nome>Salizzole</nome><codice>H714</codice></comune>
<comune><nome>Salle</nome><codice>H715</codice></comune>
<comune><nome>Salmour</nome><codice>H716</codice></comune>
<comune><nome>Salò</nome><codice>H717</codice></comune>
<comune><nome>Salorno</nome><codice>H719</codice></comune>
<comune><nome>Salsomaggiore Terme</nome><codice>H720</codice></comune>
<comune><nome>Saltara</nome><codice>H721</codice></comune>
<comune><nome>Saltrio</nome><codice>H723</codice></comune>
<comune><nome>Saludecio</nome><codice>H724</codice></comune>
<comune><nome>Saluggia</nome><codice>H725</codice></comune>
<comune><nome>Salussola</nome><codice>H726</codice></comune>
<comune><nome>Saluzzo</nome><codice>H727</codice></comune>
<comune><nome>Salve</nome><codice>H729</codice></comune>
<comune><nome>Salvirola</nome><codice>H731</codice></comune>
<comune><nome>Salvitelle</nome><codice>H732</codice></comune>
<comune><nome>Salza di Pinerolo</nome><codice>H734</codice></comune>
<comune><nome>Salza Irpina</nome><codice>H733</codice></comune>
<comune><nome>Salzano</nome><codice>H735</codice></comune>
<comune><nome>Samarate</nome><codice>H736</codice></comune>
<comune><nome>Samassi</nome><codice>H738</codice></comune>
<comune><nome>Samatzai</nome><codice>H739</codice></comune>
<comune><nome>Sambuca di Sicilia</nome><codice>H743</codice></comune>
<comune><nome>Sambuca Pistoiese</nome><codice>H744</codice></comune>
<comune><nome>Sambuci</nome><codice>H745</codice></comune>
<comune><nome>Sambuco</nome><codice>H746</codice></comune>
<comune><nome>Sammichele di Bari</nome><codice>H749</codice></comune>
<comune><nome>Samo</nome><codice>H013</codice></comune>
<comune><nome>Samolaco</nome><codice>H752</codice></comune>
<comune><nome>Samone</nome><codice>H753</codice></comune>
<comune><nome>Samone</nome><codice>H754</codice></comune>
<comune><nome>Sampeyre</nome><codice>H755</codice></comune>
<comune><nome>Samugheo</nome><codice>H756</codice></comune>
<comune><nome>San Bartolomeo al Mare</nome><codice>H763</codice></comune>
<comune><nome>San Bartolomeo in Galdo</nome><codice>H764</codice></comune>
<comune><nome>San Bartolomeo Val Cavargna</nome><codice>H760</codice></comune>
<comune><nome>San Basile</nome><codice>H765</codice></comune>
<comune><nome>San Basilio</nome><codice>H766</codice></comune>
<comune><nome>San Bassano</nome><codice>H767</codice></comune>
<comune><nome>San Bellino</nome><codice>H768</codice></comune>
<comune><nome>San Benedetto Belbo</nome><codice>H770</codice></comune>
<comune><nome>San Benedetto dei Marsi</nome><codice>H772</codice></comune>
<comune><nome>San Benedetto del Tronto</nome><codice>H769</codice></comune>
<comune><nome>San Benedetto in Perillis</nome><codice>H773</codice></comune>
<comune><nome>San Benedetto Po</nome><codice>H771</codice></comune>
<comune><nome>San Benedetto Ullano</nome><codice>H774</codice></comune>
<comune><nome>San Benedetto Val di Sambro</nome><codice>G566</codice></comune>
<comune><nome>San Benigno Canavese</nome><codice>H775</codice></comune>
<comune><nome>San Bernardino Verbano</nome><codice>H777</codice></comune>
<comune><nome>San Biagio della Cima</nome><codice>H780</codice></comune>
<comune><nome>San Biagio di Callalta</nome><codice>H781</codice></comune>
<comune><nome>San Biagio Platani</nome><codice>H778</codice></comune>
<comune><nome>San Biagio Saracinisco</nome><codice>H779</codice></comune>
<comune><nome>San Biase</nome><codice>H782</codice></comune>
<comune><nome>San Bonifacio</nome><codice>H783</codice></comune>
<comune><nome>San Buono</nome><codice>H784</codice></comune>
<comune><nome>San Calogero</nome><codice>H785</codice></comune>
<comune><nome>San Candido</nome><codice>H786</codice></comune>
<comune><nome>San Canzian d'Isonzo</nome><codice>H787</codice></comune>
<comune><nome>San Carlo Canavese</nome><codice>H789</codice></comune>
<comune><nome>San Casciano dei Bagni</nome><codice>H790</codice></comune>
<comune><nome>San Casciano in Val di Pesa</nome><codice>H791</codice></comune>
<comune><nome>San Cassiano</nome><codice>M264</codice></comune>
<comune><nome>San Cataldo</nome><codice>H792</codice></comune>
<comune><nome>San Cesareo</nome><codice>M295</codice></comune>
<comune><nome>San Cesario di Lecce</nome><codice>H793</codice></comune>
<comune><nome>San Cesario sul Panaro</nome><codice>H794</codice></comune>
<comune><nome>San Chirico Nuovo</nome><codice>H795</codice></comune>
<comune><nome>San Chirico Raparo</nome><codice>H796</codice></comune>
<comune><nome>San Cipirello</nome><codice>H797</codice></comune>
<comune><nome>San Cipriano d'Aversa</nome><codice>H798</codice></comune>
<comune><nome>San Cipriano Picentino</nome><codice>H800</codice></comune>
<comune><nome>San Cipriano Po</nome><codice>H799</codice></comune>
<comune><nome>San Clemente</nome><codice>H801</codice></comune>
<comune><nome>San Colombano al Lambro</nome><codice>H803</codice></comune>
<comune><nome>San Colombano Belmonte</nome><codice>H804</codice></comune>
<comune><nome>San Colombano Certenoli</nome><codice>H802</codice></comune>
<comune><nome>San Cono</nome><codice>H805</codice></comune>
<comune><nome>San Cosmo Albanese</nome><codice>H806</codice></comune>
<comune><nome>San Costantino Albanese</nome><codice>H808</codice></comune>
<comune><nome>San Costantino Calabro</nome><codice>H807</codice></comune>
<comune><nome>San Costanzo</nome><codice>H809</codice></comune>
<comune><nome>San Cristoforo</nome><codice>H810</codice></comune>
<comune><nome>San Damiano al Colle</nome><codice>H814</codice></comune>
<comune><nome>San Damiano d'Asti</nome><codice>H811</codice></comune>
<comune><nome>San Damiano Macra</nome><codice>H812</codice></comune>
<comune><nome>San Daniele del Friuli</nome><codice>H816</codice></comune>
<comune><nome>San Daniele Po</nome><codice>H815</codice></comune>
<comune><nome>San Demetrio Corone</nome><codice>H818</codice></comune>
<comune><nome>San Demetrio ne' Vestini</nome><codice>H819</codice></comune>
<comune><nome>San Didero</nome><codice>H820</codice></comune>
<comune><nome>San Donà di Piave</nome><codice>H823</codice></comune>
<comune><nome>San Donaci</nome><codice>H822</codice></comune>
<comune><nome>San Donato di Lecce</nome><codice>H826</codice></comune>
<comune><nome>San Donato di Ninea</nome><codice>H825</codice></comune>
<comune><nome>San Donato Milanese</nome><codice>H827</codice></comune>
<comune><nome>San Donato Val di Comino</nome><codice>H824</codice></comune>
<comune><nome>San Dorligo della Valle - Dolina</nome><codice>D324</codice></comune>
<comune><nome>San Fedele Intelvi</nome><codice>H830</codice></comune>
<comune><nome>San Fele</nome><codice>H831</codice></comune>
<comune><nome>San Felice a Cancello</nome><codice>H834</codice></comune>
<comune><nome>San Felice Circeo</nome><codice>H836</codice></comune>
<comune><nome>San Felice del Benaco</nome><codice>H838</codice></comune>
<comune><nome>San Felice del Molise</nome><codice>H833</codice></comune>
<comune><nome>San Felice sul Panaro</nome><codice>H835</codice></comune>
<comune><nome>San Ferdinando</nome><codice>M277</codice></comune>
<comune><nome>San Ferdinando di Puglia</nome><codice>H839</codice></comune>
<comune><nome>San Fermo della Battaglia</nome><codice>H840</codice></comune>
<comune><nome>San Fili</nome><codice>H841</codice></comune>
<comune><nome>San Filippo del Mela</nome><codice>H842</codice></comune>
<comune><nome>San Fior</nome><codice>H843</codice></comune>
<comune><nome>San Fiorano</nome><codice>H844</codice></comune>
<comune><nome>San Floriano del Collio</nome><codice>H845</codice></comune>
<comune><nome>San Floro</nome><codice>H846</codice></comune>
<comune><nome>San Francesco al Campo</nome><codice>H847</codice></comune>
<comune><nome>San Fratello</nome><codice>H850</codice></comune>
<comune><nome>San Gavino Monreale</nome><codice>H856</codice></comune>
<comune><nome>San Gemini</nome><codice>H857</codice></comune>
<comune><nome>San Genesio Atesino</nome><codice>H858</codice></comune>
<comune><nome>San Genesio ed Uniti</nome><codice>H859</codice></comune>
<comune><nome>San Gennaro Vesuviano</nome><codice>H860</codice></comune>
<comune><nome>San Germano Chisone</nome><codice>H862</codice></comune>
<comune><nome>San Germano dei Berici</nome><codice>H863</codice></comune>
<comune><nome>San Germano Vercellese</nome><codice>H861</codice></comune>
<comune><nome>San Gervasio Bresciano</nome><codice>H865</codice></comune>
<comune><nome>San Giacomo degli Schiavoni</nome><codice>H867</codice></comune>
<comune><nome>San Giacomo delle Segnate</nome><codice>H870</codice></comune>
<comune><nome>San Giacomo Filippo</nome><codice>H868</codice></comune>
<comune><nome>San Giacomo Vercellese</nome><codice>B952</codice></comune>
<comune><nome>San Gillio</nome><codice>H873</codice></comune>
<comune><nome>San Gimignano</nome><codice>H875</codice></comune>
<comune><nome>San Ginesio</nome><codice>H876</codice></comune>
<comune><nome>San Giorgio a Cremano</nome><codice>H892</codice></comune>
<comune><nome>San Giorgio a Liri</nome><codice>H880</codice></comune>
<comune><nome>San Giorgio Albanese</nome><codice>H881</codice></comune>
<comune><nome>San Giorgio Canavese</nome><codice>H890</codice></comune>
<comune><nome>San Giorgio del Sannio</nome><codice>H894</codice></comune>
<comune><nome>San Giorgio della Richinvelda</nome><codice>H891</codice></comune>
<comune><nome>San Giorgio delle Pertiche</nome><codice>H893</codice></comune>
<comune><nome>San Giorgio di Lomellina</nome><codice>H885</codice></comune>
<comune><nome>San Giorgio di Mantova</nome><codice>H883</codice></comune>
<comune><nome>San Giorgio di Nogaro</nome><codice>H895</codice></comune>
<comune><nome>San Giorgio di Pesaro</nome><codice>H886</codice></comune>
<comune><nome>San Giorgio di Piano</nome><codice>H896</codice></comune>
<comune><nome>San Giorgio in Bosco</nome><codice>H897</codice></comune>
<comune><nome>San Giorgio Ionico</nome><codice>H882</codice></comune>
<comune><nome>San Giorgio La Molara</nome><codice>H898</codice></comune>
<comune><nome>San Giorgio Lucano</nome><codice>H888</codice></comune>
<comune><nome>San Giorgio Monferrato</nome><codice>H878</codice></comune>
<comune><nome>San Giorgio Morgeto</nome><codice>H889</codice></comune>
<comune><nome>San Giorgio Piacentino</nome><codice>H887</codice></comune>
<comune><nome>San Giorgio Scarampi</nome><codice>H899</codice></comune>
<comune><nome>San Giorgio su Legnano</nome><codice>H884</codice></comune>
<comune><nome>San Giorio di Susa</nome><codice>H900</codice></comune>
<comune><nome>San Giovanni a Piro</nome><codice>H907</codice></comune>
<comune><nome>San Giovanni al Natisone</nome><codice>H906</codice></comune>
<comune><nome>San Giovanni Bianco</nome><codice>H910</codice></comune>
<comune><nome>San Giovanni d'Asso</nome><codice>H911</codice></comune>
<comune><nome>San Giovanni del Dosso</nome><codice>H912</codice></comune>
<comune><nome>San Giovanni di Gerace</nome><codice>H903</codice></comune>
<comune><nome>San Giovanni Gemini</nome><codice>H914</codice></comune>
<comune><nome>San Giovanni Ilarione</nome><codice>H916</codice></comune>
<comune><nome>San Giovanni in Croce</nome><codice>H918</codice></comune>
<comune><nome>San Giovanni in Fiore</nome><codice>H919</codice></comune>
<comune><nome>San Giovanni in Galdo</nome><codice>H920</codice></comune>
<comune><nome>San Giovanni in Marignano</nome><codice>H921</codice></comune>
<comune><nome>San Giovanni in Persiceto</nome><codice>G467</codice></comune>
<comune><nome>San Giovanni Incarico</nome><codice>H917</codice></comune>
<comune><nome>San Giovanni la Punta</nome><codice>H922</codice></comune>
<comune><nome>San Giovanni Lipioni</nome><codice>H923</codice></comune>
<comune><nome>San Giovanni Lupatoto</nome><codice>H924</codice></comune>
<comune><nome>San Giovanni Rotondo</nome><codice>H926</codice></comune>
<comune><nome>San Giovanni Suergiu</nome><codice>G287</codice></comune>
<comune><nome>San Giovanni Teatino</nome><codice>D690</codice></comune>
<comune><nome>San Giovanni Valdarno</nome><codice>H901</codice></comune>
<comune><nome>San Giuliano del Sannio</nome><codice>H928</codice></comune>
<comune><nome>San Giuliano di Puglia</nome><codice>H929</codice></comune>
<comune><nome>San Giuliano Milanese</nome><codice>H930</codice></comune>
<comune><nome>San Giuliano Terme</nome><codice>A562</codice></comune>
<comune><nome>San Giuseppe Jato</nome><codice>H933</codice></comune>
<comune><nome>San Giuseppe Vesuviano</nome><codice>H931</codice></comune>
<comune><nome>San Giustino</nome><codice>H935</codice></comune>
<comune><nome>San Giusto Canavese</nome><codice>H936</codice></comune>
<comune><nome>San Godenzo</nome><codice>H937</codice></comune>
<comune><nome>San Gregorio da Sassola</nome><codice>H942</codice></comune>
<comune><nome>San Gregorio di Catania</nome><codice>H940</codice></comune>
<comune><nome>San Gregorio d'Ippona</nome><codice>H941</codice></comune>
<comune><nome>San Gregorio Magno</nome><codice>H943</codice></comune>
<comune><nome>San Gregorio Matese</nome><codice>H939</codice></comune>
<comune><nome>San Gregorio nelle Alpi</nome><codice>H938</codice></comune>
<comune><nome>San Lazzaro di Savena</nome><codice>H945</codice></comune>
<comune><nome>San Leo</nome><codice>H949</codice></comune>
<comune><nome>San Leonardo</nome><codice>H951</codice></comune>
<comune><nome>San Leonardo in Passiria</nome><codice>H952</codice></comune>
<comune><nome>San Leucio del Sannio</nome><codice>H953</codice></comune>
<comune><nome>San Lorenzello</nome><codice>H955</codice></comune>
<comune><nome>San Lorenzo</nome><codice>H959</codice></comune>
<comune><nome>San Lorenzo al Mare</nome><codice>H957</codice></comune>
<comune><nome>San Lorenzo Bellizzi</nome><codice>H961</codice></comune>
<comune><nome>San Lorenzo del Vallo</nome><codice>H962</codice></comune>
<comune><nome>San Lorenzo di Sebato</nome><codice>H956</codice></comune>
<comune><nome>San Lorenzo in Banale</nome><codice>H966</codice></comune>
<comune><nome>San Lorenzo in Campo</nome><codice>H958</codice></comune>
<comune><nome>San Lorenzo Isontino</nome><codice>H964</codice></comune>
<comune><nome>San Lorenzo Maggiore</nome><codice>H967</codice></comune>
<comune><nome>San Lorenzo Nuovo</nome><codice>H969</codice></comune>
<comune><nome>San Luca</nome><codice>H970</codice></comune>
<comune><nome>San Lucido</nome><codice>H971</codice></comune>
<comune><nome>San Lupo</nome><codice>H973</codice></comune>
<comune><nome>San Mango d'Aquino</nome><codice>H976</codice></comune>
<comune><nome>San Mango Piemonte</nome><codice>H977</codice></comune>
<comune><nome>San Mango sul Calore</nome><codice>H975</codice></comune>
<comune><nome>San Marcellino</nome><codice>H978</codice></comune>
<comune><nome>San Marcello</nome><codice>H979</codice></comune>
<comune><nome>San Marcello Pistoiese</nome><codice>H980</codice></comune>
<comune><nome>San Marco Argentano</nome><codice>H981</codice></comune>
<comune><nome>San Marco D'Alunzio</nome><codice>H982</codice></comune>
<comune><nome>San Marco dei Cavoti</nome><codice>H984</codice></comune>
<comune><nome>San Marco Evangelista</nome><codice>F043</codice></comune>
<comune><nome>San Marco in Lamis</nome><codice>H985</codice></comune>
<comune><nome>San Marco la Catola</nome><codice>H986</codice></comune>
<comune><nome>San Martino al Tagliamento</nome><codice>H999</codice></comune>
<comune><nome>San Martino Alfieri</nome><codice>H987</codice></comune>
<comune><nome>San Martino Buon Albergo</nome><codice>I003</codice></comune>
<comune><nome>San Martino Canavese</nome><codice>H997</codice></comune>
<comune><nome>San Martino d'Agri</nome><codice>H994</codice></comune>
<comune><nome>San Martino dall'Argine</nome><codice>I005</codice></comune>
<comune><nome>San Martino del Lago</nome><codice>I007</codice></comune>
<comune><nome>San Martino di Finita</nome><codice>H992</codice></comune>
<comune><nome>San Martino di Lupari</nome><codice>I008</codice></comune>
<comune><nome>San Martino di Venezze</nome><codice>H996</codice></comune>
<comune><nome>San Martino in Badia</nome><codice>H988</codice></comune>
<comune><nome>San Martino in Passiria</nome><codice>H989</codice></comune>
<comune><nome>San Martino in Pensilis</nome><codice>H990</codice></comune>
<comune><nome>San Martino in Rio</nome><codice>I011</codice></comune>
<comune><nome>San Martino in Strada</nome><codice>I012</codice></comune>
<comune><nome>San Martino Sannita</nome><codice>I002</codice></comune>
<comune><nome>San Martino Siccomario</nome><codice>I014</codice></comune>
<comune><nome>San Martino sulla Marrucina</nome><codice>H991</codice></comune>
<comune><nome>San Martino Valle Caudina</nome><codice>I016</codice></comune>
<comune><nome>San Marzano di San Giuseppe</nome><codice>I018</codice></comune>
<comune><nome>San Marzano Oliveto</nome><codice>I017</codice></comune>
<comune><nome>San Marzano sul Sarno</nome><codice>I019</codice></comune>
<comune><nome>San Massimo</nome><codice>I023</codice></comune>
<comune><nome>San Maurizio Canavese</nome><codice>I024</codice></comune>
<comune><nome>San Maurizio d'Opaglio</nome><codice>I025</codice></comune>
<comune><nome>San Mauro Castelverde</nome><codice>I028</codice></comune>
<comune><nome>San Mauro Cilento</nome><codice>I031</codice></comune>
<comune><nome>San Mauro di Saline</nome><codice>H712</codice></comune>
<comune><nome>San Mauro Forte</nome><codice>I029</codice></comune>
<comune><nome>San Mauro La Bruca</nome><codice>I032</codice></comune>
<comune><nome>San Mauro Marchesato</nome><codice>I026</codice></comune>
<comune><nome>San Mauro Pascoli</nome><codice>I027</codice></comune>
<comune><nome>San Mauro Torinese</nome><codice>I030</codice></comune>
<comune><nome>San Michele al Tagliamento</nome><codice>I040</codice></comune>
<comune><nome>San Michele all'Adige</nome><codice>I042</codice></comune>
<comune><nome>San Michele di Ganzaria</nome><codice>I035</codice></comune>
<comune><nome>San Michele di Serino</nome><codice>I034</codice></comune>
<comune><nome>San Michele Mondovì</nome><codice>I037</codice></comune>
<comune><nome>San Michele Salentino</nome><codice>I045</codice></comune>
<comune><nome>San Miniato</nome><codice>I046</codice></comune>
<comune><nome>San Nazario</nome><codice>I047</codice></comune>
<comune><nome>San Nazzaro</nome><codice>I049</codice></comune>
<comune><nome>San Nazzaro Sesia</nome><codice>I052</codice></comune>
<comune><nome>San Nazzaro Val Cavargna</nome><codice>I051</codice></comune>
<comune><nome>San Nicandro Garganico</nome><codice>I054</codice></comune>
<comune><nome>San Nicola Arcella</nome><codice>I060</codice></comune>
<comune><nome>San Nicola Baronia</nome><codice>I061</codice></comune>
<comune><nome>San Nicola da Crissa</nome><codice>I058</codice></comune>
<comune><nome>San Nicola dell'Alto</nome><codice>I057</codice></comune>
<comune><nome>San Nicola la Strada</nome><codice>I056</codice></comune>
<comune><nome>San Nicola Manfredi</nome><codice>I062</codice></comune>
<comune><nome>San Nicolò d'Arcidano</nome><codice>A368</codice></comune>
<comune><nome>San Nicolò di Comelico</nome><codice>I063</codice></comune>
<comune><nome>San Nicolò Gerrei</nome><codice>G383</codice></comune>
<comune><nome>San Pancrazio</nome><codice>I065</codice></comune>
<comune><nome>San Pancrazio Salentino</nome><codice>I066</codice></comune>
<comune><nome>San Paolo</nome><codice>G407</codice></comune>
<comune><nome>San Paolo Albanese</nome><codice>B906</codice></comune>
<comune><nome>San Paolo Bel Sito</nome><codice>I073</codice></comune>
<comune><nome>San Paolo Cervo</nome><codice>I074</codice></comune>
<comune><nome>San Paolo d'Argon</nome><codice>B310</codice></comune>
<comune><nome>San Paolo di Civitate</nome><codice>I072</codice></comune>
<comune><nome>San Paolo di Jesi</nome><codice>I071</codice></comune>
<comune><nome>San Paolo Solbrito</nome><codice>I076</codice></comune>
<comune><nome>San Pellegrino Terme</nome><codice>I079</codice></comune>
<comune><nome>San Pier d'Isonzo</nome><codice>I082</codice></comune>
<comune><nome>San Pier Niceto</nome><codice>I084</codice></comune>
<comune><nome>San Piero a Sieve</nome><codice>I085</codice></comune>
<comune><nome>San Piero Patti</nome><codice>I086</codice></comune>
<comune><nome>San Pietro a Maida</nome><codice>I093</codice></comune>
<comune><nome>San Pietro al Natisone</nome><codice>I092</codice></comune>
<comune><nome>San Pietro al Tanagro</nome><codice>I089</codice></comune>
<comune><nome>San Pietro Apostolo</nome><codice>I095</codice></comune>
<comune><nome>San Pietro Avellana</nome><codice>I096</codice></comune>
<comune><nome>San Pietro Clarenza</nome><codice>I098</codice></comune>
<comune><nome>San Pietro di Cadore</nome><codice>I088</codice></comune>
<comune><nome>San Pietro di Caridà</nome><codice>I102</codice></comune>
<comune><nome>San Pietro di Feletto</nome><codice>I103</codice></comune>
<comune><nome>San Pietro di Morubio</nome><codice>I105</codice></comune>
<comune><nome>San Pietro in Amantea</nome><codice>I108</codice></comune>
<comune><nome>San Pietro in Cariano</nome><codice>I109</codice></comune>
<comune><nome>San Pietro in Casale</nome><codice>I110</codice></comune>
<comune><nome>San Pietro in Cerro</nome><codice>G788</codice></comune>
<comune><nome>San Pietro in Gu</nome><codice>I107</codice></comune>
<comune><nome>San Pietro in Guarano</nome><codice>I114</codice></comune>
<comune><nome>San Pietro in Lama</nome><codice>I115</codice></comune>
<comune><nome>San Pietro Infine</nome><codice>I113</codice></comune>
<comune><nome>San Pietro Mosezzo</nome><codice>I116</codice></comune>
<comune><nome>San Pietro Mussolino</nome><codice>I117</codice></comune>
<comune><nome>San Pietro Val Lemina</nome><codice>I090</codice></comune>
<comune><nome>San Pietro Vernotico</nome><codice>I119</codice></comune>
<comune><nome>San Pietro Viminario</nome><codice>I120</codice></comune>
<comune><nome>San Pio delle Camere</nome><codice>I121</codice></comune>
<comune><nome>San Polo dei Cavalieri</nome><codice>I125</codice></comune>
<comune><nome>San Polo d'Enza</nome><codice>I123</codice></comune>
<comune><nome>San Polo di Piave</nome><codice>I124</codice></comune>
<comune><nome>San Polo Matese</nome><codice>I122</codice></comune>
<comune><nome>San Ponso</nome><codice>I126</codice></comune>
<comune><nome>San Possidonio</nome><codice>I128</codice></comune>
<comune><nome>San Potito Sannitico</nome><codice>I130</codice></comune>
<comune><nome>San Potito Ultra</nome><codice>I129</codice></comune>
<comune><nome>San Prisco</nome><codice>I131</codice></comune>
<comune><nome>San Procopio</nome><codice>I132</codice></comune>
<comune><nome>San Prospero</nome><codice>I133</codice></comune>
<comune><nome>San Quirico d'Orcia</nome><codice>I135</codice></comune>
<comune><nome>San Quirino</nome><codice>I136</codice></comune>
<comune><nome>San Raffaele Cimena</nome><codice>I137</codice></comune>
<comune><nome>San Roberto</nome><codice>I139</codice></comune>
<comune><nome>San Rocco al Porto</nome><codice>I140</codice></comune>
<comune><nome>San Romano in Garfagnana</nome><codice>I142</codice></comune>
<comune><nome>San Rufo</nome><codice>I143</codice></comune>
<comune><nome>San Salvatore di Fitalia</nome><codice>I147</codice></comune>
<comune><nome>San Salvatore Monferrato</nome><codice>I144</codice></comune>
<comune><nome>San Salvatore Telesino</nome><codice>I145</codice></comune>
<comune><nome>San Salvo</nome><codice>I148</codice></comune>
<comune><nome>San Sebastiano al Vesuvio</nome><codice>I151</codice></comune>
<comune><nome>San Sebastiano Curone</nome><codice>I150</codice></comune>
<comune><nome>San Sebastiano da Po</nome><codice>I152</codice></comune>
<comune><nome>San Secondo di Pinerolo</nome><codice>I154</codice></comune>
<comune><nome>San Secondo Parmense</nome><codice>I153</codice></comune>
<comune><nome>San Severino Lucano</nome><codice>I157</codice></comune>
<comune><nome>San Severino Marche</nome><codice>I156</codice></comune>
<comune><nome>San Severo</nome><codice>I158</codice></comune>
<comune><nome>San Siro</nome><codice>I162</codice></comune>
<comune><nome>San Sossio Baronia</nome><codice>I163</codice></comune>
<comune><nome>San Sostene</nome><codice>I164</codice></comune>
<comune><nome>San Sosti</nome><codice>I165</codice></comune>
<comune><nome>San Sperate</nome><codice>I166</codice></comune>
<comune><nome>San Tammaro</nome><codice>I261</codice></comune>
<comune><nome>San Teodoro</nome><codice>I328</codice></comune>
<comune><nome>San Teodoro</nome><codice>I329</codice></comune>
<comune><nome>San Tomaso Agordino</nome><codice>I347</codice></comune>
<comune><nome>San Valentino in Abruzzo Citeriore</nome><codice>I376</codice></comune>
<comune><nome>San Valentino Torio</nome><codice>I377</codice></comune>
<comune><nome>San Venanzo</nome><codice>I381</codice></comune>
<comune><nome>San Vendemiano</nome><codice>I382</codice></comune>
<comune><nome>San Vero Milis</nome><codice>I384</codice></comune>
<comune><nome>San Vincenzo</nome><codice>I390</codice></comune>
<comune><nome>San Vincenzo la Costa</nome><codice>I388</codice></comune>
<comune><nome>San Vincenzo Valle Roveto</nome><codice>I389</codice></comune>
<comune><nome>San Vitaliano</nome><codice>I391</codice></comune>
<comune><nome>San Vito</nome><codice>I402</codice></comune>
<comune><nome>San Vito al Tagliamento</nome><codice>I403</codice></comune>
<comune><nome>San Vito al Torre</nome><codice>I404</codice></comune>
<comune><nome>San Vito Chietino</nome><codice>I394</codice></comune>
<comune><nome>San Vito dei Normanni</nome><codice>I396</codice></comune>
<comune><nome>San Vito di Cadore</nome><codice>I392</codice></comune>
<comune><nome>San Vito di Fagagna</nome><codice>I405</codice></comune>
<comune><nome>San Vito di Leguzzano</nome><codice>I401</codice></comune>
<comune><nome>San Vito Lo Capo</nome><codice>I407</codice></comune>
<comune><nome>San Vito Romano</nome><codice>I400</codice></comune>
<comune><nome>San Vito sullo Ionio</nome><codice>I393</codice></comune>
<comune><nome>San Vittore del Lazio</nome><codice>I408</codice></comune>
<comune><nome>San Vittore Olona</nome><codice>I409</codice></comune>
<comune><nome>San Zeno di Montagna</nome><codice>I414</codice></comune>
<comune><nome>San Zeno Naviglio</nome><codice>I412</codice></comune>
<comune><nome>San Zenone al Lambro</nome><codice>I415</codice></comune>
<comune><nome>San Zenone al Po</nome><codice>I416</codice></comune>
<comune><nome>San Zenone degli Ezzelini</nome><codice>I417</codice></comune>
<comune><nome>Sanarica</nome><codice>H757</codice></comune>
<comune><nome>Sandigliano</nome><codice>H821</codice></comune>
<comune><nome>Sandrigo</nome><codice>H829</codice></comune>
<comune><nome>Sanfrè</nome><codice>H851</codice></comune>
<comune><nome>Sanfront</nome><codice>H852</codice></comune>
<comune><nome>Sangano</nome><codice>H855</codice></comune>
<comune><nome>Sangiano</nome><codice>H872</codice></comune>
<comune><nome>Sangineto</nome><codice>H877</codice></comune>
<comune><nome>Sanguinetto</nome><codice>H944</codice></comune>
<comune><nome>Sanluri</nome><codice>H974</codice></comune>
<comune><nome>Sannazzaro de' Burgondi</nome><codice>I048</codice></comune>
<comune><nome>Sannicandro di Bari</nome><codice>I053</codice></comune>
<comune><nome>Sannicola</nome><codice>I059</codice></comune>
<comune><nome>Sanremo</nome><codice>I138</codice></comune>
<comune><nome>Sansepolcro</nome><codice>I155</codice></comune>
<comune><nome>Santa Brigida</nome><codice>I168</codice></comune>
<comune><nome>Santa Caterina Albanese</nome><codice>I171</codice></comune>
<comune><nome>Santa Caterina dello Ionio</nome><codice>I170</codice></comune>
<comune><nome>Santa Caterina Villarmosa</nome><codice>I169</codice></comune>
<comune><nome>Santa Cesarea Terme</nome><codice>I172</codice></comune>
<comune><nome>Santa Cristina d'Aspromonte</nome><codice>I176</codice></comune>
<comune><nome>Santa Cristina e Bissone</nome><codice>I175</codice></comune>
<comune><nome>Santa Cristina Gela</nome><codice>I174</codice></comune>
<comune><nome>Santa Cristina Valgardena</nome><codice>I173</codice></comune>
<comune><nome>Santa Croce Camerina</nome><codice>I178</codice></comune>
<comune><nome>Santa Croce del Sannio</nome><codice>I179</codice></comune>
<comune><nome>Santa Croce di Magliano</nome><codice>I181</codice></comune>
<comune><nome>Santa Croce sull'Arno</nome><codice>I177</codice></comune>
<comune><nome>Santa Domenica Talao</nome><codice>I183</codice></comune>
<comune><nome>Santa Domenica Vittoria</nome><codice>I184</codice></comune>
<comune><nome>Santa Elisabetta</nome><codice>I185</codice></comune>
<comune><nome>Santa Fiora</nome><codice>I187</codice></comune>
<comune><nome>Santa Flavia</nome><codice>I188</codice></comune>
<comune><nome>Santa Giuletta</nome><codice>I203</codice></comune>
<comune><nome>Santa Giusta</nome><codice>I205</codice></comune>
<comune><nome>Santa Giustina</nome><codice>I206</codice></comune>
<comune><nome>Santa Giustina in Colle</nome><codice>I207</codice></comune>
<comune><nome>Santa Luce</nome><codice>I217</codice></comune>
<comune><nome>Santa Lucia del Mela</nome><codice>I220</codice></comune>
<comune><nome>Santa Lucia di Piave</nome><codice>I221</codice></comune>
<comune><nome>Santa Lucia di Serino</nome><codice>I219</codice></comune>
<comune><nome>Santa Margherita d'Adige</nome><codice>I226</codice></comune>
<comune><nome>Santa Margherita di Belice</nome><codice>I224</codice></comune>
<comune><nome>Santa Margherita di Staffora</nome><codice>I230</codice></comune>
<comune><nome>Santa Margherita Ligure</nome><codice>I225</codice></comune>
<comune><nome>Santa Maria a Monte</nome><codice>I232</codice></comune>
<comune><nome>Santa Maria a Vico</nome><codice>I233</codice></comune>
<comune><nome>Santa Maria Capua Vetere</nome><codice>I234</codice></comune>
<comune><nome>Santa Maria Coghinas</nome><codice>M284</codice></comune>
<comune><nome>Santa Maria del Cedro</nome><codice>C717</codice></comune>
<comune><nome>Santa Maria del Molise</nome><codice>I238</codice></comune>
<comune><nome>Santa Maria della Versa</nome><codice>I237</codice></comune>
<comune><nome>Santa Maria di Licodia</nome><codice>I240</codice></comune>
<comune><nome>Santa Maria di Sala</nome><codice>I242</codice></comune>
<comune><nome>Santa Maria Hoè</nome><codice>I243</codice></comune>
<comune><nome>Santa Maria Imbaro</nome><codice>I244</codice></comune>
<comune><nome>Santa Maria la Carità</nome><codice>M273</codice></comune>
<comune><nome>Santa Maria La Fossa</nome><codice>I247</codice></comune>
<comune><nome>Santa Maria La Longa</nome><codice>I248</codice></comune>
<comune><nome>Santa Maria Maggiore</nome><codice>I249</codice></comune>
<comune><nome>Santa Maria Nuova</nome><codice>I251</codice></comune>
<comune><nome>Santa Marina</nome><codice>I253</codice></comune>
<comune><nome>Santa Marina Salina</nome><codice>I254</codice></comune>
<comune><nome>Santa Marinella</nome><codice>I255</codice></comune>
<comune><nome>Santa Ninfa</nome><codice>I291</codice></comune>
<comune><nome>Santa Paolina</nome><codice>I301</codice></comune>
<comune><nome>Santa Severina</nome><codice>I308</codice></comune>
<comune><nome>Santa Sofia</nome><codice>I310</codice></comune>
<comune><nome>Santa Sofia D'Epiro</nome><codice>I309</codice></comune>
<comune><nome>Santa Teresa di Riva</nome><codice>I311</codice></comune>
<comune><nome>Santa Teresa Gallura</nome><codice>I312</codice></comune>
<comune><nome>Santa Venerina</nome><codice>I314</codice></comune>
<comune><nome>Santa Vittoria d'Alba</nome><codice>I316</codice></comune>
<comune><nome>Santa Vittoria in Matenano</nome><codice>I315</codice></comune>
<comune><nome>Santadi</nome><codice>I182</codice></comune>
<comune><nome>Sant'Agapito</nome><codice>I189</codice></comune>
<comune><nome>Sant'Agata Bolognese</nome><codice>I191</codice></comune>
<comune><nome>Sant'Agata De' Goti</nome><codice>I197</codice></comune>
<comune><nome>Sant'Agata del Bianco</nome><codice>I198</codice></comune>
<comune><nome>Sant'Agata di Esaro</nome><codice>I192</codice></comune>
<comune><nome>Sant'Agata di Militello</nome><codice>I199</codice></comune>
<comune><nome>Sant'Agata di Puglia</nome><codice>I193</codice></comune>
<comune><nome>Sant'Agata Feltria</nome><codice>I201</codice></comune>
<comune><nome>Sant'Agata Fossili</nome><codice>I190</codice></comune>
<comune><nome>Sant'Agata Li Battiati</nome><codice>I202</codice></comune>
<comune><nome>Sant'Agata sul Santerno</nome><codice>I196</codice></comune>
<comune><nome>Sant'Agnello</nome><codice>I208</codice></comune>
<comune><nome>Sant'Agostino</nome><codice>I209</codice></comune>
<comune><nome>Sant'Albano Stura</nome><codice>I210</codice></comune>
<comune><nome>Sant'Alessio con Vialone</nome><codice>I213</codice></comune>
<comune><nome>Sant'Alessio in Aspromonte</nome><codice>I214</codice></comune>
<comune><nome>Sant'Alessio Siculo</nome><codice>I215</codice></comune>
<comune><nome>Sant'Alfio</nome><codice>I216</codice></comune>
<comune><nome>Sant'Ambrogio di Torino</nome><codice>I258</codice></comune>
<comune><nome>Sant'Ambrogio di Valpolicella</nome><codice>I259</codice></comune>
<comune><nome>Sant'Ambrogio sul Garigliano</nome><codice>I256</codice></comune>
<comune><nome>Sant'Anastasia</nome><codice>I262</codice></comune>
<comune><nome>Sant'Anatolia di Narco</nome><codice>I263</codice></comune>
<comune><nome>Sant'Andrea Apostolo dello Ionio</nome><codice>I266</codice></comune>
<comune><nome>Sant'Andrea del Garigliano</nome><codice>I265</codice></comune>
<comune><nome>Sant'Andrea di Conza</nome><codice>I264</codice></comune>
<comune><nome>Sant'Andrea Frius</nome><codice>I271</codice></comune>
<comune><nome>Sant'Angelo a Cupolo</nome><codice>I277</codice></comune>
<comune><nome>Sant'Angelo a Fasanella</nome><codice>I278</codice></comune>
<comune><nome>Sant'Angelo a Scala</nome><codice>I280</codice></comune>
<comune><nome>Sant'Angelo all'Esca</nome><codice>I279</codice></comune>
<comune><nome>Sant'Angelo d'Alife</nome><codice>I273</codice></comune>
<comune><nome>Sant'Angelo dei Lombardi</nome><codice>I281</codice></comune>
<comune><nome>Sant'Angelo del Pesco</nome><codice>I282</codice></comune>
<comune><nome>Sant'Angelo di Brolo</nome><codice>I283</codice></comune>
<comune><nome>Sant'Angelo di Piove di Sacco</nome><codice>I275</codice></comune>
<comune><nome>Sant'Angelo in Lizzola</nome><codice>I285</codice></comune>
<comune><nome>Sant'Angelo in Pontano</nome><codice>I286</codice></comune>
<comune><nome>Sant'Angelo in Vado</nome><codice>I287</codice></comune>
<comune><nome>Sant'Angelo Le Fratte</nome><codice>I288</codice></comune>
<comune><nome>Sant'Angelo Limosano</nome><codice>I289</codice></comune>
<comune><nome>Sant'Angelo Lodigiano</nome><codice>I274</codice></comune>
<comune><nome>Sant'Angelo Lomellina</nome><codice>I276</codice></comune>
<comune><nome>Sant'Angelo Muxaro</nome><codice>I290</codice></comune>
<comune><nome>Sant'Angelo Romano</nome><codice>I284</codice></comune>
<comune><nome>Sant'Anna Arresi</nome><codice>M209</codice></comune>
<comune><nome>Sant'Anna d'Alfaedo</nome><codice>I292</codice></comune>
<comune><nome>Sant'Antimo</nome><codice>I293</codice></comune>
<comune><nome>Sant'Antioco</nome><codice>I294</codice></comune>
<comune><nome>Sant'Antonino di Susa</nome><codice>I296</codice></comune>
<comune><nome>Sant'Antonio Abate</nome><codice>I300</codice></comune>
<comune><nome>Sant'Antonio di Gallura</nome><codice>M276</codice></comune>
<comune><nome>Sant'Apollinare</nome><codice>I302</codice></comune>
<comune><nome>Sant'Arcangelo</nome><codice>I305</codice></comune>
<comune><nome>Santarcangelo di Romagna</nome><codice>I304</codice></comune>
<comune><nome>Sant'Arcangelo Trimonte</nome><codice>F557</codice></comune>
<comune><nome>Sant'Arpino</nome><codice>I306</codice></comune>
<comune><nome>Sant'Arsenio</nome><codice>I307</codice></comune>
<comune><nome>Sante Marie</nome><codice>I326</codice></comune>
<comune><nome>Sant'Egidio alla Vibrata</nome><codice>I318</codice></comune>
<comune><nome>Sant'Egidio del Monte Albino</nome><codice>I317</codice></comune>
<comune><nome>Sant'Elena</nome><codice>I319</codice></comune>
<comune><nome>Sant'Elena Sannita</nome><codice>B466</codice></comune>
<comune><nome>Sant'Elia a Pianisi</nome><codice>I320</codice></comune>
<comune><nome>Sant'Elia Fiumerapido</nome><codice>I321</codice></comune>
<comune><nome>Sant'Elpidio a Mare</nome><codice>I324</codice></comune>
<comune><nome>Santena</nome><codice>I327</codice></comune>
<comune><nome>Santeramo in Colle</nome><codice>I330</codice></comune>
<comune><nome>Sant'Eufemia a Maiella</nome><codice>I332</codice></comune>
<comune><nome>Sant'Eufemia d'Aspromonte</nome><codice>I333</codice></comune>
<comune><nome>Sant'Eusanio del Sangro</nome><codice>I335</codice></comune>
<comune><nome>Sant'Eusanio Forconese</nome><codice>I336</codice></comune>
<comune><nome>Santhià</nome><codice>I337</codice></comune>
<comune><nome>Santi Cosma e Damiano</nome><codice>I339</codice></comune>
<comune><nome>Sant'Ilario dello Ionio</nome><codice>I341</codice></comune>
<comune><nome>Sant'Ilario d'Enza</nome><codice>I342</codice></comune>
<comune><nome>Sant'Ippolito</nome><codice>I344</codice></comune>
<comune><nome>Santo Stefano al Mare</nome><codice>I365</codice></comune>
<comune><nome>Santo Stefano Belbo</nome><codice>I367</codice></comune>
<comune><nome>Santo Stefano d'Aveto</nome><codice>I368</codice></comune>
<comune><nome>Santo Stefano del Sole</nome><codice>I357</codice></comune>
<comune><nome>Santo Stefano di Cadore</nome><codice>C919</codice></comune>
<comune><nome>Santo Stefano di Camastra</nome><codice>I370</codice></comune>
<comune><nome>Santo Stefano di Magra</nome><codice>I363</codice></comune>
<comune><nome>Santo Stefano di Rogliano</nome><codice>I359</codice></comune>
<comune><nome>Santo Stefano di Sessanio</nome><codice>I360</codice></comune>
<comune><nome>Santo Stefano in Aspromonte</nome><codice>I371</codice></comune>
<comune><nome>Santo Stefano Lodigiano</nome><codice>I362</codice></comune>
<comune><nome>Santo Stefano Quisquina</nome><codice>I356</codice></comune>
<comune><nome>Santo Stefano Roero</nome><codice>I372</codice></comune>
<comune><nome>Santo Stefano Ticino</nome><codice>I361</codice></comune>
<comune><nome>Santo Stino di Livenza</nome><codice>I373</codice></comune>
<comune><nome>Sant'Olcese</nome><codice>I346</codice></comune>
<comune><nome>Santomenna</nome><codice>I260</codice></comune>
<comune><nome>Sant'Omero</nome><codice>I348</codice></comune>
<comune><nome>Sant'Omobono Terme</nome><codice>I349</codice></comune>
<comune><nome>Sant'Onofrio</nome><codice>I350</codice></comune>
<comune><nome>Santopadre</nome><codice>I351</codice></comune>
<comune><nome>Sant'Oreste</nome><codice>I352</codice></comune>
<comune><nome>Santorso</nome><codice>I353</codice></comune>
<comune><nome>Sant'Orsola Terme</nome><codice>I354</codice></comune>
<comune><nome>Santu Lussurgiu</nome><codice>I374</codice></comune>
<comune><nome>Sant'Urbano</nome><codice>I375</codice></comune>
<comune><nome>Sanza</nome><codice>I410</codice></comune>
<comune><nome>Sanzeno</nome><codice>I411</codice></comune>
<comune><nome>Saonara</nome><codice>I418</codice></comune>
<comune><nome>Saponara</nome><codice>I420</codice></comune>
<comune><nome>Sappada</nome><codice>I421</codice></comune>
<comune><nome>Sapri</nome><codice>I422</codice></comune>
<comune><nome>Saracena</nome><codice>I423</codice></comune>
<comune><nome>Saracinesco</nome><codice>I424</codice></comune>
<comune><nome>Sarcedo</nome><codice>I425</codice></comune>
<comune><nome>Sarconi</nome><codice>I426</codice></comune>
<comune><nome>Sardara</nome><codice>I428</codice></comune>
<comune><nome>Sardigliano</nome><codice>I429</codice></comune>
<comune><nome>Sarego</nome><codice>I430</codice></comune>
<comune><nome>Sarentino</nome><codice>I431</codice></comune>
<comune><nome>Sarezzano</nome><codice>I432</codice></comune>
<comune><nome>Sarezzo</nome><codice>I433</codice></comune>
<comune><nome>Sarmato</nome><codice>I434</codice></comune>
<comune><nome>Sarmede</nome><codice>I435</codice></comune>
<comune><nome>Sarnano</nome><codice>I436</codice></comune>
<comune><nome>Sarnico</nome><codice>I437</codice></comune>
<comune><nome>Sarno</nome><codice>I438</codice></comune>
<comune><nome>Sarnonico</nome><codice>I439</codice></comune>
<comune><nome>Saronno</nome><codice>I441</codice></comune>
<comune><nome>Sarre</nome><codice>I442</codice></comune>
<comune><nome>Sarroch</nome><codice>I443</codice></comune>
<comune><nome>Sarsina</nome><codice>I444</codice></comune>
<comune><nome>Sarteano</nome><codice>I445</codice></comune>
<comune><nome>Sartirana Lomellina</nome><codice>I447</codice></comune>
<comune><nome>Sarule</nome><codice>I448</codice></comune>
<comune><nome>Sarzana</nome><codice>I449</codice></comune>
<comune><nome>Sassano</nome><codice>I451</codice></comune>
<comune><nome>Sassari</nome><codice>I452</codice></comune>
<comune><nome>Sassello</nome><codice>I453</codice></comune>
<comune><nome>Sassetta</nome><codice>I454</codice></comune>
<comune><nome>Sassinoro</nome><codice>I455</codice></comune>
<comune><nome>Sasso di Castalda</nome><codice>I457</codice></comune>
<comune><nome>Sasso Marconi</nome><codice>G972</codice></comune>
<comune><nome>Sassocorvaro</nome><codice>I459</codice></comune>
<comune><nome>Sassofeltrio</nome><codice>I460</codice></comune>
<comune><nome>Sassoferrato</nome><codice>I461</codice></comune>
<comune><nome>Sassuolo</nome><codice>I462</codice></comune>
<comune><nome>Satriano</nome><codice>I463</codice></comune>
<comune><nome>Satriano di Lucania</nome><codice>G614</codice></comune>
<comune><nome>Sauris</nome><codice>I464</codice></comune>
<comune><nome>Sauze di Cesana</nome><codice>I465</codice></comune>
<comune><nome>Sauze d'Oulx</nome><codice>I466</codice></comune>
<comune><nome>Sava</nome><codice>I467</codice></comune>
<comune><nome>Savelli</nome><codice>I468</codice></comune>
<comune><nome>Saviano</nome><codice>I469</codice></comune>
<comune><nome>Savigliano</nome><codice>I470</codice></comune>
<comune><nome>Savignano Irpino</nome><codice>I471</codice></comune>
<comune><nome>Savignano sul Panaro</nome><codice>I473</codice></comune>
<comune><nome>Savignano sul Rubicone</nome><codice>I472</codice></comune>
<comune><nome>Savigno</nome><codice>I474</codice></comune>
<comune><nome>Savignone</nome><codice>I475</codice></comune>
<comune><nome>Saviore dell'Adamello</nome><codice>I476</codice></comune>
<comune><nome>Savoca</nome><codice>I477</codice></comune>
<comune><nome>Savogna</nome><codice>I478</codice></comune>
<comune><nome>Savogna d'Isonzo</nome><codice>I479</codice></comune>
<comune><nome>Savoia di Lucania</nome><codice>H730</codice></comune>
<comune><nome>Savona</nome><codice>I480</codice></comune>
<comune><nome>Scafa</nome><codice>I482</codice></comune>
<comune><nome>Scafati</nome><codice>I483</codice></comune>
<comune><nome>Scagnello</nome><codice>I484</codice></comune>
<comune><nome>Scala</nome><codice>I486</codice></comune>
<comune><nome>Scala Coeli</nome><codice>I485</codice></comune>
<comune><nome>Scaldasole</nome><codice>I487</codice></comune>
<comune><nome>Scalea</nome><codice>I489</codice></comune>
<comune><nome>Scalenghe</nome><codice>I490</codice></comune>
<comune><nome>Scaletta Zanclea</nome><codice>I492</codice></comune>
<comune><nome>Scampitella</nome><codice>I493</codice></comune>
<comune><nome>Scandale</nome><codice>I494</codice></comune>
<comune><nome>Scandiano</nome><codice>I496</codice></comune>
<comune><nome>Scandicci</nome><codice>B962</codice></comune>
<comune><nome>Scandolara Ravara</nome><codice>I497</codice></comune>
<comune><nome>Scandolara Ripa d'Oglio</nome><codice>I498</codice></comune>
<comune><nome>Scandriglia</nome><codice>I499</codice></comune>
<comune><nome>Scanno</nome><codice>I501</codice></comune>
<comune><nome>Scano di Montiferro</nome><codice>I503</codice></comune>
<comune><nome>Scansano</nome><codice>I504</codice></comune>
<comune><nome>Scanzano Jonico</nome><codice>M256</codice></comune>
<comune><nome>Scanzorosciate</nome><codice>I506</codice></comune>
<comune><nome>Scapoli</nome><codice>I507</codice></comune>
<comune><nome>Scarlino</nome><codice>I510</codice></comune>
<comune><nome>Scarmagno</nome><codice>I511</codice></comune>
<comune><nome>Scarnafigi</nome><codice>I512</codice></comune>
<comune><nome>Scarperia</nome><codice>I514</codice></comune>
<comune><nome>Scena</nome><codice>I519</codice></comune>
<comune><nome>Scerni</nome><codice>I520</codice></comune>
<comune><nome>Scheggia e Pascelupo</nome><codice>I522</codice></comune>
<comune><nome>Scheggino</nome><codice>I523</codice></comune>
<comune><nome>Schiavi di Abruzzo</nome><codice>I526</codice></comune>
<comune><nome>Schiavon</nome><codice>I527</codice></comune>
<comune><nome>Schignano</nome><codice>I529</codice></comune>
<comune><nome>Schilpario</nome><codice>I530</codice></comune>
<comune><nome>Schio</nome><codice>I531</codice></comune>
<comune><nome>Schivenoglia</nome><codice>I532</codice></comune>
<comune><nome>Sciacca</nome><codice>I533</codice></comune>
<comune><nome>Sciara</nome><codice>I534</codice></comune>
<comune><nome>Scicli</nome><codice>I535</codice></comune>
<comune><nome>Scido</nome><codice>I536</codice></comune>
<comune><nome>Scigliano</nome><codice>D290</codice></comune>
<comune><nome>Scilla</nome><codice>I537</codice></comune>
<comune><nome>Scillato</nome><codice>I538</codice></comune>
<comune><nome>Sciolze</nome><codice>I539</codice></comune>
<comune><nome>Scisciano</nome><codice>I540</codice></comune>
<comune><nome>Sclafani Bagni</nome><codice>I541</codice></comune>
<comune><nome>Scontrone</nome><codice>I543</codice></comune>
<comune><nome>Scopa</nome><codice>I544</codice></comune>
<comune><nome>Scopello</nome><codice>I545</codice></comune>
<comune><nome>Scoppito</nome><codice>I546</codice></comune>
<comune><nome>Scordia</nome><codice>I548</codice></comune>
<comune><nome>Scorrano</nome><codice>I549</codice></comune>
<comune><nome>Scorzè</nome><codice>I551</codice></comune>
<comune><nome>Scurcola Marsicana</nome><codice>I553</codice></comune>
<comune><nome>Scurelle</nome><codice>I554</codice></comune>
<comune><nome>Scurzolengo</nome><codice>I555</codice></comune>
<comune><nome>Seborga</nome><codice>I556</codice></comune>
<comune><nome>Secinaro</nome><codice>I558</codice></comune>
<comune><nome>Seclì</nome><codice>I559</codice></comune>
<comune><nome>Secugnago</nome><codice>I561</codice></comune>
<comune><nome>Sedegliano</nome><codice>I562</codice></comune>
<comune><nome>Sedico</nome><codice>I563</codice></comune>
<comune><nome>Sedilo</nome><codice>I564</codice></comune>
<comune><nome>Sedini</nome><codice>I565</codice></comune>
<comune><nome>Sedriano</nome><codice>I566</codice></comune>
<comune><nome>Sedrina</nome><codice>I567</codice></comune>
<comune><nome>Sefro</nome><codice>I569</codice></comune>
<comune><nome>Segariu</nome><codice>I570</codice></comune>
<comune><nome>Seggiano</nome><codice>I571</codice></comune>
<comune><nome>Segni</nome><codice>I573</codice></comune>
<comune><nome>Segonzano</nome><codice>I576</codice></comune>
<comune><nome>Segrate</nome><codice>I577</codice></comune>
<comune><nome>Segusino</nome><codice>I578</codice></comune>
<comune><nome>Selargius</nome><codice>I580</codice></comune>
<comune><nome>Selci</nome><codice>I581</codice></comune>
<comune><nome>Selegas</nome><codice>I582</codice></comune>
<comune><nome>Sellano</nome><codice>I585</codice></comune>
<comune><nome>Sellero</nome><codice>I588</codice></comune>
<comune><nome>Sellia</nome><codice>I589</codice></comune>
<comune><nome>Sellia Marina</nome><codice>I590</codice></comune>
<comune><nome>Selva dei Molini</nome><codice>I593</codice></comune>
<comune><nome>Selva di Cadore</nome><codice>I592</codice></comune>
<comune><nome>Selva di Progno</nome><codice>I594</codice></comune>
<comune><nome>Selva di Val Gardena</nome><codice>I591</codice></comune>
<comune><nome>Selvazzano Dentro</nome><codice>I595</codice></comune>
<comune><nome>Selve Marcone</nome><codice>I596</codice></comune>
<comune><nome>Selvino</nome><codice>I597</codice></comune>
<comune><nome>Semestene</nome><codice>I598</codice></comune>
<comune><nome>Semiana</nome><codice>I599</codice></comune>
<comune><nome>Seminara</nome><codice>I600</codice></comune>
<comune><nome>Semproniano</nome><codice>I601</codice></comune>
<comune><nome>Senago</nome><codice>I602</codice></comune>
<comune><nome>Senales</nome><codice>I604</codice></comune>
<comune><nome>Senale-San Felice</nome><codice>I603</codice></comune>
<comune><nome>Seneghe</nome><codice>I605</codice></comune>
<comune><nome>Senerchia</nome><codice>I606</codice></comune>
<comune><nome>Seniga</nome><codice>I607</codice></comune>
<comune><nome>Senigallia</nome><codice>I608</codice></comune>
<comune><nome>Senis</nome><codice>I609</codice></comune>
<comune><nome>Senise</nome><codice>I610</codice></comune>
<comune><nome>Senna Comasco</nome><codice>I611</codice></comune>
<comune><nome>Senna Lodigiana</nome><codice>I612</codice></comune>
<comune><nome>Sennariolo</nome><codice>I613</codice></comune>
<comune><nome>Sennori</nome><codice>I614</codice></comune>
<comune><nome>Senorbì</nome><codice>I615</codice></comune>
<comune><nome>Sepino</nome><codice>I618</codice></comune>
<comune><nome>Seppiana</nome><codice>I619</codice></comune>
<comune><nome>Sequals</nome><codice>I621</codice></comune>
<comune><nome>Seravezza</nome><codice>I622</codice></comune>
<comune><nome>Serdiana</nome><codice>I624</codice></comune>
<comune><nome>Seregno</nome><codice>I625</codice></comune>
<comune><nome>Seren del Grappa</nome><codice>I626</codice></comune>
<comune><nome>Sergnano</nome><codice>I627</codice></comune>
<comune><nome>Seriate</nome><codice>I628</codice></comune>
<comune><nome>Serina</nome><codice>I629</codice></comune>
<comune><nome>Serino</nome><codice>I630</codice></comune>
<comune><nome>Serle</nome><codice>I631</codice></comune>
<comune><nome>Sermide</nome><codice>I632</codice></comune>
<comune><nome>Sermoneta</nome><codice>I634</codice></comune>
<comune><nome>Sernaglia della Battaglia</nome><codice>I635</codice></comune>
<comune><nome>Sernio</nome><codice>I636</codice></comune>
<comune><nome>Serole</nome><codice>I637</codice></comune>
<comune><nome>Serra d'Aiello</nome><codice>I642</codice></comune>
<comune><nome>Serra de' Conti</nome><codice>I643</codice></comune>
<comune><nome>Serra Pedace</nome><codice>I650</codice></comune>
<comune><nome>Serra Riccò</nome><codice>I640</codice></comune>
<comune><nome>Serra San Bruno</nome><codice>I639</codice></comune>
<comune><nome>Serra San Quirico</nome><codice>I653</codice></comune>
<comune><nome>Serra Sant'Abbondio</nome><codice>I654</codice></comune>
<comune><nome>Serracapriola</nome><codice>I641</codice></comune>
<comune><nome>Serradifalco</nome><codice>I644</codice></comune>
<comune><nome>Serralunga d'Alba</nome><codice>I646</codice></comune>
<comune><nome>Serralunga di Crea</nome><codice>I645</codice></comune>
<comune><nome>Serramanna</nome><codice>I647</codice></comune>
<comune><nome>Serramazzoni</nome><codice>F357</codice></comune>
<comune><nome>Serramezzana</nome><codice>I648</codice></comune>
<comune><nome>Serramonacesca</nome><codice>I649</codice></comune>
<comune><nome>Serrapetrona</nome><codice>I651</codice></comune>
<comune><nome>Serrara Fontana</nome><codice>I652</codice></comune>
<comune><nome>Serrastretta</nome><codice>I655</codice></comune>
<comune><nome>Serrata</nome><codice>I656</codice></comune>
<comune><nome>Serravalle a Po</nome><codice>I662</codice></comune>
<comune><nome>Serravalle di Chienti</nome><codice>I661</codice></comune>
<comune><nome>Serravalle Langhe</nome><codice>I659</codice></comune>
<comune><nome>Serravalle Pistoiese</nome><codice>I660</codice></comune>
<comune><nome>Serravalle Scrivia</nome><codice>I657</codice></comune>
<comune><nome>Serravalle Sesia</nome><codice>I663</codice></comune>
<comune><nome>Serre</nome><codice>I666</codice></comune>
<comune><nome>Serrenti</nome><codice>I667</codice></comune>
<comune><nome>Serri</nome><codice>I668</codice></comune>
<comune><nome>Serrone</nome><codice>I669</codice></comune>
<comune><nome>Serrungarina</nome><codice>I670</codice></comune>
<comune><nome>Sersale</nome><codice>I671</codice></comune>
<comune><nome>Servigliano</nome><codice>C070</codice></comune>
<comune><nome>Sessa Aurunca</nome><codice>I676</codice></comune>
<comune><nome>Sessa Cilento</nome><codice>I677</codice></comune>
<comune><nome>Sessame</nome><codice>I678</codice></comune>
<comune><nome>Sessano del Molise</nome><codice>I679</codice></comune>
<comune><nome>Sesta Godano</nome><codice>E070</codice></comune>
<comune><nome>Sestino</nome><codice>I681</codice></comune>
<comune><nome>Sesto</nome><codice>I687</codice></comune>
<comune><nome>Sesto al Reghena</nome><codice>I686</codice></comune>
<comune><nome>Sesto Calende</nome><codice>I688</codice></comune>
<comune><nome>Sesto Campano</nome><codice>I682</codice></comune>
<comune><nome>Sesto ed Uniti</nome><codice>I683</codice></comune>
<comune><nome>Sesto Fiorentino</nome><codice>I684</codice></comune>
<comune><nome>Sesto San Giovanni</nome><codice>I690</codice></comune>
<comune><nome>Sestola</nome><codice>I689</codice></comune>
<comune><nome>Sestri Levante</nome><codice>I693</codice></comune>
<comune><nome>Sestriere</nome><codice>I692</codice></comune>
<comune><nome>Sestu</nome><codice>I695</codice></comune>
<comune><nome>Settala</nome><codice>I696</codice></comune>
<comune><nome>Settefrati</nome><codice>I697</codice></comune>
<comune><nome>Settime</nome><codice>I698</codice></comune>
<comune><nome>Settimo Milanese</nome><codice>I700</codice></comune>
<comune><nome>Settimo Rottaro</nome><codice>I701</codice></comune>
<comune><nome>Settimo San Pietro</nome><codice>I699</codice></comune>
<comune><nome>Settimo Torinese</nome><codice>I703</codice></comune>
<comune><nome>Settimo Vittone</nome><codice>I702</codice></comune>
<comune><nome>Settingiano</nome><codice>I704</codice></comune>
<comune><nome>Setzu</nome><codice>I705</codice></comune>
<comune><nome>Seui</nome><codice>I706</codice></comune>
<comune><nome>Seulo</nome><codice>I707</codice></comune>
<comune><nome>Seveso</nome><codice>I709</codice></comune>
<comune><nome>Sezzadio</nome><codice>I711</codice></comune>
<comune><nome>Sezze</nome><codice>I712</codice></comune>
<comune><nome>Sfruz</nome><codice>I714</codice></comune>
<comune><nome>Sgonico</nome><codice>I715</codice></comune>
<comune><nome>Sgurgola</nome><codice>I716</codice></comune>
<comune><nome>Siamaggiore</nome><codice>I717</codice></comune>
<comune><nome>Siamanna</nome><codice>I718</codice></comune>
<comune><nome>Siano</nome><codice>I720</codice></comune>
<comune><nome>Siapiccia</nome><codice>I721</codice></comune>
<comune><nome>Sicignano degli Alburni</nome><codice>M253</codice></comune>
<comune><nome>Siculiana</nome><codice>I723</codice></comune>
<comune><nome>Siddi</nome><codice>I724</codice></comune>
<comune><nome>Siderno</nome><codice>I725</codice></comune>
<comune><nome>Siena</nome><codice>I726</codice></comune>
<comune><nome>Sigillo</nome><codice>I727</codice></comune>
<comune><nome>Signa</nome><codice>I728</codice></comune>
<comune><nome>Silandro</nome><codice>I729</codice></comune>
<comune><nome>Silanus</nome><codice>I730</codice></comune>
<comune><nome>Silea</nome><codice>F116</codice></comune>
<comune><nome>Siligo</nome><codice>I732</codice></comune>
<comune><nome>Siliqua</nome><codice>I734</codice></comune>
<comune><nome>Silius</nome><codice>I735</codice></comune>
<comune><nome>Sillano</nome><codice>I737</codice></comune>
<comune><nome>Sillavengo</nome><codice>I736</codice></comune>
<comune><nome>Silvano d'Orba</nome><codice>I738</codice></comune>
<comune><nome>Silvano Pietra</nome><codice>I739</codice></comune>
<comune><nome>Silvi</nome><codice>I741</codice></comune>
<comune><nome>Simala</nome><codice>I742</codice></comune>
<comune><nome>Simaxis</nome><codice>I743</codice></comune>
<comune><nome>Simbario</nome><codice>I744</codice></comune>
<comune><nome>Simeri Crichi</nome><codice>I745</codice></comune>
<comune><nome>Sinagra</nome><codice>I747</codice></comune>
<comune><nome>Sinalunga</nome><codice>A468</codice></comune>
<comune><nome>Sindia</nome><codice>I748</codice></comune>
<comune><nome>Sini</nome><codice>I749</codice></comune>
<comune><nome>Sinio</nome><codice>I750</codice></comune>
<comune><nome>Siniscola</nome><codice>I751</codice></comune>
<comune><nome>Sinnai</nome><codice>I752</codice></comune>
<comune><nome>Sinopoli</nome><codice>I753</codice></comune>
<comune><nome>Siracusa</nome><codice>I754</codice></comune>
<comune><nome>Sirignano</nome><codice>I756</codice></comune>
<comune><nome>Siris</nome><codice>I757</codice></comune>
<comune><nome>Sirmione</nome><codice>I633</codice></comune>
<comune><nome>Sirolo</nome><codice>I758</codice></comune>
<comune><nome>Sirone</nome><codice>I759</codice></comune>
<comune><nome>Siror</nome><codice>I760</codice></comune>
<comune><nome>Sirtori</nome><codice>I761</codice></comune>
<comune><nome>Sissa</nome><codice>I763</codice></comune>
<comune><nome>Siurgus Donigala</nome><codice>I765</codice></comune>
<comune><nome>Siziano</nome><codice>E265</codice></comune>
<comune><nome>Sizzano</nome><codice>I767</codice></comune>
<comune><nome>Sluderno</nome><codice>I771</codice></comune>
<comune><nome>Smarano</nome><codice>I772</codice></comune>
<comune><nome>Smerillo</nome><codice>I774</codice></comune>
<comune><nome>Soave</nome><codice>I775</codice></comune>
<comune><nome>Socchieve</nome><codice>I777</codice></comune>
<comune><nome>Soddì</nome><codice>I778</codice></comune>
<comune><nome>Sogliano al Rubicone</nome><codice>I779</codice></comune>
<comune><nome>Sogliano Cavour</nome><codice>I780</codice></comune>
<comune><nome>Soglio</nome><codice>I781</codice></comune>
<comune><nome>Soiano del Lago</nome><codice>I782</codice></comune>
<comune><nome>Solagna</nome><codice>I783</codice></comune>
<comune><nome>Solarino</nome><codice>I785</codice></comune>
<comune><nome>Solaro</nome><codice>I786</codice></comune>
<comune><nome>Solarolo</nome><codice>I787</codice></comune>
<comune><nome>Solarolo Rainerio</nome><codice>I790</codice></comune>
<comune><nome>Solarussa</nome><codice>I791</codice></comune>
<comune><nome>Solbiate</nome><codice>I792</codice></comune>
<comune><nome>Solbiate Arno</nome><codice>I793</codice></comune>
<comune><nome>Solbiate Olona</nome><codice>I794</codice></comune>
<comune><nome>Soldano</nome><codice>I796</codice></comune>
<comune><nome>Soleminis</nome><codice>I797</codice></comune>
<comune><nome>Solero</nome><codice>I798</codice></comune>
<comune><nome>Solesino</nome><codice>I799</codice></comune>
<comune><nome>Soleto</nome><codice>I800</codice></comune>
<comune><nome>Solferino</nome><codice>I801</codice></comune>
<comune><nome>Soliera</nome><codice>I802</codice></comune>
<comune><nome>Solignano</nome><codice>I803</codice></comune>
<comune><nome>Solofra</nome><codice>I805</codice></comune>
<comune><nome>Solonghello</nome><codice>I808</codice></comune>
<comune><nome>Solopaca</nome><codice>I809</codice></comune>
<comune><nome>Solto Collina</nome><codice>I812</codice></comune>
<comune><nome>Solza</nome><codice>I813</codice></comune>
<comune><nome>Somaglia</nome><codice>I815</codice></comune>
<comune><nome>Somano</nome><codice>I817</codice></comune>
<comune><nome>Somma Lombardo</nome><codice>I819</codice></comune>
<comune><nome>Somma Vesuviana</nome><codice>I820</codice></comune>
<comune><nome>Sommacampagna</nome><codice>I821</codice></comune>
<comune><nome>Sommariva del Bosco</nome><codice>I822</codice></comune>
<comune><nome>Sommariva Perno</nome><codice>I823</codice></comune>
<comune><nome>Sommatino</nome><codice>I824</codice></comune>
<comune><nome>Sommo</nome><codice>I825</codice></comune>
<comune><nome>Sona</nome><codice>I826</codice></comune>
<comune><nome>Soncino</nome><codice>I827</codice></comune>
<comune><nome>Sondalo</nome><codice>I828</codice></comune>
<comune><nome>Sondrio</nome><codice>I829</codice></comune>
<comune><nome>Songavazzo</nome><codice>I830</codice></comune>
<comune><nome>Sonico</nome><codice>I831</codice></comune>
<comune><nome>Sonnino</nome><codice>I832</codice></comune>
<comune><nome>Soprana</nome><codice>I835</codice></comune>
<comune><nome>Sora</nome><codice>I838</codice></comune>
<comune><nome>Soraga</nome><codice>I839</codice></comune>
<comune><nome>Soragna</nome><codice>I840</codice></comune>
<comune><nome>Sorano</nome><codice>I841</codice></comune>
<comune><nome>Sorbo San Basile</nome><codice>I844</codice></comune>
<comune><nome>Sorbo Serpico</nome><codice>I843</codice></comune>
<comune><nome>Sorbolo</nome><codice>I845</codice></comune>
<comune><nome>Sordevolo</nome><codice>I847</codice></comune>
<comune><nome>Sordio</nome><codice>I848</codice></comune>
<comune><nome>Soresina</nome><codice>I849</codice></comune>
<comune><nome>Sorgà</nome><codice>I850</codice></comune>
<comune><nome>Sorgono</nome><codice>I851</codice></comune>
<comune><nome>Sori</nome><codice>I852</codice></comune>
<comune><nome>Sorianello</nome><codice>I853</codice></comune>
<comune><nome>Soriano Calabro</nome><codice>I854</codice></comune>
<comune><nome>Soriano nel Cimino</nome><codice>I855</codice></comune>
<comune><nome>Sorico</nome><codice>I856</codice></comune>
<comune><nome>Soriso</nome><codice>I857</codice></comune>
<comune><nome>Sorisole</nome><codice>I858</codice></comune>
<comune><nome>Sormano</nome><codice>I860</codice></comune>
<comune><nome>Sorradile</nome><codice>I861</codice></comune>
<comune><nome>Sorrento</nome><codice>I862</codice></comune>
<comune><nome>Sorso</nome><codice>I863</codice></comune>
<comune><nome>Sortino</nome><codice>I864</codice></comune>
<comune><nome>Sospiro</nome><codice>I865</codice></comune>
<comune><nome>Sospirolo</nome><codice>I866</codice></comune>
<comune><nome>Sossano</nome><codice>I867</codice></comune>
<comune><nome>Sostegno</nome><codice>I868</codice></comune>
<comune><nome>Sotto il Monte Giovanni XXIII</nome><codice>I869</codice></comune>
<comune><nome>Sover</nome><codice>I871</codice></comune>
<comune><nome>Soverato</nome><codice>I872</codice></comune>
<comune><nome>Sovere</nome><codice>I873</codice></comune>
<comune><nome>Soveria Mannelli</nome><codice>I874</codice></comune>
<comune><nome>Soveria Simeri</nome><codice>I875</codice></comune>
<comune><nome>Soverzene</nome><codice>I876</codice></comune>
<comune><nome>Sovicille</nome><codice>I877</codice></comune>
<comune><nome>Sovico</nome><codice>I878</codice></comune>
<comune><nome>Sovizzo</nome><codice>I879</codice></comune>
<comune><nome>Sovramonte</nome><codice>I673</codice></comune>
<comune><nome>Sozzago</nome><codice>I880</codice></comune>
<comune><nome>Spadafora</nome><codice>I881</codice></comune>
<comune><nome>Spadola</nome><codice>I884</codice></comune>
<comune><nome>Sparanise</nome><codice>I885</codice></comune>
<comune><nome>Sparone</nome><codice>I886</codice></comune>
<comune><nome>Specchia</nome><codice>I887</codice></comune>
<comune><nome>Spello</nome><codice>I888</codice></comune>
<comune><nome>Spera</nome><codice>I889</codice></comune>
<comune><nome>Sperlinga</nome><codice>I891</codice></comune>
<comune><nome>Sperlonga</nome><codice>I892</codice></comune>
<comune><nome>Sperone</nome><codice>I893</codice></comune>
<comune><nome>Spessa</nome><codice>I894</codice></comune>
<comune><nome>Spezzano Albanese</nome><codice>I895</codice></comune>
<comune><nome>Spezzano della Sila</nome><codice>I896</codice></comune>
<comune><nome>Spezzano Piccolo</nome><codice>I898</codice></comune>
<comune><nome>Spiazzo</nome><codice>I899</codice></comune>
<comune><nome>Spigno Monferrato</nome><codice>I901</codice></comune>
<comune><nome>Spigno Saturnia</nome><codice>I902</codice></comune>
<comune><nome>Spilamberto</nome><codice>I903</codice></comune>
<comune><nome>Spilimbergo</nome><codice>I904</codice></comune>
<comune><nome>Spilinga</nome><codice>I905</codice></comune>
<comune><nome>Spinadesco</nome><codice>I906</codice></comune>
<comune><nome>Spinazzola</nome><codice>I907</codice></comune>
<comune><nome>Spinea</nome><codice>I908</codice></comune>
<comune><nome>Spineda</nome><codice>I909</codice></comune>
<comune><nome>Spinete</nome><codice>I910</codice></comune>
<comune><nome>Spineto Scrivia</nome><codice>I911</codice></comune>
<comune><nome>Spinetoli</nome><codice>I912</codice></comune>
<comune><nome>Spino d'Adda</nome><codice>I914</codice></comune>
<comune><nome>Spinone al Lago</nome><codice>I916</codice></comune>
<comune><nome>Spinoso</nome><codice>I917</codice></comune>
<comune><nome>Spirano</nome><codice>I919</codice></comune>
<comune><nome>Spoleto</nome><codice>I921</codice></comune>
<comune><nome>Spoltore</nome><codice>I922</codice></comune>
<comune><nome>Spongano</nome><codice>I923</codice></comune>
<comune><nome>Spormaggiore</nome><codice>I924</codice></comune>
<comune><nome>Sporminore</nome><codice>I925</codice></comune>
<comune><nome>Spotorno</nome><codice>I926</codice></comune>
<comune><nome>Spresiano</nome><codice>I927</codice></comune>
<comune><nome>Spriana</nome><codice>I928</codice></comune>
<comune><nome>Squillace</nome><codice>I929</codice></comune>
<comune><nome>Squinzano</nome><codice>I930</codice></comune>
<comune><nome>Staffolo</nome><codice>I932</codice></comune>
<comune><nome>Stagno Lombardo</nome><codice>I935</codice></comune>
<comune><nome>Staiti</nome><codice>I936</codice></comune>
<comune><nome>Stalettì</nome><codice>I937</codice></comune>
<comune><nome>Stanghella</nome><codice>I938</codice></comune>
<comune><nome>Staranzano</nome><codice>I939</codice></comune>
<comune><nome>Statte</nome><codice>M298</codice></comune>
<comune><nome>Stazzano</nome><codice>I941</codice></comune>
<comune><nome>Stazzema</nome><codice>I942</codice></comune>
<comune><nome>Stazzona</nome><codice>I943</codice></comune>
<comune><nome>Stefanaconi</nome><codice>I945</codice></comune>
<comune><nome>Stella</nome><codice>I946</codice></comune>
<comune><nome>Stella Cilento</nome><codice>G887</codice></comune>
<comune><nome>Stellanello</nome><codice>I947</codice></comune>
<comune><nome>Stelvio</nome><codice>I948</codice></comune>
<comune><nome>Stenico</nome><codice>I949</codice></comune>
<comune><nome>Sternatia</nome><codice>I950</codice></comune>
<comune><nome>Stezzano</nome><codice>I951</codice></comune>
<comune><nome>Stia</nome><codice>I952</codice></comune>
<comune><nome>Stienta</nome><codice>I953</codice></comune>
<comune><nome>Stigliano</nome><codice>I954</codice></comune>
<comune><nome>Stignano</nome><codice>I955</codice></comune>
<comune><nome>Stilo</nome><codice>I956</codice></comune>
<comune><nome>Stimigliano</nome><codice>I959</codice></comune>
<comune><nome>Stintino</nome><codice>M290</codice></comune>
<comune><nome>Stio</nome><codice>I960</codice></comune>
<comune><nome>Stornara</nome><codice>I962</codice></comune>
<comune><nome>Stornarella</nome><codice>I963</codice></comune>
<comune><nome>Storo</nome><codice>I964</codice></comune>
<comune><nome>Stra</nome><codice>I965</codice></comune>
<comune><nome>Stradella</nome><codice>I968</codice></comune>
<comune><nome>Strambinello</nome><codice>I969</codice></comune>
<comune><nome>Strambino</nome><codice>I970</codice></comune>
<comune><nome>Strangolagalli</nome><codice>I973</codice></comune>
<comune><nome>Stregna</nome><codice>I974</codice></comune>
<comune><nome>Strembo</nome><codice>I975</codice></comune>
<comune><nome>Stresa</nome><codice>I976</codice></comune>
<comune><nome>Strevi</nome><codice>I977</codice></comune>
<comune><nome>Striano</nome><codice>I978</codice></comune>
<comune><nome>Strigno</nome><codice>I979</codice></comune>
<comune><nome>Strona</nome><codice>I980</codice></comune>
<comune><nome>Stroncone</nome><codice>I981</codice></comune>
<comune><nome>Strongoli</nome><codice>I982</codice></comune>
<comune><nome>Stroppiana</nome><codice>I984</codice></comune>
<comune><nome>Stroppo</nome><codice>I985</codice></comune>
<comune><nome>Strozza</nome><codice>I986</codice></comune>
<comune><nome>Sturno</nome><codice>I990</codice></comune>
<comune><nome>Suardi</nome><codice>B014</codice></comune>
<comune><nome>Subbiano</nome><codice>I991</codice></comune>
<comune><nome>Subiaco</nome><codice>I992</codice></comune>
<comune><nome>Succivo</nome><codice>I993</codice></comune>
<comune><nome>Sueglio</nome><codice>I994</codice></comune>
<comune><nome>Suelli</nome><codice>I995</codice></comune>
<comune><nome>Suello</nome><codice>I996</codice></comune>
<comune><nome>Suisio</nome><codice>I997</codice></comune>
<comune><nome>Sulbiate</nome><codice>I998</codice></comune>
<comune><nome>Sulmona</nome><codice>I804</codice></comune>
<comune><nome>Sulzano</nome><codice>L002</codice></comune>
<comune><nome>Sumirago</nome><codice>L003</codice></comune>
<comune><nome>Summonte</nome><codice>L004</codice></comune>
<comune><nome>Suni</nome><codice>L006</codice></comune>
<comune><nome>Suno</nome><codice>L007</codice></comune>
<comune><nome>Supersano</nome><codice>L008</codice></comune>
<comune><nome>Supino</nome><codice>L009</codice></comune>
<comune><nome>Surano</nome><codice>L010</codice></comune>
<comune><nome>Surbo</nome><codice>L011</codice></comune>
<comune><nome>Susa</nome><codice>L013</codice></comune>
<comune><nome>Susegana</nome><codice>L014</codice></comune>
<comune><nome>Sustinente</nome><codice>L015</codice></comune>
<comune><nome>Sutera</nome><codice>L016</codice></comune>
<comune><nome>Sutri</nome><codice>L017</codice></comune>
<comune><nome>Sutrio</nome><codice>L018</codice></comune>
<comune><nome>Suvereto</nome><codice>L019</codice></comune>
<comune><nome>Suzzara</nome><codice>L020</codice></comune>
<comune><nome>Taceno</nome><codice>L022</codice></comune>
<comune><nome>Tadasuni</nome><codice>L023</codice></comune>
<comune><nome>Taggia</nome><codice>L024</codice></comune>
<comune><nome>Tagliacozzo</nome><codice>L025</codice></comune>
<comune><nome>Taglio di Po</nome><codice>L026</codice></comune>
<comune><nome>Tagliolo Monferrato</nome><codice>L027</codice></comune>
<comune><nome>Taibon Agordino</nome><codice>L030</codice></comune>
<comune><nome>Taino</nome><codice>L032</codice></comune>
<comune><nome>Taio</nome><codice>L033</codice></comune>
<comune><nome>Taipana</nome><codice>G736</codice></comune>
<comune><nome>Talamello</nome><codice>L034</codice></comune>
<comune><nome>Talamona</nome><codice>L035</codice></comune>
<comune><nome>Talana</nome><codice>L036</codice></comune>
<comune><nome>Taleggio</nome><codice>L037</codice></comune>
<comune><nome>Talla</nome><codice>L038</codice></comune>
<comune><nome>Talmassons</nome><codice>L039</codice></comune>
<comune><nome>Tambre</nome><codice>L040</codice></comune>
<comune><nome>Taormina</nome><codice>L042</codice></comune>
<comune><nome>Tarano</nome><codice>L046</codice></comune>
<comune><nome>Taranta Peligna</nome><codice>L047</codice></comune>
<comune><nome>Tarantasca</nome><codice>L048</codice></comune>
<comune><nome>Taranto</nome><codice>L049</codice></comune>
<comune><nome>Tarcento</nome><codice>L050</codice></comune>
<comune><nome>Tarquinia</nome><codice>D024</codice></comune>
<comune><nome>Tarsia</nome><codice>L055</codice></comune>
<comune><nome>Tartano</nome><codice>L056</codice></comune>
<comune><nome>Tarvisio</nome><codice>L057</codice></comune>
<comune><nome>Tarzo</nome><codice>L058</codice></comune>
<comune><nome>Tassarolo</nome><codice>L059</codice></comune>
<comune><nome>Tassullo</nome><codice>L060</codice></comune>
<comune><nome>Taurano</nome><codice>L061</codice></comune>
<comune><nome>Taurasi</nome><codice>L062</codice></comune>
<comune><nome>Taurianova</nome><codice>L063</codice></comune>
<comune><nome>Taurisano</nome><codice>L064</codice></comune>
<comune><nome>Tavagnacco</nome><codice>L065</codice></comune>
<comune><nome>Tavagnasco</nome><codice>L066</codice></comune>
<comune><nome>Tavarnelle Val di Pesa</nome><codice>L067</codice></comune>
<comune><nome>Tavazzano con Villavesco</nome><codice>F260</codice></comune>
<comune><nome>Tavenna</nome><codice>L069</codice></comune>
<comune><nome>Taverna</nome><codice>L070</codice></comune>
<comune><nome>Tavernerio</nome><codice>L071</codice></comune>
<comune><nome>Tavernola Bergamasca</nome><codice>L073</codice></comune>
<comune><nome>Tavernole sul Mella</nome><codice>C698</codice></comune>
<comune><nome>Taviano</nome><codice>L074</codice></comune>
<comune><nome>Tavigliano</nome><codice>L075</codice></comune>
<comune><nome>Tavoleto</nome><codice>L078</codice></comune>
<comune><nome>Tavullia</nome><codice>L081</codice></comune>
<comune><nome>Teana</nome><codice>L082</codice></comune>
<comune><nome>Teano</nome><codice>L083</codice></comune>
<comune><nome>Teggiano</nome><codice>D292</codice></comune>
<comune><nome>Teglio</nome><codice>L084</codice></comune>
<comune><nome>Teglio Veneto</nome><codice>L085</codice></comune>
<comune><nome>Telese Terme</nome><codice>L086</codice></comune>
<comune><nome>Telgate</nome><codice>L087</codice></comune>
<comune><nome>Telti</nome><codice>L088</codice></comune>
<comune><nome>Telve</nome><codice>L089</codice></comune>
<comune><nome>Telve di Sopra</nome><codice>L090</codice></comune>
<comune><nome>Tempio Pausania</nome><codice>L093</codice></comune>
<comune><nome>Temù</nome><codice>L094</codice></comune>
<comune><nome>Tenna</nome><codice>L096</codice></comune>
<comune><nome>Tenno</nome><codice>L097</codice></comune>
<comune><nome>Teolo</nome><codice>L100</codice></comune>
<comune><nome>Teor</nome><codice>L101</codice></comune>
<comune><nome>Teora</nome><codice>L102</codice></comune>
<comune><nome>Teramo</nome><codice>L103</codice></comune>
<comune><nome>Terdobbiate</nome><codice>L104</codice></comune>
<comune><nome>Terelle</nome><codice>L105</codice></comune>
<comune><nome>Terento</nome><codice>L106</codice></comune>
<comune><nome>Terenzo</nome><codice>E548</codice></comune>
<comune><nome>Tergu</nome><codice>M282</codice></comune>
<comune><nome>Terlago</nome><codice>L107</codice></comune>
<comune><nome>Terlano</nome><codice>L108</codice></comune>
<comune><nome>Terlizzi</nome><codice>L109</codice></comune>
<comune><nome>Terme Vigliatore</nome><codice>M210</codice></comune>
<comune><nome>Termeno sulla Strada del Vino</nome><codice>L111</codice></comune>
<comune><nome>Termini Imerese</nome><codice>L112</codice></comune>
<comune><nome>Termoli</nome><codice>L113</codice></comune>
<comune><nome>Ternate</nome><codice>L115</codice></comune>
<comune><nome>Ternengo</nome><codice>L116</codice></comune>
<comune><nome>Terni</nome><codice>L117</codice></comune>
<comune><nome>Terno d'Isola</nome><codice>L118</codice></comune>
<comune><nome>Terracina</nome><codice>L120</codice></comune>
<comune><nome>Terragnolo</nome><codice>L121</codice></comune>
<comune><nome>Terralba</nome><codice>L122</codice></comune>
<comune><nome>Terranova da Sibari</nome><codice>L124</codice></comune>
<comune><nome>Terranova dei Passerini</nome><codice>L125</codice></comune>
<comune><nome>Terranova di Pollino</nome><codice>L126</codice></comune>
<comune><nome>Terranova Sappo Minulio</nome><codice>L127</codice></comune>
<comune><nome>Terranuova Bracciolini</nome><codice>L123</codice></comune>
<comune><nome>Terrasini</nome><codice>L131</codice></comune>
<comune><nome>Terrassa Padovana</nome><codice>L132</codice></comune>
<comune><nome>Terravecchia</nome><codice>L134</codice></comune>
<comune><nome>Terrazzo</nome><codice>L136</codice></comune>
<comune><nome>Terres</nome><codice>L137</codice></comune>
<comune><nome>Terricciola</nome><codice>L138</codice></comune>
<comune><nome>Terruggia</nome><codice>L139</codice></comune>
<comune><nome>Tertenia</nome><codice>L140</codice></comune>
<comune><nome>Terzigno</nome><codice>L142</codice></comune>
<comune><nome>Terzo</nome><codice>L143</codice></comune>
<comune><nome>Terzo d'Aquileia</nome><codice>L144</codice></comune>
<comune><nome>Terzolas</nome><codice>L145</codice></comune>
<comune><nome>Terzorio</nome><codice>L146</codice></comune>
<comune><nome>Tesero</nome><codice>L147</codice></comune>
<comune><nome>Tesimo</nome><codice>L149</codice></comune>
<comune><nome>Tessennano</nome><codice>L150</codice></comune>
<comune><nome>Testico</nome><codice>L152</codice></comune>
<comune><nome>Teti</nome><codice>L153</codice></comune>
<comune><nome>Teulada</nome><codice>L154</codice></comune>
<comune><nome>Teverola</nome><codice>L155</codice></comune>
<comune><nome>Tezze sul Brenta</nome><codice>L156</codice></comune>
<comune><nome>Thiene</nome><codice>L157</codice></comune>
<comune><nome>Thiesi</nome><codice>L158</codice></comune>
<comune><nome>Tiana</nome><codice>L160</codice></comune>
<comune><nome>Ticengo</nome><codice>L164</codice></comune>
<comune><nome>Ticineto</nome><codice>L165</codice></comune>
<comune><nome>Tiggiano</nome><codice>L166</codice></comune>
<comune><nome>Tiglieto</nome><codice>L167</codice></comune>
<comune><nome>Tigliole</nome><codice>L168</codice></comune>
<comune><nome>Tignale</nome><codice>L169</codice></comune>
<comune><nome>Tinnura</nome><codice>L172</codice></comune>
<comune><nome>Tione degli Abruzzi</nome><codice>L173</codice></comune>
<comune><nome>Tione di Trento</nome><codice>L174</codice></comune>
<comune><nome>Tirano</nome><codice>L175</codice></comune>
<comune><nome>Tires</nome><codice>L176</codice></comune>
<comune><nome>Tiriolo</nome><codice>L177</codice></comune>
<comune><nome>Tirolo</nome><codice>L178</codice></comune>
<comune><nome>Tissi</nome><codice>L180</codice></comune>
<comune><nome>Tito</nome><codice>L181</codice></comune>
<comune><nome>Tivoli</nome><codice>L182</codice></comune>
<comune><nome>Tizzano Val Parma</nome><codice>L183</codice></comune>
<comune><nome>Toano</nome><codice>L184</codice></comune>
<comune><nome>Tocco Caudio</nome><codice>L185</codice></comune>
<comune><nome>Tocco da Casauria</nome><codice>L186</codice></comune>
<comune><nome>Toceno</nome><codice>L187</codice></comune>
<comune><nome>Todi</nome><codice>L188</codice></comune>
<comune><nome>Toffia</nome><codice>L189</codice></comune>
<comune><nome>Toirano</nome><codice>L190</codice></comune>
<comune><nome>Tolentino</nome><codice>L191</codice></comune>
<comune><nome>Tolfa</nome><codice>L192</codice></comune>
<comune><nome>Tollegno</nome><codice>L193</codice></comune>
<comune><nome>Tollo</nome><codice>L194</codice></comune>
<comune><nome>Tolmezzo</nome><codice>L195</codice></comune>
<comune><nome>Tolve</nome><codice>L197</codice></comune>
<comune><nome>Tombolo</nome><codice>L199</codice></comune>
<comune><nome>Ton</nome><codice>L200</codice></comune>
<comune><nome>Tonadico</nome><codice>L201</codice></comune>
<comune><nome>Tonara</nome><codice>L202</codice></comune>
<comune><nome>Tonco</nome><codice>L203</codice></comune>
<comune><nome>Tonengo</nome><codice>L204</codice></comune>
<comune><nome>Tonezza del Cimone</nome><codice>D717</codice></comune>
<comune><nome>Tora e Piccilli</nome><codice>L205</codice></comune>
<comune><nome>Torano Castello</nome><codice>L206</codice></comune>
<comune><nome>Torano Nuovo</nome><codice>L207</codice></comune>
<comune><nome>Torbole Casaglia</nome><codice>L210</codice></comune>
<comune><nome>Torcegno</nome><codice>L211</codice></comune>
<comune><nome>Torchiara</nome><codice>L212</codice></comune>
<comune><nome>Torchiarolo</nome><codice>L213</codice></comune>
<comune><nome>Torella dei Lombardi</nome><codice>L214</codice></comune>
<comune><nome>Torella del Sannio</nome><codice>L215</codice></comune>
<comune><nome>Torgiano</nome><codice>L216</codice></comune>
<comune><nome>Torgnon</nome><codice>L217</codice></comune>
<comune><nome>Torino</nome><codice>L219</codice></comune>
<comune><nome>Torino di Sangro</nome><codice>L218</codice></comune>
<comune><nome>Toritto</nome><codice>L220</codice></comune>
<comune><nome>Torlino Vimercati</nome><codice>L221</codice></comune>
<comune><nome>Tornaco</nome><codice>L223</codice></comune>
<comune><nome>Tornareccio</nome><codice>L224</codice></comune>
<comune><nome>Tornata</nome><codice>L225</codice></comune>
<comune><nome>Tornimparte</nome><codice>L227</codice></comune>
<comune><nome>Torno</nome><codice>L228</codice></comune>
<comune><nome>Tornolo</nome><codice>L229</codice></comune>
<comune><nome>Toro</nome><codice>L230</codice></comune>
<comune><nome>Torpè</nome><codice>L231</codice></comune>
<comune><nome>Torraca</nome><codice>L233</codice></comune>
<comune><nome>Torralba</nome><codice>L235</codice></comune>
<comune><nome>Torrazza Coste</nome><codice>L237</codice></comune>
<comune><nome>Torrazza Piemonte</nome><codice>L238</codice></comune>
<comune><nome>Torrazzo</nome><codice>L239</codice></comune>
<comune><nome>Torre Annunziata</nome><codice>L245</codice></comune>
<comune><nome>Torre Beretti e Castellaro</nome><codice>L250</codice></comune>
<comune><nome>Torre Boldone</nome><codice>L251</codice></comune>
<comune><nome>Torre Bormida</nome><codice>L252</codice></comune>
<comune><nome>Torre Cajetani</nome><codice>L243</codice></comune>
<comune><nome>Torre Canavese</nome><codice>L247</codice></comune>
<comune><nome>Torre d'Arese</nome><codice>L256</codice></comune>
<comune><nome>Torre de' Busi</nome><codice>L257</codice></comune>
<comune><nome>Torre de' Negri</nome><codice>L262</codice></comune>
<comune><nome>Torre De' Passeri</nome><codice>L263</codice></comune>
<comune><nome>Torre de' Picenardi</nome><codice>L258</codice></comune>
<comune><nome>Torre de' Roveri</nome><codice>L265</codice></comune>
<comune><nome>Torre del Greco</nome><codice>L259</codice></comune>
<comune><nome>Torre di Mosto</nome><codice>L267</codice></comune>
<comune><nome>Torre di Ruggiero</nome><codice>L240</codice></comune>
<comune><nome>Torre di Santa Maria</nome><codice>L244</codice></comune>
<comune><nome>Torre d'Isola</nome><codice>L269</codice></comune>
<comune><nome>Torre Le Nocelle</nome><codice>L272</codice></comune>
<comune><nome>Torre Mondovì</nome><codice>L241</codice></comune>
<comune><nome>Torre Orsaia</nome><codice>L274</codice></comune>
<comune><nome>Torre Pallavicina</nome><codice>L276</codice></comune>
<comune><nome>Torre Pellice</nome><codice>L277</codice></comune>
<comune><nome>Torre San Giorgio</nome><codice>L278</codice></comune>
<comune><nome>Torre San Patrizio</nome><codice>L279</codice></comune>
<comune><nome>Torre Santa Susanna</nome><codice>L280</codice></comune>
<comune><nome>Torreano</nome><codice>L246</codice></comune>
<comune><nome>Torrebelvicino</nome><codice>L248</codice></comune>
<comune><nome>Torrebruna</nome><codice>L253</codice></comune>
<comune><nome>Torrecuso</nome><codice>L254</codice></comune>
<comune><nome>Torreglia</nome><codice>L270</codice></comune>
<comune><nome>Torregrotta</nome><codice>L271</codice></comune>
<comune><nome>Torremaggiore</nome><codice>L273</codice></comune>
<comune><nome>Torrenova</nome><codice>M286</codice></comune>
<comune><nome>Torresina</nome><codice>L281</codice></comune>
<comune><nome>Torretta</nome><codice>L282</codice></comune>
<comune><nome>Torrevecchia Pia</nome><codice>L285</codice></comune>
<comune><nome>Torrevecchia Teatina</nome><codice>L284</codice></comune>
<comune><nome>Torri del Benaco</nome><codice>L287</codice></comune>
<comune><nome>Torri di Quartesolo</nome><codice>L297</codice></comune>
<comune><nome>Torri in Sabina</nome><codice>L286</codice></comune>
<comune><nome>Torriana</nome><codice>I550</codice></comune>
<comune><nome>Torrice</nome><codice>L290</codice></comune>
<comune><nome>Torricella</nome><codice>L294</codice></comune>
<comune><nome>Torricella del Pizzo</nome><codice>L296</codice></comune>
<comune><nome>Torricella in Sabina</nome><codice>L293</codice></comune>
<comune><nome>Torricella Peligna</nome><codice>L291</codice></comune>
<comune><nome>Torricella Sicura</nome><codice>L295</codice></comune>
<comune><nome>Torricella Verzate</nome><codice>L292</codice></comune>
<comune><nome>Torriglia</nome><codice>L298</codice></comune>
<comune><nome>Torrile</nome><codice>L299</codice></comune>
<comune><nome>Torrioni</nome><codice>L301</codice></comune>
<comune><nome>Torrita di Siena</nome><codice>L303</codice></comune>
<comune><nome>Torrita Tiberina</nome><codice>L302</codice></comune>
<comune><nome>Tortolì</nome><codice>A355</codice></comune>
<comune><nome>Tortona</nome><codice>L304</codice></comune>
<comune><nome>Tortora</nome><codice>L305</codice></comune>
<comune><nome>Tortorella</nome><codice>L306</codice></comune>
<comune><nome>Tortoreto</nome><codice>L307</codice></comune>
<comune><nome>Tortorici</nome><codice>L308</codice></comune>
<comune><nome>Torviscosa</nome><codice>L309</codice></comune>
<comune><nome>Toscolano-Maderno</nome><codice>L312</codice></comune>
<comune><nome>Tossicia</nome><codice>L314</codice></comune>
<comune><nome>Tovo di Sant'Agata</nome><codice>L316</codice></comune>
<comune><nome>Tovo San Giacomo</nome><codice>L315</codice></comune>
<comune><nome>Trabia</nome><codice>L317</codice></comune>
<comune><nome>Tradate</nome><codice>L319</codice></comune>
<comune><nome>Tramatza</nome><codice>L321</codice></comune>
<comune><nome>Trambileno</nome><codice>L322</codice></comune>
<comune><nome>Tramonti</nome><codice>L323</codice></comune>
<comune><nome>Tramonti di Sopra</nome><codice>L324</codice></comune>
<comune><nome>Tramonti di Sotto</nome><codice>L325</codice></comune>
<comune><nome>Tramutola</nome><codice>L326</codice></comune>
<comune><nome>Trana</nome><codice>L327</codice></comune>
<comune><nome>Trani</nome><codice>L328</codice></comune>
<comune><nome>Transacqua</nome><codice>L329</codice></comune>
<comune><nome>Traona</nome><codice>L330</codice></comune>
<comune><nome>Trapani</nome><codice>L331</codice></comune>
<comune><nome>Trappeto</nome><codice>L332</codice></comune>
<comune><nome>Trarego Viggiona</nome><codice>L333</codice></comune>
<comune><nome>Trasacco</nome><codice>L334</codice></comune>
<comune><nome>Trasaghis</nome><codice>L335</codice></comune>
<comune><nome>Trasquera</nome><codice>L336</codice></comune>
<comune><nome>Tratalias</nome><codice>L337</codice></comune>
<comune><nome>Trausella</nome><codice>L338</codice></comune>
<comune><nome>Travacò Siccomario</nome><codice>I236</codice></comune>
<comune><nome>Travagliato</nome><codice>L339</codice></comune>
<comune><nome>Travedona-Monate</nome><codice>L342</codice></comune>
<comune><nome>Traversella</nome><codice>L345</codice></comune>
<comune><nome>Traversetolo</nome><codice>L346</codice></comune>
<comune><nome>Traves</nome><codice>L340</codice></comune>
<comune><nome>Travesio</nome><codice>L347</codice></comune>
<comune><nome>Travo</nome><codice>L348</codice></comune>
<comune><nome>Trebaseleghe</nome><codice>L349</codice></comune>
<comune><nome>Trebisacce</nome><codice>L353</codice></comune>
<comune><nome>Trecasali</nome><codice>L354</codice></comune>
<comune><nome>Trecase</nome><codice>M280</codice></comune>
<comune><nome>Trecastagni</nome><codice>L355</codice></comune>
<comune><nome>Trecate</nome><codice>L356</codice></comune>
<comune><nome>Trecchina</nome><codice>L357</codice></comune>
<comune><nome>Trecenta</nome><codice>L359</codice></comune>
<comune><nome>Tredozio</nome><codice>L361</codice></comune>
<comune><nome>Treglio</nome><codice>L363</codice></comune>
<comune><nome>Tregnago</nome><codice>L364</codice></comune>
<comune><nome>Treia</nome><codice>L366</codice></comune>
<comune><nome>Treiso</nome><codice>L367</codice></comune>
<comune><nome>Tremenico</nome><codice>L368</codice></comune>
<comune><nome>Tremestieri Etneo</nome><codice>L369</codice></comune>
<comune><nome>Tremezzo</nome><codice>L371</codice></comune>
<comune><nome>Tremosine</nome><codice>L372</codice></comune>
<comune><nome>Trenta</nome><codice>L375</codice></comune>
<comune><nome>Trentinara</nome><codice>L377</codice></comune>
<comune><nome>Trento</nome><codice>L378</codice></comune>
<comune><nome>Trentola-Ducenta</nome><codice>L379</codice></comune>
<comune><nome>Trenzano</nome><codice>L380</codice></comune>
<comune><nome>Treppo Carnico</nome><codice>L381</codice></comune>
<comune><nome>Treppo Grande</nome><codice>L382</codice></comune>
<comune><nome>Trepuzzi</nome><codice>L383</codice></comune>
<comune><nome>Trequanda</nome><codice>L384</codice></comune>
<comune><nome>Tres</nome><codice>L385</codice></comune>
<comune><nome>Tresana</nome><codice>L386</codice></comune>
<comune><nome>Trescore Balneario</nome><codice>L388</codice></comune>
<comune><nome>Trescore Cremasco</nome><codice>L389</codice></comune>
<comune><nome>Tresigallo</nome><codice>L390</codice></comune>
<comune><nome>Tresivio</nome><codice>L392</codice></comune>
<comune><nome>Tresnuraghes</nome><codice>L393</codice></comune>
<comune><nome>Trevenzuolo</nome><codice>L396</codice></comune>
<comune><nome>Trevi</nome><codice>L397</codice></comune>
<comune><nome>Trevi nel Lazio</nome><codice>L398</codice></comune>
<comune><nome>Trevico</nome><codice>L399</codice></comune>
<comune><nome>Treviglio</nome><codice>L400</codice></comune>
<comune><nome>Trevignano</nome><codice>L402</codice></comune>
<comune><nome>Trevignano Romano</nome><codice>L401</codice></comune>
<comune><nome>Treville</nome><codice>L403</codice></comune>
<comune><nome>Treviolo</nome><codice>L404</codice></comune>
<comune><nome>Treviso</nome><codice>L407</codice></comune>
<comune><nome>Treviso Bresciano</nome><codice>L406</codice></comune>
<comune><nome>Trezzano Rosa</nome><codice>L408</codice></comune>
<comune><nome>Trezzano sul Naviglio</nome><codice>L409</codice></comune>
<comune><nome>Trezzo sull'Adda</nome><codice>L411</codice></comune>
<comune><nome>Trezzo Tinella</nome><codice>L410</codice></comune>
<comune><nome>Trezzone</nome><codice>L413</codice></comune>
<comune><nome>Tribano</nome><codice>L414</codice></comune>
<comune><nome>Tribiano</nome><codice>L415</codice></comune>
<comune><nome>Tribogna</nome><codice>L416</codice></comune>
<comune><nome>Tricarico</nome><codice>L418</codice></comune>
<comune><nome>Tricase</nome><codice>L419</codice></comune>
<comune><nome>Tricerro</nome><codice>L420</codice></comune>
<comune><nome>Tricesimo</nome><codice>L421</codice></comune>
<comune><nome>Trichiana</nome><codice>L422</codice></comune>
<comune><nome>Triei</nome><codice>L423</codice></comune>
<comune><nome>Trieste</nome><codice>L424</codice></comune>
<comune><nome>Triggiano</nome><codice>L425</codice></comune>
<comune><nome>Trigolo</nome><codice>L426</codice></comune>
<comune><nome>Trinità</nome><codice>L427</codice></comune>
<comune><nome>Trinità d'Agultu e Vignola</nome><codice>L428</codice></comune>
<comune><nome>Trinitapoli</nome><codice>B915</codice></comune>
<comune><nome>Trino</nome><codice>L429</codice></comune>
<comune><nome>Triora</nome><codice>L430</codice></comune>
<comune><nome>Tripi</nome><codice>L431</codice></comune>
<comune><nome>Trisobbio</nome><codice>L432</codice></comune>
<comune><nome>Trissino</nome><codice>L433</codice></comune>
<comune><nome>Triuggio</nome><codice>L434</codice></comune>
<comune><nome>Trivento</nome><codice>L435</codice></comune>
<comune><nome>Trivero</nome><codice>L436</codice></comune>
<comune><nome>Trivigliano</nome><codice>L437</codice></comune>
<comune><nome>Trivignano Udinese</nome><codice>L438</codice></comune>
<comune><nome>Trivigno</nome><codice>L439</codice></comune>
<comune><nome>Trivolzio</nome><codice>L440</codice></comune>
<comune><nome>Trodena nel parco naturale</nome><codice>L444</codice></comune>
<comune><nome>Trofarello</nome><codice>L445</codice></comune>
<comune><nome>Troia</nome><codice>L447</codice></comune>
<comune><nome>Troina</nome><codice>L448</codice></comune>
<comune><nome>Tromello</nome><codice>L449</codice></comune>
<comune><nome>Trontano</nome><codice>L450</codice></comune>
<comune><nome>Tronzano Lago Maggiore</nome><codice>A705</codice></comune>
<comune><nome>Tronzano Vercellese</nome><codice>L451</codice></comune>
<comune><nome>Tropea</nome><codice>L452</codice></comune>
<comune><nome>Trovo</nome><codice>L453</codice></comune>
<comune><nome>Truccazzano</nome><codice>L454</codice></comune>
<comune><nome>Tubre</nome><codice>L455</codice></comune>
<comune><nome>Tuenno</nome><codice>L457</codice></comune>
<comune><nome>Tufara</nome><codice>L458</codice></comune>
<comune><nome>Tufillo</nome><codice>L459</codice></comune>
<comune><nome>Tufino</nome><codice>L460</codice></comune>
<comune><nome>Tufo</nome><codice>L461</codice></comune>
<comune><nome>Tuglie</nome><codice>L462</codice></comune>
<comune><nome>Tuili</nome><codice>L463</codice></comune>
<comune><nome>Tula</nome><codice>L464</codice></comune>
<comune><nome>Tuoro sul Trasimeno</nome><codice>L466</codice></comune>
<comune><nome>Turania</nome><codice>G507</codice></comune>
<comune><nome>Turano Lodigiano</nome><codice>L469</codice></comune>
<comune><nome>Turate</nome><codice>L470</codice></comune>
<comune><nome>Turbigo</nome><codice>L471</codice></comune>
<comune><nome>Turi</nome><codice>L472</codice></comune>
<comune><nome>Turri</nome><codice>L473</codice></comune>
<comune><nome>Turriaco</nome><codice>L474</codice></comune>
<comune><nome>Turrivalignani</nome><codice>L475</codice></comune>
<comune><nome>Tursi</nome><codice>L477</codice></comune>
<comune><nome>Tusa</nome><codice>L478</codice></comune>
<comune><nome>Tuscania</nome><codice>L310</codice></comune>
<comune><nome>Ubiale Clanezzo</nome><codice>C789</codice></comune>
<comune><nome>Uboldo</nome><codice>L480</codice></comune>
<comune><nome>Ucria</nome><codice>L482</codice></comune>
<comune><nome>Udine</nome><codice>L483</codice></comune>
<comune><nome>Ugento</nome><codice>L484</codice></comune>
<comune><nome>Uggiano La Chiesa</nome><codice>L485</codice></comune>
<comune><nome>Uggiate-Trevano</nome><codice>L487</codice></comune>
<comune><nome>Ulà Tirso</nome><codice>L488</codice></comune>
<comune><nome>Ulassai</nome><codice>L489</codice></comune>
<comune><nome>Ultimo</nome><codice>L490</codice></comune>
<comune><nome>Umbertide</nome><codice>D786</codice></comune>
<comune><nome>Umbriatico</nome><codice>L492</codice></comune>
<comune><nome>Urago d'Oglio</nome><codice>L494</codice></comune>
<comune><nome>Uras</nome><codice>L496</codice></comune>
<comune><nome>Urbana</nome><codice>L497</codice></comune>
<comune><nome>Urbania</nome><codice>L498</codice></comune>
<comune><nome>Urbe</nome><codice>L499</codice></comune>
<comune><nome>Urbino</nome><codice>L500</codice></comune>
<comune><nome>Urbisaglia</nome><codice>L501</codice></comune>
<comune><nome>Urgnano</nome><codice>L502</codice></comune>
<comune><nome>Uri</nome><codice>L503</codice></comune>
<comune><nome>Ururi</nome><codice>L505</codice></comune>
<comune><nome>Urzulei</nome><codice>L506</codice></comune>
<comune><nome>Uscio</nome><codice>L507</codice></comune>
<comune><nome>Usellus</nome><codice>L508</codice></comune>
<comune><nome>Usini</nome><codice>L509</codice></comune>
<comune><nome>Usmate Velate</nome><codice>L511</codice></comune>
<comune><nome>Ussana</nome><codice>L512</codice></comune>
<comune><nome>Ussaramanna</nome><codice>L513</codice></comune>
<comune><nome>Ussassai</nome><codice>L514</codice></comune>
<comune><nome>Usseaux</nome><codice>L515</codice></comune>
<comune><nome>Usseglio</nome><codice>L516</codice></comune>
<comune><nome>Ussita</nome><codice>L517</codice></comune>
<comune><nome>Ustica</nome><codice>L519</codice></comune>
<comune><nome>Uta</nome><codice>L521</codice></comune>
<comune><nome>Uzzano</nome><codice>L522</codice></comune>
<comune><nome>Vaccarizzo Albanese</nome><codice>L524</codice></comune>
<comune><nome>Vacone</nome><codice>L525</codice></comune>
<comune><nome>Vacri</nome><codice>L526</codice></comune>
<comune><nome>Vadena</nome><codice>L527</codice></comune>
<comune><nome>Vado Ligure</nome><codice>L528</codice></comune>
<comune><nome>Vagli Sotto</nome><codice>L533</codice></comune>
<comune><nome>Vaglia</nome><codice>L529</codice></comune>
<comune><nome>Vaglio Basilicata</nome><codice>L532</codice></comune>
<comune><nome>Vaglio Serra</nome><codice>L531</codice></comune>
<comune><nome>Vaiano</nome><codice>L537</codice></comune>
<comune><nome>Vaiano Cremasco</nome><codice>L535</codice></comune>
<comune><nome>Vaie</nome><codice>L538</codice></comune>
<comune><nome>Vailate</nome><codice>L539</codice></comune>
<comune><nome>Vairano Patenora</nome><codice>L540</codice></comune>
<comune><nome>Vajont</nome><codice>M265</codice></comune>
<comune><nome>Val della Torre</nome><codice>L555</codice></comune>
<comune><nome>Val di Nizza</nome><codice>L562</codice></comune>
<comune><nome>Val di Vizze</nome><codice>L564</codice></comune>
<comune><nome>Val Masino</nome><codice>L638</codice></comune>
<comune><nome>Val Rezzo</nome><codice>H259</codice></comune>
<comune><nome>Valbondione</nome><codice>L544</codice></comune>
<comune><nome>Valbrembo</nome><codice>L545</codice></comune>
<comune><nome>Valbrevenna</nome><codice>L546</codice></comune>
<comune><nome>Valbrona</nome><codice>L547</codice></comune>
<comune><nome>Valda</nome><codice>L550</codice></comune>
<comune><nome>Valdagno</nome><codice>L551</codice></comune>
<comune><nome>Valdaora</nome><codice>L552</codice></comune>
<comune><nome>Valdastico</nome><codice>L554</codice></comune>
<comune><nome>Valdengo</nome><codice>L556</codice></comune>
<comune><nome>Valderice</nome><codice>G319</codice></comune>
<comune><nome>Valdidentro</nome><codice>L557</codice></comune>
<comune><nome>Valdieri</nome><codice>L558</codice></comune>
<comune><nome>Valdina</nome><codice>L561</codice></comune>
<comune><nome>Valdisotto</nome><codice>L563</codice></comune>
<comune><nome>Valdobbiadene</nome><codice>L565</codice></comune>
<comune><nome>Valduggia</nome><codice>L566</codice></comune>
<comune><nome>Valeggio</nome><codice>L568</codice></comune>
<comune><nome>Valeggio sul Mincio</nome><codice>L567</codice></comune>
<comune><nome>Valentano</nome><codice>L569</codice></comune>
<comune><nome>Valenza</nome><codice>L570</codice></comune>
<comune><nome>Valenzano</nome><codice>L571</codice></comune>
<comune><nome>Valera Fratta</nome><codice>L572</codice></comune>
<comune><nome>Valfabbrica</nome><codice>L573</codice></comune>
<comune><nome>Valfenera</nome><codice>L574</codice></comune>
<comune><nome>Valfloriana</nome><codice>L575</codice></comune>
<comune><nome>Valfurva</nome><codice>L576</codice></comune>
<comune><nome>Valganna</nome><codice>L577</codice></comune>
<comune><nome>Valgioie</nome><codice>L578</codice></comune>
<comune><nome>Valgoglio</nome><codice>L579</codice></comune>
<comune><nome>Valgrana</nome><codice>L580</codice></comune>
<comune><nome>Valgreghentino</nome><codice>L581</codice></comune>
<comune><nome>Valgrisenche</nome><codice>L582</codice></comune>
<comune><nome>Valguarnera Caropepe</nome><codice>L583</codice></comune>
<comune><nome>Vallada Agordina</nome><codice>L584</codice></comune>
<comune><nome>Vallanzengo</nome><codice>L586</codice></comune>
<comune><nome>Vallarsa</nome><codice>L588</codice></comune>
<comune><nome>Vallata</nome><codice>L589</codice></comune>
<comune><nome>Valle Agricola</nome><codice>L594</codice></comune>
<comune><nome>Valle Aurina</nome><codice>L595</codice></comune>
<comune><nome>Valle Castellana</nome><codice>L597</codice></comune>
<comune><nome>Valle dell'Angelo</nome><codice>G540</codice></comune>
<comune><nome>Valle di Cadore</nome><codice>L590</codice></comune>
<comune><nome>Valle di Casies</nome><codice>L601</codice></comune>
<comune><nome>Valle di Maddaloni</nome><codice>L591</codice></comune>
<comune><nome>Valle Lomellina</nome><codice>L593</codice></comune>
<comune><nome>Valle Mosso</nome><codice>L606</codice></comune>
<comune><nome>Valle Salimbene</nome><codice>L617</codice></comune>
<comune><nome>Valle San Nicolao</nome><codice>L620</codice></comune>
<comune><nome>Vallebona</nome><codice>L596</codice></comune>
<comune><nome>Vallecorsa</nome><codice>L598</codice></comune>
<comune><nome>Vallecrosia</nome><codice>L599</codice></comune>
<comune><nome>Valledolmo</nome><codice>L603</codice></comune>
<comune><nome>Valledoria</nome><codice>L604</codice></comune>
<comune><nome>Vallefiorita</nome><codice>I322</codice></comune>
<comune><nome>Vallelonga</nome><codice>L607</codice></comune>
<comune><nome>Vallelunga Pratameno</nome><codice>L609</codice></comune>
<comune><nome>Vallemaio</nome><codice>L605</codice></comune>
<comune><nome>Vallepietra</nome><codice>L611</codice></comune>
<comune><nome>Vallerano</nome><codice>L612</codice></comune>
<comune><nome>Vallermosa</nome><codice>L613</codice></comune>
<comune><nome>Vallerotonda</nome><codice>L614</codice></comune>
<comune><nome>Vallesaccarda</nome><codice>L616</codice></comune>
<comune><nome>Valleve</nome><codice>L623</codice></comune>
<comune><nome>Valli del Pasubio</nome><codice>L624</codice></comune>
<comune><nome>Vallinfreda</nome><codice>L625</codice></comune>
<comune><nome>Vallio Terme</nome><codice>L626</codice></comune>
<comune><nome>Vallo della Lucania</nome><codice>L628</codice></comune>
<comune><nome>Vallo di Nera</nome><codice>L627</codice></comune>
<comune><nome>Vallo Torinese</nome><codice>L629</codice></comune>
<comune><nome>Valloriate</nome><codice>L631</codice></comune>
<comune><nome>Valmacca</nome><codice>L633</codice></comune>
<comune><nome>Valmadrera</nome><codice>L634</codice></comune>
<comune><nome>Valmala</nome><codice>L636</codice></comune>
<comune><nome>Valmontone</nome><codice>L639</codice></comune>
<comune><nome>Valmorea</nome><codice>L640</codice></comune>
<comune><nome>Valmozzola</nome><codice>L641</codice></comune>
<comune><nome>Valnegra</nome><codice>L642</codice></comune>
<comune><nome>Valpelline</nome><codice>L643</codice></comune>
<comune><nome>Valperga</nome><codice>L644</codice></comune>
<comune><nome>Valprato Soana</nome><codice>B510</codice></comune>
<comune><nome>Valsavarenche</nome><codice>L647</codice></comune>
<comune><nome>Valsecca</nome><codice>L649</codice></comune>
<comune><nome>Valsinni</nome><codice>D513</codice></comune>
<comune><nome>Valsolda</nome><codice>C936</codice></comune>
<comune><nome>Valstagna</nome><codice>L650</codice></comune>
<comune><nome>Valstrona</nome><codice>L651</codice></comune>
<comune><nome>Valtopina</nome><codice>L653</codice></comune>
<comune><nome>Valtorta</nome><codice>L655</codice></comune>
<comune><nome>Valtournenche</nome><codice>L654</codice></comune>
<comune><nome>Valva</nome><codice>L656</codice></comune>
<comune><nome>Valvasone</nome><codice>L657</codice></comune>
<comune><nome>Valverde</nome><codice>L659</codice></comune>
<comune><nome>Valverde</nome><codice>L658</codice></comune>
<comune><nome>Valvestino</nome><codice>L468</codice></comune>
<comune><nome>Vandoies</nome><codice>L660</codice></comune>
<comune><nome>Vanzaghello</nome><codice>L664</codice></comune>
<comune><nome>Vanzago</nome><codice>L665</codice></comune>
<comune><nome>Vanzone con San Carlo</nome><codice>L666</codice></comune>
<comune><nome>Vaprio d'Adda</nome><codice>L667</codice></comune>
<comune><nome>Vaprio d'Agogna</nome><codice>L668</codice></comune>
<comune><nome>Varallo</nome><codice>L669</codice></comune>
<comune><nome>Varallo Pombia</nome><codice>L670</codice></comune>
<comune><nome>Varano Borghi</nome><codice>L671</codice></comune>
<comune><nome>Varano de' Melegari</nome><codice>L672</codice></comune>
<comune><nome>Varapodio</nome><codice>L673</codice></comune>
<comune><nome>Varazze</nome><codice>L675</codice></comune>
<comune><nome>Varco Sabino</nome><codice>L676</codice></comune>
<comune><nome>Varedo</nome><codice>L677</codice></comune>
<comune><nome>Varena</nome><codice>L678</codice></comune>
<comune><nome>Varenna</nome><codice>L680</codice></comune>
<comune><nome>Varese</nome><codice>L682</codice></comune>
<comune><nome>Varese Ligure</nome><codice>L681</codice></comune>
<comune><nome>Varisella</nome><codice>L685</codice></comune>
<comune><nome>Varmo</nome><codice>L686</codice></comune>
<comune><nome>Varna</nome><codice>L687</codice></comune>
<comune><nome>Varsi</nome><codice>L689</codice></comune>
<comune><nome>Varzi</nome><codice>L690</codice></comune>
<comune><nome>Varzo</nome><codice>L691</codice></comune>
<comune><nome>Vas</nome><codice>L692</codice></comune>
<comune><nome>Vasanello</nome><codice>A701</codice></comune>
<comune><nome>Vasia</nome><codice>L693</codice></comune>
<comune><nome>Vasto</nome><codice>E372</codice></comune>
<comune><nome>Vastogirardi</nome><codice>L696</codice></comune>
<comune><nome>Vattaro</nome><codice>L697</codice></comune>
<comune><nome>Vauda Canavese</nome><codice>L698</codice></comune>
<comune><nome>Vazzano</nome><codice>L699</codice></comune>
<comune><nome>Vazzola</nome><codice>L700</codice></comune>
<comune><nome>Vecchiano</nome><codice>L702</codice></comune>
<comune><nome>Vedano al Lambro</nome><codice>L704</codice></comune>
<comune><nome>Vedano Olona</nome><codice>L703</codice></comune>
<comune><nome>Veddasca</nome><codice>L705</codice></comune>
<comune><nome>Vedelago</nome><codice>L706</codice></comune>
<comune><nome>Vedeseta</nome><codice>L707</codice></comune>
<comune><nome>Veduggio con Colzano</nome><codice>L709</codice></comune>
<comune><nome>Veggiano</nome><codice>L710</codice></comune>
<comune><nome>Veglie</nome><codice>L711</codice></comune>
<comune><nome>Veglio</nome><codice>L712</codice></comune>
<comune><nome>Vejano</nome><codice>L713</codice></comune>
<comune><nome>Veleso</nome><codice>L715</codice></comune>
<comune><nome>Velezzo Lomellina</nome><codice>L716</codice></comune>
<comune><nome>Velletri</nome><codice>L719</codice></comune>
<comune><nome>Vellezzo Bellini</nome><codice>L720</codice></comune>
<comune><nome>Velo d'Astico</nome><codice>L723</codice></comune>
<comune><nome>Velo Veronese</nome><codice>L722</codice></comune>
<comune><nome>Velturno</nome><codice>L724</codice></comune>
<comune><nome>Venafro</nome><codice>L725</codice></comune>
<comune><nome>Venaria Reale</nome><codice>L727</codice></comune>
<comune><nome>Venarotta</nome><codice>L728</codice></comune>
<comune><nome>Venasca</nome><codice>L729</codice></comune>
<comune><nome>Venaus</nome><codice>L726</codice></comune>
<comune><nome>Vendone</nome><codice>L730</codice></comune>
<comune><nome>Vendrogno</nome><codice>L731</codice></comune>
<comune><nome>Venegono Inferiore</nome><codice>L733</codice></comune>
<comune><nome>Venegono Superiore</nome><codice>L734</codice></comune>
<comune><nome>Venetico</nome><codice>L735</codice></comune>
<comune><nome>Venezia</nome><codice>L736</codice></comune>
<comune><nome>Veniano</nome><codice>L737</codice></comune>
<comune><nome>Venosa</nome><codice>L738</codice></comune>
<comune><nome>Venticano</nome><codice>L739</codice></comune>
<comune><nome>Ventimiglia</nome><codice>L741</codice></comune>
<comune><nome>Ventimiglia di Sicilia</nome><codice>L740</codice></comune>
<comune><nome>Ventotene</nome><codice>L742</codice></comune>
<comune><nome>Venzone</nome><codice>L743</codice></comune>
<comune><nome>Verano</nome><codice>L745</codice></comune>
<comune><nome>Verano Brianza</nome><codice>L744</codice></comune>
<comune><nome>Verbania</nome><codice>L746</codice></comune>
<comune><nome>Verbicaro</nome><codice>L747</codice></comune>
<comune><nome>Vercana</nome><codice>L748</codice></comune>
<comune><nome>Verceia</nome><codice>L749</codice></comune>
<comune><nome>Vercelli</nome><codice>L750</codice></comune>
<comune><nome>Vercurago</nome><codice>L751</codice></comune>
<comune><nome>Verdellino</nome><codice>L752</codice></comune>
<comune><nome>Verdello</nome><codice>L753</codice></comune>
<comune><nome>Verderio Inferiore</nome><codice>L755</codice></comune>
<comune><nome>Verderio Superiore</nome><codice>L756</codice></comune>
<comune><nome>Verduno</nome><codice>L758</codice></comune>
<comune><nome>Vergato</nome><codice>L762</codice></comune>
<comune><nome>Vergemoli</nome><codice>L763</codice></comune>
<comune><nome>Verghereto</nome><codice>L764</codice></comune>
<comune><nome>Vergiate</nome><codice>L765</codice></comune>
<comune><nome>Vermezzo</nome><codice>L768</codice></comune>
<comune><nome>Vermiglio</nome><codice>L769</codice></comune>
<comune><nome>Vernante</nome><codice>L771</codice></comune>
<comune><nome>Vernasca</nome><codice>L772</codice></comune>
<comune><nome>Vernate</nome><codice>L773</codice></comune>
<comune><nome>Vernazza</nome><codice>L774</codice></comune>
<comune><nome>Vernio</nome><codice>L775</codice></comune>
<comune><nome>Vernole</nome><codice>L776</codice></comune>
<comune><nome>Verolanuova</nome><codice>L777</codice></comune>
<comune><nome>Verolavecchia</nome><codice>L778</codice></comune>
<comune><nome>Verolengo</nome><codice>L779</codice></comune>
<comune><nome>Veroli</nome><codice>L780</codice></comune>
<comune><nome>Verona</nome><codice>L781</codice></comune>
<comune><nome>Veronella</nome><codice>D193</codice></comune>
<comune><nome>Verrayes</nome><codice>L783</codice></comune>
<comune><nome>Verrès</nome><codice>C282</codice></comune>
<comune><nome>Verretto</nome><codice>L784</codice></comune>
<comune><nome>Verrone</nome><codice>L785</codice></comune>
<comune><nome>Verrua Po</nome><codice>L788</codice></comune>
<comune><nome>Verrua Savoia</nome><codice>L787</codice></comune>
<comune><nome>Vertemate con Minoprio</nome><codice>L792</codice></comune>
<comune><nome>Vertova</nome><codice>L795</codice></comune>
<comune><nome>Verucchio</nome><codice>L797</codice></comune>
<comune><nome>Veruno</nome><codice>L798</codice></comune>
<comune><nome>Vervio</nome><codice>L799</codice></comune>
<comune><nome>Vervò</nome><codice>L800</codice></comune>
<comune><nome>Verzegnis</nome><codice>L801</codice></comune>
<comune><nome>Verzino</nome><codice>L802</codice></comune>
<comune><nome>Verzuolo</nome><codice>L804</codice></comune>
<comune><nome>Vescovana</nome><codice>L805</codice></comune>
<comune><nome>Vescovato</nome><codice>L806</codice></comune>
<comune><nome>Vesime</nome><codice>L807</codice></comune>
<comune><nome>Vespolate</nome><codice>L808</codice></comune>
<comune><nome>Vessalico</nome><codice>L809</codice></comune>
<comune><nome>Vestenanova</nome><codice>L810</codice></comune>
<comune><nome>Vestignè</nome><codice>L811</codice></comune>
<comune><nome>Vestone</nome><codice>L812</codice></comune>
<comune><nome>Vestreno</nome><codice>L813</codice></comune>
<comune><nome>Vetralla</nome><codice>L814</codice></comune>
<comune><nome>Vetto</nome><codice>L815</codice></comune>
<comune><nome>Vezza d'Alba</nome><codice>L817</codice></comune>
<comune><nome>Vezza d'Oglio</nome><codice>L816</codice></comune>
<comune><nome>Vezzano</nome><codice>L821</codice></comune>
<comune><nome>Vezzano Ligure</nome><codice>L819</codice></comune>
<comune><nome>Vezzano sul Crostolo</nome><codice>L820</codice></comune>
<comune><nome>Vezzi Portio</nome><codice>L823</codice></comune>
<comune><nome>Viadana</nome><codice>L826</codice></comune>
<comune><nome>Viadanica</nome><codice>L827</codice></comune>
<comune><nome>Viagrande</nome><codice>L828</codice></comune>
<comune><nome>Viale</nome><codice>L829</codice></comune>
<comune><nome>Vialfrè</nome><codice>L830</codice></comune>
<comune><nome>Viano</nome><codice>L831</codice></comune>
<comune><nome>Viareggio</nome><codice>L833</codice></comune>
<comune><nome>Viarigi</nome><codice>L834</codice></comune>
<comune><nome>Vibo Valentia</nome><codice>F537</codice></comune>
<comune><nome>Vibonati</nome><codice>L835</codice></comune>
<comune><nome>Vicalvi</nome><codice>L836</codice></comune>
<comune><nome>Vicari</nome><codice>L837</codice></comune>
<comune><nome>Vicchio</nome><codice>L838</codice></comune>
<comune><nome>Vicenza</nome><codice>L840</codice></comune>
<comune><nome>Vico Canavese</nome><codice>L548</codice></comune>
<comune><nome>Vico del Gargano</nome><codice>L842</codice></comune>
<comune><nome>Vico Equense</nome><codice>L845</codice></comune>
<comune><nome>Vico nel Lazio</nome><codice>L843</codice></comune>
<comune><nome>Vicoforte</nome><codice>L841</codice></comune>
<comune><nome>Vicoli</nome><codice>L846</codice></comune>
<comune><nome>Vicolungo</nome><codice>L847</codice></comune>
<comune><nome>Vicopisano</nome><codice>L850</codice></comune>
<comune><nome>Vicovaro</nome><codice>L851</codice></comune>
<comune><nome>Viddalba</nome><codice>M259</codice></comune>
<comune><nome>Vidigulfo</nome><codice>L854</codice></comune>
<comune><nome>Vidor</nome><codice>L856</codice></comune>
<comune><nome>Vidracco</nome><codice>L857</codice></comune>
<comune><nome>Vieste</nome><codice>L858</codice></comune>
<comune><nome>Vietri di Potenza</nome><codice>L859</codice></comune>
<comune><nome>Vietri sul Mare</nome><codice>L860</codice></comune>
<comune><nome>Viganella</nome><codice>L864</codice></comune>
<comune><nome>Viganò</nome><codice>L866</codice></comune>
<comune><nome>Vigano San Martino</nome><codice>L865</codice></comune>
<comune><nome>Vigarano Mainarda</nome><codice>L868</codice></comune>
<comune><nome>Vigasio</nome><codice>L869</codice></comune>
<comune><nome>Vigevano</nome><codice>L872</codice></comune>
<comune><nome>Viggianello</nome><codice>L873</codice></comune>
<comune><nome>Viggiano</nome><codice>L874</codice></comune>
<comune><nome>Viggiù</nome><codice>L876</codice></comune>
<comune><nome>Vighizzolo d'Este</nome><codice>L878</codice></comune>
<comune><nome>Vigliano Biellese</nome><codice>L880</codice></comune>
<comune><nome>Vigliano d'Asti</nome><codice>L879</codice></comune>
<comune><nome>Vignale Monferrato</nome><codice>L881</codice></comune>
<comune><nome>Vignanello</nome><codice>L882</codice></comune>
<comune><nome>Vignate</nome><codice>L883</codice></comune>
<comune><nome>Vignola</nome><codice>L885</codice></comune>
<comune><nome>Vignola-Falesina</nome><codice>L886</codice></comune>
<comune><nome>Vignole Borbera</nome><codice>L887</codice></comune>
<comune><nome>Vignolo</nome><codice>L888</codice></comune>
<comune><nome>Vignone</nome><codice>L889</codice></comune>
<comune><nome>Vigo di Cadore</nome><codice>L890</codice></comune>
<comune><nome>Vigo di Fassa</nome><codice>L893</codice></comune>
<comune><nome>Vigo Rendena</nome><codice>L903</codice></comune>
<comune><nome>Vigodarzere</nome><codice>L892</codice></comune>
<comune><nome>Vigolo</nome><codice>L894</codice></comune>
<comune><nome>Vigolo Vattaro</nome><codice>L896</codice></comune>
<comune><nome>Vigolzone</nome><codice>L897</codice></comune>
<comune><nome>Vigone</nome><codice>L898</codice></comune>
<comune><nome>Vigonovo</nome><codice>L899</codice></comune>
<comune><nome>Vigonza</nome><codice>L900</codice></comune>
<comune><nome>Viguzzolo</nome><codice>L904</codice></comune>
<comune><nome>Villa Agnedo</nome><codice>L910</codice></comune>
<comune><nome>Villa Bartolomea</nome><codice>L912</codice></comune>
<comune><nome>Villa Basilica</nome><codice>L913</codice></comune>
<comune><nome>Villa Biscossi</nome><codice>L917</codice></comune>
<comune><nome>Villa Carcina</nome><codice>L919</codice></comune>
<comune><nome>Villa Castelli</nome><codice>L920</codice></comune>
<comune><nome>Villa Celiera</nome><codice>L922</codice></comune>
<comune><nome>Villa Collemandina</nome><codice>L926</codice></comune>
<comune><nome>Villa Cortese</nome><codice>L928</codice></comune>
<comune><nome>Villa d'Adda</nome><codice>L929</codice></comune>
<comune><nome>Villa d'Almè</nome><codice>A215</codice></comune>
<comune><nome>Villa del Bosco</nome><codice>L933</codice></comune>
<comune><nome>Villa del Conte</nome><codice>L934</codice></comune>
<comune><nome>Villa di Briano</nome><codice>D801</codice></comune>
<comune><nome>Villa di Chiavenna</nome><codice>L907</codice></comune>
<comune><nome>Villa di Serio</nome><codice>L936</codice></comune>
<comune><nome>Villa di Tirano</nome><codice>L908</codice></comune>
<comune><nome>Villa d'Ogna</nome><codice>L938</codice></comune>
<comune><nome>Villa Estense</nome><codice>L937</codice></comune>
<comune><nome>Villa Faraldi</nome><codice>L943</codice></comune>
<comune><nome>Villa Guardia</nome><codice>L956</codice></comune>
<comune><nome>Villa Lagarina</nome><codice>L957</codice></comune>
<comune><nome>Villa Latina</nome><codice>A081</codice></comune>
<comune><nome>Villa Literno</nome><codice>L844</codice></comune>
<comune><nome>Villa Minozzo</nome><codice>L969</codice></comune>
<comune><nome>Villa Poma</nome><codice>F804</codice></comune>
<comune><nome>Villa Rendena</nome><codice>M006</codice></comune>
<comune><nome>Villa San Giovanni</nome><codice>M018</codice></comune>
<comune><nome>Villa San Giovanni in Tuscia</nome><codice>H913</codice></comune>
<comune><nome>Villa San Pietro</nome><codice>I118</codice></comune>
<comune><nome>Villa San Secondo</nome><codice>M019</codice></comune>
<comune><nome>Villa Santa Lucia</nome><codice>L905</codice></comune>
<comune><nome>Villa Santa Lucia degli Abruzzi</nome><codice>M021</codice></comune>
<comune><nome>Villa Santa Maria</nome><codice>M022</codice></comune>
<comune><nome>Villa Sant'Angelo</nome><codice>M023</codice></comune>
<comune><nome>Villa Sant'Antonio</nome><codice>I298</codice></comune>
<comune><nome>Villa Santina</nome><codice>L909</codice></comune>
<comune><nome>Villa Santo Stefano</nome><codice>I364</codice></comune>
<comune><nome>Villa Verde</nome><codice>A609</codice></comune>
<comune><nome>Villa Vicentina</nome><codice>M034</codice></comune>
<comune><nome>Villabassa</nome><codice>L915</codice></comune>
<comune><nome>Villabate</nome><codice>L916</codice></comune>
<comune><nome>Villachiara</nome><codice>L923</codice></comune>
<comune><nome>Villacidro</nome><codice>L924</codice></comune>
<comune><nome>Villadeati</nome><codice>L931</codice></comune>
<comune><nome>Villadose</nome><codice>L939</codice></comune>
<comune><nome>Villadossola</nome><codice>L906</codice></comune>
<comune><nome>Villafalletto</nome><codice>L942</codice></comune>
<comune><nome>Villafranca d'Asti</nome><codice>L945</codice></comune>
<comune><nome>Villafranca di Verona</nome><codice>L949</codice></comune>
<comune><nome>Villafranca in Lunigiana</nome><codice>L946</codice></comune>
<comune><nome>Villafranca Padovana</nome><codice>L947</codice></comune>
<comune><nome>Villafranca Piemonte</nome><codice>L948</codice></comune>
<comune><nome>Villafranca Sicula</nome><codice>L944</codice></comune>
<comune><nome>Villafranca Tirrena</nome><codice>L950</codice></comune>
<comune><nome>Villafrati</nome><codice>L951</codice></comune>
<comune><nome>Villaga</nome><codice>L952</codice></comune>
<comune><nome>Villagrande Strisaili</nome><codice>L953</codice></comune>
<comune><nome>Villalago</nome><codice>L958</codice></comune>
<comune><nome>Villalba</nome><codice>L959</codice></comune>
<comune><nome>Villalfonsina</nome><codice>L961</codice></comune>
<comune><nome>Villalvernia</nome><codice>L963</codice></comune>
<comune><nome>Villamagna</nome><codice>L964</codice></comune>
<comune><nome>Villamaina</nome><codice>L965</codice></comune>
<comune><nome>Villamar</nome><codice>L966</codice></comune>
<comune><nome>Villamarzana</nome><codice>L967</codice></comune>
<comune><nome>Villamassargia</nome><codice>L968</codice></comune>
<comune><nome>Villamiroglio</nome><codice>L970</codice></comune>
<comune><nome>Villandro</nome><codice>L971</codice></comune>
<comune><nome>Villanova Biellese</nome><codice>L978</codice></comune>
<comune><nome>Villanova Canavese</nome><codice>L982</codice></comune>
<comune><nome>Villanova d'Albenga</nome><codice>L975</codice></comune>
<comune><nome>Villanova d'Ardenghi</nome><codice>L983</codice></comune>
<comune><nome>Villanova d'Asti</nome><codice>L984</codice></comune>
<comune><nome>Villanova del Battista</nome><codice>L973</codice></comune>
<comune><nome>Villanova del Ghebbo</nome><codice>L985</codice></comune>
<comune><nome>Villanova del Sillaro</nome><codice>L977</codice></comune>
<comune><nome>Villanova di Camposampiero</nome><codice>L979</codice></comune>
<comune><nome>Villanova Marchesana</nome><codice>L988</codice></comune>
<comune><nome>Villanova Mondovì</nome><codice>L974</codice></comune>
<comune><nome>Villanova Monferrato</nome><codice>L972</codice></comune>
<comune><nome>Villanova Monteleone</nome><codice>L989</codice></comune>
<comune><nome>Villanova Solaro</nome><codice>L990</codice></comune>
<comune><nome>Villanova sull'Arda</nome><codice>L980</codice></comune>
<comune><nome>Villanova Truschedu</nome><codice>L991</codice></comune>
<comune><nome>Villanova Tulo</nome><codice>L992</codice></comune>
<comune><nome>Villanovaforru</nome><codice>L986</codice></comune>
<comune><nome>Villanovafranca</nome><codice>L987</codice></comune>
<comune><nome>Villanterio</nome><codice>L994</codice></comune>
<comune><nome>Villanuova sul Clisi</nome><codice>L995</codice></comune>
<comune><nome>Villaperuccio</nome><codice>M278</codice></comune>
<comune><nome>Villapiana</nome><codice>B903</codice></comune>
<comune><nome>Villaputzu</nome><codice>L998</codice></comune>
<comune><nome>Villar Dora</nome><codice>L999</codice></comune>
<comune><nome>Villar Focchiardo</nome><codice>M007</codice></comune>
<comune><nome>Villar Pellice</nome><codice>M013</codice></comune>
<comune><nome>Villar Perosa</nome><codice>M014</codice></comune>
<comune><nome>Villar San Costanzo</nome><codice>M015</codice></comune>
<comune><nome>Villarbasse</nome><codice>M002</codice></comune>
<comune><nome>Villarboit</nome><codice>M003</codice></comune>
<comune><nome>Villareggia</nome><codice>M004</codice></comune>
<comune><nome>Villaricca</nome><codice>G309</codice></comune>
<comune><nome>Villaromagnano</nome><codice>M009</codice></comune>
<comune><nome>Villarosa</nome><codice>M011</codice></comune>
<comune><nome>Villasalto</nome><codice>M016</codice></comune>
<comune><nome>Villasanta</nome><codice>M017</codice></comune>
<comune><nome>Villasimius</nome><codice>B738</codice></comune>
<comune><nome>Villasor</nome><codice>M025</codice></comune>
<comune><nome>Villaspeciosa</nome><codice>M026</codice></comune>
<comune><nome>Villastellone</nome><codice>M027</codice></comune>
<comune><nome>Villata</nome><codice>M028</codice></comune>
<comune><nome>Villaurbana</nome><codice>M030</codice></comune>
<comune><nome>Villavallelonga</nome><codice>M031</codice></comune>
<comune><nome>Villaverla</nome><codice>M032</codice></comune>
<comune><nome>Villeneuve</nome><codice>L981</codice></comune>
<comune><nome>Villesse</nome><codice>M043</codice></comune>
<comune><nome>Villetta Barrea</nome><codice>M041</codice></comune>
<comune><nome>Villette</nome><codice>M042</codice></comune>
<comune><nome>Villimpenta</nome><codice>M044</codice></comune>
<comune><nome>Villongo</nome><codice>M045</codice></comune>
<comune><nome>Villorba</nome><codice>M048</codice></comune>
<comune><nome>Vilminore di Scalve</nome><codice>M050</codice></comune>
<comune><nome>Vimercate</nome><codice>M052</codice></comune>
<comune><nome>Vimodrone</nome><codice>M053</codice></comune>
<comune><nome>Vinadio</nome><codice>M055</codice></comune>
<comune><nome>Vinchiaturo</nome><codice>M057</codice></comune>
<comune><nome>Vinchio</nome><codice>M058</codice></comune>
<comune><nome>Vinci</nome><codice>M059</codice></comune>
<comune><nome>Vinovo</nome><codice>M060</codice></comune>
<comune><nome>Vinzaglio</nome><codice>M062</codice></comune>
<comune><nome>Viola</nome><codice>M063</codice></comune>
<comune><nome>Vione</nome><codice>M065</codice></comune>
<comune><nome>Vipiteno</nome><codice>M067</codice></comune>
<comune><nome>Virgilio</nome><codice>H123</codice></comune>
<comune><nome>Virle Piemonte</nome><codice>M069</codice></comune>
<comune><nome>Visano</nome><codice>M070</codice></comune>
<comune><nome>Vische</nome><codice>M071</codice></comune>
<comune><nome>Visciano</nome><codice>M072</codice></comune>
<comune><nome>Visco</nome><codice>M073</codice></comune>
<comune><nome>Visone</nome><codice>M077</codice></comune>
<comune><nome>Visso</nome><codice>M078</codice></comune>
<comune><nome>Vistarino</nome><codice>M079</codice></comune>
<comune><nome>Vistrorio</nome><codice>M080</codice></comune>
<comune><nome>Vita</nome><codice>M081</codice></comune>
<comune><nome>Viterbo</nome><codice>M082</codice></comune>
<comune><nome>Viticuso</nome><codice>M083</codice></comune>
<comune><nome>Vito d'Asio</nome><codice>M085</codice></comune>
<comune><nome>Vitorchiano</nome><codice>M086</codice></comune>
<comune><nome>Vittoria</nome><codice>M088</codice></comune>
<comune><nome>Vittorio Veneto</nome><codice>M089</codice></comune>
<comune><nome>Vittorito</nome><codice>M090</codice></comune>
<comune><nome>Vittuone</nome><codice>M091</codice></comune>
<comune><nome>Vitulano</nome><codice>M093</codice></comune>
<comune><nome>Vitulazio</nome><codice>M092</codice></comune>
<comune><nome>Viù</nome><codice>M094</codice></comune>
<comune><nome>Vivaro</nome><codice>M096</codice></comune>
<comune><nome>Vivaro Romano</nome><codice>M095</codice></comune>
<comune><nome>Viverone</nome><codice>M098</codice></comune>
<comune><nome>Vizzini</nome><codice>M100</codice></comune>
<comune><nome>Vizzola Ticino</nome><codice>M101</codice></comune>
<comune><nome>Vizzolo Predabissi</nome><codice>M102</codice></comune>
<comune><nome>Vo'</nome><codice>M103</codice></comune>
<comune><nome>Vobarno</nome><codice>M104</codice></comune>
<comune><nome>Vobbia</nome><codice>M105</codice></comune>
<comune><nome>Vocca</nome><codice>M106</codice></comune>
<comune><nome>Vodo Cadore</nome><codice>M108</codice></comune>
<comune><nome>Voghera</nome><codice>M109</codice></comune>
<comune><nome>Voghiera</nome><codice>M110</codice></comune>
<comune><nome>Vogogna</nome><codice>M111</codice></comune>
<comune><nome>Volano</nome><codice>M113</codice></comune>
<comune><nome>Volla</nome><codice>M115</codice></comune>
<comune><nome>Volongo</nome><codice>M116</codice></comune>
<comune><nome>Volpago del Montello</nome><codice>M118</codice></comune>
<comune><nome>Volpara</nome><codice>M119</codice></comune>
<comune><nome>Volpedo</nome><codice>M120</codice></comune>
<comune><nome>Volpeglino</nome><codice>M121</codice></comune>
<comune><nome>Volpiano</nome><codice>M122</codice></comune>
<comune><nome>Volta Mantovana</nome><codice>M125</codice></comune>
<comune><nome>Voltaggio</nome><codice>M123</codice></comune>
<comune><nome>Voltago Agordino</nome><codice>M124</codice></comune>
<comune><nome>Volterra</nome><codice>M126</codice></comune>
<comune><nome>Voltido</nome><codice>M127</codice></comune>
<comune><nome>Volturara Appula</nome><codice>M131</codice></comune>
<comune><nome>Volturara Irpina</nome><codice>M130</codice></comune>
<comune><nome>Volturino</nome><codice>M132</codice></comune>
<comune><nome>Volvera</nome><codice>M133</codice></comune>
<comune><nome>Vottignasco</nome><codice>M136</codice></comune>
<comune><nome>Zaccanopoli</nome><codice>M138</codice></comune>
<comune><nome>Zafferana Etnea</nome><codice>M139</codice></comune>
<comune><nome>Zagarise</nome><codice>M140</codice></comune>
<comune><nome>Zagarolo</nome><codice>M141</codice></comune>
<comune><nome>Zambana</nome><codice>M142</codice></comune>
<comune><nome>Zambrone</nome><codice>M143</codice></comune>
<comune><nome>Zandobbio</nome><codice>M144</codice></comune>
<comune><nome>Zanè</nome><codice>M145</codice></comune>
<comune><nome>Zanica</nome><codice>M147</codice></comune>
<comune><nome>Zapponeta</nome><codice>M267</codice></comune>
<comune><nome>Zavattarello</nome><codice>M150</codice></comune>
<comune><nome>Zeccone</nome><codice>M152</codice></comune>
<comune><nome>Zeddiani</nome><codice>M153</codice></comune>
<comune><nome>Zelbio</nome><codice>M156</codice></comune>
<comune><nome>Zelo Buon Persico</nome><codice>M158</codice></comune>
<comune><nome>Zelo Surrigone</nome><codice>M160</codice></comune>
<comune><nome>Zeme</nome><codice>M161</codice></comune>
<comune><nome>Zenevredo</nome><codice>M162</codice></comune>
<comune><nome>Zenson di Piave</nome><codice>M163</codice></comune>
<comune><nome>Zerba</nome><codice>M165</codice></comune>
<comune><nome>Zerbo</nome><codice>M166</codice></comune>
<comune><nome>Zerbolò</nome><codice>M167</codice></comune>
<comune><nome>Zerfaliu</nome><codice>M168</codice></comune>
<comune><nome>Zeri</nome><codice>M169</codice></comune>
<comune><nome>Zermeghedo</nome><codice>M170</codice></comune>
<comune><nome>Zero Branco</nome><codice>M171</codice></comune>
<comune><nome>Zevio</nome><codice>M172</codice></comune>
<comune><nome>Ziano di Fiemme</nome><codice>M173</codice></comune>
<comune><nome>Ziano Piacentino</nome><codice>L848</codice></comune>
<comune><nome>Zibello</nome><codice>M174</codice></comune>
<comune><nome>Zibido San Giacomo</nome><codice>M176</codice></comune>
<comune><nome>Zignago</nome><codice>M177</codice></comune>
<comune><nome>Zimella</nome><codice>M178</codice></comune>
<comune><nome>Zimone</nome><codice>M179</codice></comune>
<comune><nome>Zinasco</nome><codice>M180</codice></comune>
<comune><nome>Zoagli</nome><codice>M182</codice></comune>
<comune><nome>Zocca</nome><codice>M183</codice></comune>
<comune><nome>Zogno</nome><codice>M184</codice></comune>
<comune><nome>Zola Predosa</nome><codice>M185</codice></comune>
<comune><nome>Zoldo Alto</nome><codice>I345</codice></comune>
<comune><nome>Zollino</nome><codice>M187</codice></comune>
<comune><nome>Zone</nome><codice>M188</codice></comune>
<comune><nome>Zoppè di Cadore</nome><codice>M189</codice></comune>
<comune><nome>Zoppola</nome><codice>M190</codice></comune>
<comune><nome>Zovencedo</nome><codice>M194</codice></comune>
<comune><nome>Zubiena</nome><codice>M196</codice></comune>
<comune><nome>Zuccarello</nome><codice>M197</codice></comune>
<comune><nome>Zuclo</nome><codice>M198</codice></comune>
<comune><nome>Zugliano</nome><codice>M199</codice></comune>
<comune><nome>Zuglio</nome><codice>M200</codice></comune>
<comune><nome>Zumaglia</nome><codice>M201</codice></comune>
<comune><nome>Zumpano</nome><codice>M202</codice></comune>
<comune><nome>Zungoli</nome><codice>M203</codice></comune>
<comune><nome>Zungri</nome><codice>M204</codice></comune>
</tabellacomuni>

"
End Module
