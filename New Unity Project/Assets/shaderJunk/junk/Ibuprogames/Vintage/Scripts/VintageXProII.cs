﻿///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Ibuprogames <hello@ibuprogames.com>. All rights reserved.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR
// IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using UnityEngine;

namespace Ibuprogames
{
  namespace VintageAsset
  {
    /// <summary>
    /// This effect gives your game a warm vintage feeling and saturated tones.
    /// </summary>
    [ExecuteInEditMode]
    [RequireComponent(typeof(Camera))]
    [AddComponentMenu("Image Effects/Ibuprogrames/Vintage/Vintage XProII")]
    public sealed class VintageXProII : VintageBase
    {
      #region Private data.
      private Texture2D levelsTex;

      private static readonly string variableLevelsTex = @"_LevelsTex";
      #endregion

      #region Public functions.
      /// <summary>
      /// Effect description.
      /// </summary>
      public override string ToString()
      {
        return @"This effect gives your game a warm vintage feeling and saturated tones.";
      }
      #endregion

      #region Private functions.
      /// <summary>
      /// Load custom resources.
      /// </summary>
      protected override void LoadCustomResources()
      {
        levelsTex = LoadTextureFromResources(@"Textures/xproMap");
      }

      /// <summary>
      /// Set the values to shader.
      /// </summary>
      protected override void SendValuesToShader()
      {
        material.SetTexture(variableLevelsTex, levelsTex);
      }
      #endregion
    }
  }
}