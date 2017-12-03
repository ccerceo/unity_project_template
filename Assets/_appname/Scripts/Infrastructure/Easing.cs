﻿using UnityEngine;

namespace Polycube.Infrastructure
{
    public enum EasingEquation
    {
        Linear,
        QuadEaseOut, QuadEaseIn, QuadEaseInOut, QuadEaseOutIn,
        ExpoEaseOut, ExpoEaseIn, ExpoEaseInOut, ExpoEaseOutIn,
        CubicEaseOut, CubicEaseIn, CubicEaseInOut, CubicEaseOutIn,
        QuartEaseOut, QuartEaseIn, QuartEaseInOut, QuartEaseOutIn,
        QuintEaseOut, QuintEaseIn, QuintEaseInOut, QuintEaseOutIn,
        CircEaseOut, CircEaseIn, CircEaseInOut, CircEaseOutIn,
        SineEaseOut, SineEaseIn, SineEaseInOut, SineEaseOutIn,
        ElasticEaseOut, ElasticEaseIn, ElasticEaseInOut, ElasticEaseOutIn,
        BounceEaseOut, BounceEaseIn, BounceEaseInOut, BounceEaseOutIn,
        BackEaseOut, BackEaseIn, BackEaseInOut, BackEaseOutIn
    }

    public class Easing
    {
        public static float GetEaseProgress(EasingEquation ease_type, float linear_progress)
        {
            switch(ease_type)
            {
            case EasingEquation.Linear:
                return linear_progress;
            case EasingEquation.BackEaseIn:
                return Easing.BackEaseIn(linear_progress, 0, 1, 1);

            case EasingEquation.BackEaseInOut:
                return Easing.BackEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.BackEaseOut:
                return Easing.BackEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.BackEaseOutIn:
                return Easing.BackEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.BounceEaseIn:
                return Easing.BounceEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.BounceEaseInOut:
                return Easing.BounceEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.BounceEaseOut:
                return Easing.BounceEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.BounceEaseOutIn:
                return Easing.BounceEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.CircEaseIn:
                return Easing.CircEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.CircEaseInOut:
                return Easing.CircEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.CircEaseOut:
                return Easing.CircEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.CircEaseOutIn:
                return Easing.CircEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.CubicEaseIn:
                return Easing.CubicEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.CubicEaseInOut:
                return Easing.CubicEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.CubicEaseOut:
                return Easing.CubicEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.CubicEaseOutIn:
                return Easing.CubicEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.ElasticEaseIn:
                return Easing.ElasticEaseIn(linear_progress, 0, 1, 1);

            case EasingEquation.ElasticEaseInOut:
                return Easing.ElasticEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.ElasticEaseOut:
                return Easing.ElasticEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.ElasticEaseOutIn:
                return Easing.ElasticEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.ExpoEaseIn:
                return Easing.ExpoEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.ExpoEaseInOut:
                return Easing.ExpoEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.ExpoEaseOut:
                return Easing.ExpoEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.ExpoEaseOutIn:
                return Easing.ExpoEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.QuadEaseIn:
                return Easing.QuadEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.QuadEaseInOut:
                return Easing.QuadEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.QuadEaseOut:
                return Easing.QuadEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.QuadEaseOutIn:
                return Easing.QuadEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.QuartEaseIn:
                return Easing.QuartEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.QuartEaseInOut:
                return Easing.QuartEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.QuartEaseOut:
                return Easing.QuartEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.QuartEaseOutIn:
                return Easing.QuartEaseOutIn(linear_progress, 0, 1, 1);
            case EasingEquation.QuintEaseIn:
                return Easing.QuintEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.QuintEaseInOut:
                return Easing.QuintEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.QuintEaseOut:
                return Easing.QuintEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.QuintEaseOutIn:
                return Easing.QuintEaseOutIn(linear_progress, 0, 1, 1);

            case EasingEquation.SineEaseIn:
                return Easing.SineEaseIn(linear_progress, 0, 1, 1);
            case EasingEquation.SineEaseInOut:
                return Easing.SineEaseInOut(linear_progress, 0, 1, 1);
            case EasingEquation.SineEaseOut:
                return Easing.SineEaseOut(linear_progress, 0, 1, 1);
            case EasingEquation.SineEaseOutIn:
                return Easing.SineEaseOutIn(linear_progress, 0, 1, 1);

            default :
                return linear_progress;
            }
        }

        public static EasingEquation GetEaseTypeOpposite(EasingEquation ease_type)
        {
            switch(ease_type)
            {
            case EasingEquation.Linear:
                return EasingEquation.Linear;
            case EasingEquation.BackEaseIn:
                return EasingEquation.BackEaseOut;
            case EasingEquation.BackEaseInOut:
                return EasingEquation.BackEaseOutIn;
            case EasingEquation.BackEaseOut:
                return EasingEquation.BackEaseIn;
            case EasingEquation.BackEaseOutIn:
                return EasingEquation.BackEaseInOut;
            case EasingEquation.BounceEaseIn:
                return EasingEquation.BounceEaseOut;


            case EasingEquation.BounceEaseInOut:
                return EasingEquation.BounceEaseOutIn;
            case EasingEquation.BounceEaseOut:
                return EasingEquation.BounceEaseIn;
            case EasingEquation.BounceEaseOutIn:
                return EasingEquation.BounceEaseInOut;
            case EasingEquation.CircEaseIn:
                return EasingEquation.CircEaseOut;


            case EasingEquation.CircEaseInOut:
                return EasingEquation.CircEaseOutIn;
            case EasingEquation.CircEaseOut:
                return EasingEquation.CircEaseIn;


            case EasingEquation.CircEaseOutIn:
                return EasingEquation.CircEaseInOut;
            case EasingEquation.CubicEaseIn:
                return EasingEquation.CubicEaseOut;
            case EasingEquation.CubicEaseInOut:
                return EasingEquation.CubicEaseOutIn;
            case EasingEquation.CubicEaseOut:
                return EasingEquation.CubicEaseIn;
            case EasingEquation.CubicEaseOutIn:
                return EasingEquation.CubicEaseInOut;
            case EasingEquation.ElasticEaseIn:
                return EasingEquation.ElasticEaseOut;

            case EasingEquation.ElasticEaseInOut:
                return EasingEquation.ElasticEaseOutIn;
            case EasingEquation.ElasticEaseOut:
                return EasingEquation.ElasticEaseIn;
            case EasingEquation.ElasticEaseOutIn:
                return EasingEquation.ElasticEaseInOut;
            case EasingEquation.ExpoEaseIn:
                return EasingEquation.ExpoEaseOut;
            case EasingEquation.ExpoEaseInOut:
                return EasingEquation.ExpoEaseOutIn;
            case EasingEquation.ExpoEaseOut:
                return EasingEquation.ExpoEaseIn;
            case EasingEquation.ExpoEaseOutIn:
                return EasingEquation.ExpoEaseInOut;
            case EasingEquation.QuadEaseIn:
                return EasingEquation.QuadEaseOut;


            case EasingEquation.QuadEaseInOut:
                return EasingEquation.QuadEaseOutIn;
            case EasingEquation.QuadEaseOut:
                return EasingEquation.QuadEaseIn;
            case EasingEquation.QuadEaseOutIn:
                return EasingEquation.QuadEaseInOut;
            case EasingEquation.QuartEaseIn:
                return EasingEquation.QuartEaseOut;
            case EasingEquation.QuartEaseInOut:
                return EasingEquation.QuartEaseOutIn;
            case EasingEquation.QuartEaseOut:
                return EasingEquation.QuartEaseIn;
            case EasingEquation.QuartEaseOutIn:
                return EasingEquation.QuartEaseInOut;
            case EasingEquation.QuintEaseIn:
                return EasingEquation.QuintEaseOut;
            case EasingEquation.QuintEaseInOut:
                return EasingEquation.QuintEaseOutIn;
            case EasingEquation.QuintEaseOut:
                return EasingEquation.QuintEaseIn;
            case EasingEquation.QuintEaseOutIn:
                return EasingEquation.QuintEaseInOut;

            case EasingEquation.SineEaseIn:
                return EasingEquation.SineEaseOut;
            case EasingEquation.SineEaseInOut:
                return EasingEquation.SineEaseOutIn;
            case EasingEquation.SineEaseOut:
                return EasingEquation.SineEaseIn;
            case EasingEquation.SineEaseOutIn:
                return EasingEquation.SineEaseInOut;

            default :
                return EasingEquation.Linear;
            }
        }


        /* EASING FUNCTIONS */

        #region Linear

        /// <summary>
        /// Easing equation function for a simple linear tweening, with no easing.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float Linear( float t, float b, float c, float d )
        {
            return c * t / d + b;
        }

        #endregion

        #region Expo

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ExpoEaseOut( float t, float b, float c, float d )
        {
            return ( t == d ) ? b + c : c * ( -Mathf.Pow( 2, -10 * t / d ) + 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ExpoEaseIn( float t, float b, float c, float d )
        {
            return ( t == 0 ) ? b : c * Mathf.Pow( 2, 10 * ( t / d - 1 ) ) + b;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ExpoEaseInOut( float t, float b, float c, float d )
        {
            if ( t == 0 )
                return b;

            if ( t == d )
                return b + c;

            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * Mathf.Pow( 2, 10 * ( t - 1 ) ) + b;

            return c / 2 * ( -Mathf.Pow( 2, -10 * --t ) + 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ExpoEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return ExpoEaseOut( t * 2, b, c / 2, d );

            return ExpoEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Circular

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CircEaseOut( float t, float b, float c, float d )
        {
            return c * Mathf.Sqrt( 1 - ( t = t / d - 1 ) * t ) + b;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CircEaseIn( float t, float b, float c, float d )
        {
            return -c * ( Mathf.Sqrt( 1 - ( t /= d ) * t ) - 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CircEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2 ) < 1 )
                return -c / 2 * ( Mathf.Sqrt( 1 - t * t ) - 1 ) + b;

            return c / 2 * ( Mathf.Sqrt( 1 - ( t -= 2 ) * t ) + 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CircEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return CircEaseOut( t * 2, b, c / 2, d );

            return CircEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Quad

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuadEaseOut( float t, float b, float c, float d )
        {
            return -c * ( t /= d ) * ( t - 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuadEaseIn( float t, float b, float c, float d )
        {
            return c * ( t /= d ) * t + b;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuadEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * t * t + b;

            return -c / 2 * ( ( --t ) * ( t - 2 ) - 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuadEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return QuadEaseOut( t * 2, b, c / 2, d );

            return QuadEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Sine

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float SineEaseOut( float t, float b, float c, float d )
        {
            return c * Mathf.Sin( t / d * ( Mathf.PI / 2 ) ) + b;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float SineEaseIn( float t, float b, float c, float d )
        {
            return -c * Mathf.Cos( t / d * ( Mathf.PI / 2 ) ) + c + b;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float SineEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * ( Mathf.Sin( Mathf.PI * t / 2 ) ) + b;

            return -c / 2 * ( Mathf.Cos( Mathf.PI * --t / 2 ) - 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float SineEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return SineEaseOut( t * 2, b, c / 2, d );

            return SineEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Cubic

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CubicEaseOut( float t, float b, float c, float d )
        {
            return c * ( ( t = t / d - 1 ) * t * t + 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CubicEaseIn( float t, float b, float c, float d )
        {
            return c * ( t /= d ) * t * t + b;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CubicEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * t * t * t + b;

            return c / 2 * ( ( t -= 2 ) * t * t + 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float CubicEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return CubicEaseOut( t * 2, b, c / 2, d );

            return CubicEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Quartic

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuartEaseOut( float t, float b, float c, float d )
        {
            return -c * ( ( t = t / d - 1 ) * t * t * t - 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuartEaseIn( float t, float b, float c, float d )
        {
            return c * ( t /= d ) * t * t * t + b;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuartEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * t * t * t * t + b;

            return -c / 2 * ( ( t -= 2 ) * t * t * t - 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuartEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return QuartEaseOut( t * 2, b, c / 2, d );

            return QuartEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Quintic

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuintEaseOut( float t, float b, float c, float d )
        {
            return c * ( ( t = t / d - 1 ) * t * t * t * t + 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuintEaseIn( float t, float b, float c, float d )
        {
            return c * ( t /= d ) * t * t * t * t + b;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuintEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * t * t * t * t * t + b;
            return c / 2 * ( ( t -= 2 ) * t * t * t * t + 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float QuintEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return QuintEaseOut( t * 2, b, c / 2, d );
            return QuintEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Elastic

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ElasticEaseOut( float t, float b, float c, float d )
        {
            if ( ( t /= d ) == 1 )
                return b + c;

            float p = d * 0.3f;
            float s = p / 4;

            return ( c * Mathf.Pow( 2, -10 * t ) * Mathf.Sin( ( t * d - s ) * ( 2 * Mathf.PI ) / p ) + c + b );
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ElasticEaseIn( float t, float b, float c, float d )
        {
            if ( ( t /= d ) == 1 )
                return b + c;

            float p = d * 0.3f;
            float s = p / 4;

            return -( c * Mathf.Pow( 2, 10 * ( t -= 1 ) ) * Mathf.Sin( ( t * d - s ) * ( 2 * Mathf.PI ) / p ) ) + b;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ElasticEaseInOut( float t, float b, float c, float d )
        {
            if ( ( t /= d / 2f ) == 2 )
                return b + c;

            float p = d * ( 0.3f * 1.5f );
            float s = p / 4;

            if ( t < 1 )
                return -0.5f * ( c * Mathf.Pow( 2, 10 * ( t -= 1 ) ) * Mathf.Sin( ( t * d - s ) * ( 2 * Mathf.PI ) / p ) ) + b;
            return c * Mathf.Pow( 2, -10 * ( t -= 1 ) ) * Mathf.Sin( ( t * d - s ) * ( 2 * Mathf.PI ) / p ) * 0.5f + c + b;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float ElasticEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return ElasticEaseOut( t * 2, b, c / 2, d );
            return ElasticEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Bounce

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BounceEaseOut( float t, float b, float c, float d )
        {
            if ( ( t /= d ) < ( 1 / 2.75f ) )
                return c * ( 7.5625f * t * t ) + b;
            else if ( t < ( 2 / 2.75f ) )
                return c * ( 7.5625f * ( t -= ( 1.5f / 2.75f ) ) * t + 0.75f ) + b;
            else if ( t < ( 2.5f / 2.75f ) )
                return c * ( 7.5625f * ( t -= ( 2.25f / 2.75f ) ) * t + 0.9375f ) + b;
            else
                return c * ( 7.5625f * ( t -= ( 2.625f / 2.75f ) ) * t + .984375f ) + b;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BounceEaseIn( float t, float b, float c, float d )
        {
            return c - BounceEaseOut( d - t, 0, c, d ) + b;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BounceEaseInOut( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return BounceEaseIn( t * 2, 0, c, d ) * 0.5f + b;
            else
                return BounceEaseOut( t * 2 - d, 0, c, d ) * 0.5f + c * 0.5f + b;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BounceEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return BounceEaseOut( t * 2, b, c / 2, d );
            return BounceEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion

        #region Back

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BackEaseOut( float t, float b, float c, float d )
        {
            return c * ( ( t = t / d - 1 ) * t * ( ( 1.70158f + 1 ) * t + 1.70158f ) + 1 ) + b;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BackEaseIn( float t, float b, float c, float d )
        {
            return c * ( t /= d ) * t * ( ( 1.70158f + 1 ) * t - 1.70158f ) + b;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BackEaseInOut( float t, float b, float c, float d )
        {
            float s = 1.70158f;
            if ( ( t /= d / 2 ) < 1 )
                return c / 2 * ( t * t * ( ( ( s *= ( 1.525f ) ) + 1 ) * t - s ) ) + b;
            return c / 2 * ( ( t -= 2 ) * t * ( ( ( s *= ( 1.525f ) ) + 1 ) * t + s ) + 2 ) + b;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public static float BackEaseOutIn( float t, float b, float c, float d )
        {
            if ( t < d / 2 )
                return BackEaseOut( t * 2, b, c / 2, d );
            return BackEaseIn( ( t * 2 ) - d, b + c / 2, c / 2, d );
        }

        #endregion
    }    
}