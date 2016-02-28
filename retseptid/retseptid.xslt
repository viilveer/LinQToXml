<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:template match="/">
    <html>
      <body>
        Retseptid:
        <xsl:for-each select="/retseptid/retsept">
          <ul>
           
                  <li>
                    <xsl:value-of select="@toidunimi"/>
                    <ul>
                      <xsl:for-each select="koostisosa">
                        <li>
                          <xsl:value-of select="@nimi"/>
                          <xsl:text> - </xsl:text>
                          <xsl:value-of select="@kogus"/>
                          <xsl:variable name="comment" select="@kommentaar" />
                          <xsl:if test="$comment != ''">
                            <xsl:text> (</xsl:text>
                            <xsl:value-of select="@kommentaar"/>
                            <xsl:text>)</xsl:text>
                          </xsl:if>
                         
                        </li>
                      </xsl:for-each>
                    </ul>
                  </li>
          </ul>


        </xsl:for-each>

      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
