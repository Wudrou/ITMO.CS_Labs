USING SYSTEM;
USING SYSTEM.IO;
USING SYSTEM.COLLECTIONS.GENERIC;
USING SYSTEM.LINQ;
USING SYSTEM.TEXT;
USING SYSTEM.THREADING.TASKS;

NAMESPACE L7._3_COPYFILEUPPER
{
    CLASS COPYFILEUPPER
    {
        STATIC VOID MAIN(STRING[] ARGS)
        {
            //STREAMREADER SRFROM;
            //STREAMWRITER SWTO;

            CONSOLE.WRITELINE("COPY FROM:");
            STRING SFROM = CONSOLE.READLINE();

            CONSOLE.WRITELINE("COPY TO:");
            STRING STO = CONSOLE.READLINE();

            CONSOLE.WRITELINE("COPY FROM {0} TO {1}", SFROM, STO);

            TRY
            {
                STREAMREADER SRFROM = NEW STREAMREADER(SFROM);
                STREAMWRITER SWTO = NEW STREAMWRITER(STO);

                WHILE (SRFROM.PEEK() !=-1)
                {
                    STRING SBUFFER = SRFROM.READLINE();
                    SBUFFER = SBUFFER.TOUPPER();
                    SWTO.WRITELINE(SBUFFER);
                }

                SWTO.CLOSE();
                SRFROM.CLOSE();
            }
            CATCH(FILENOTFOUNDEXCEPTION)
            {
                CONSOLE.WRITELINE("INPUT FILE NOT FOUND");
            }
            CATCH(EXCEPTION E)
            {
                CONSOLE.WRITELINE("UNEXPECTED EXCEPTION");
                CONSOLE.WRITELINE(E.TOSTRING());
            }

            CONSOLE.READKEY();
        }
    }
}
