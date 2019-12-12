using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Attributes

    // make game manager public static so can access this from other scripts
    public static GameManager gm;

    #region Estados de Juego

    /// <summary>
    /// Estados del Juego Globales, por encima de todo.
    /// </summary>
    public enum _GAME_STATES { Playing, BeatLevel, Death, GameOver };

    /// <summary>
    /// Estados del Juego particulares: durante el ""gameState"": PLAYING.
    /// </summary>
    public enum _GAME_STATES_WHEN_PLAYING { InicializacionFinalVariables, PreparandoVariablesParaMiTurnoPartida, /*EsperandoPorAnimacionPeligroDeTerminarJuego,*/ /*EsperandoPorGUIRoundNumero, PorChutar, Chutando, CelebracionGol, CelebracionNoEsGol, AnimacionChutadorGol, AnimacionChutadorNoEsGol, AnimacionPorteroParadaExitosa, AnimacionPorteroFallo, AnimacionInicioSuddenDeath*/ /* NO SE USARÁN:  , AntesDePortear, Porteando */ };


    /// <summary>
    /// Estado Global del Juego.
    /// </summary>
    [Tooltip("Estado Global del Juego.")]
    public _GAME_STATES _mainGameState = _GAME_STATES.Playing;

    /// <summary>
    /// Estado Particular del Juego en PLAYING.
    /// </summary>
    [Tooltip("Estado Particular del Juego en PLAYING.")]
    public _GAME_STATES_WHEN_PLAYING _gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida;


    ///// <summary>
    ///// ESTADO: Esta la App pausada? O no?
    ///// </summary>
    //[Tooltip("ESTADO: Esta la App pausada? O no?")]
    //public bool _appEstaPausada = false;

    ///// <summary>
    ///// Si es TRUE: Se Activará INMEDIATAMENTE un CAMBIO DE ESTADO: Pausar/Despausar.
    ///// </summary>
    //[Tooltip("Si es TRUE: Se Activará INMEDIATAMENTE un CAMBIO DE ESTADO: Pausar/Despausar.")]
    //public bool _appCambiarDeEstadoTogglePauseODespause = false;

    #endregion Estados de Juego





    /// Buttons to restart the game to Level One
    [Tooltip("Buttons to restart the game to Level One")]
    public GameObject restartGameButtons;

    #endregion Attributes


    #region Methods

    // Awake is called before the Start
    void Awake()
    {
        // get a reference to the GameManager component for use by other scripts
        if (gm == null)
        {
            gm = this.gameObject.GetComponent<GameManager>();

        }//End if (gm == null)

    }//End Awake Method


    // Start is called before the first frame update
    void Start()
    {
        
    }//End Start


    // Update is called once per frame
    void Update()
    {

        switch (this._mainGameState)
        {

            // Estado de JUGAR:
            //
            case _GAME_STATES.Playing:


                // Al estar JUGANDO casos:
                //
                switch (this._gameStateWhenPlaying)
                {

                    case _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables:

                        // Setear la variable de ESTADO al siguiente:
                        //
                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida;

                        break;


                    case _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaMiTurnoPartida:


                        // Capture Mouse Input Click:
                        //
                        if (Input.GetMouseButtonDown(0))
                        {
                            Debug.Log("Pressed primary button.");

                        }//End if (Input.GetMouseButtonDown(0))

                        break;


                    default:

                        Debug.LogError("ESTADO NO ESPERADO (para switch (this._gameStateWhenPlaying)), EN GameManager!");

                        break;

                }//End

                break;


            case _GAME_STATES.BeatLevel:


                break;


            case _GAME_STATES.Death:


                break;


            case _GAME_STATES.GameOver:


                break;


            default:

                Debug.LogError("ESTADO NO ESPERADO (para switch (this._mainGameState)), EN GameManager!");

                break;

        }//End switch (this._mainGameState)

    }//End Update


    #region **************************My Custom Methods*******************************


    #endregion **************************My Custom Methods*******************************

    #endregion Methods
}
