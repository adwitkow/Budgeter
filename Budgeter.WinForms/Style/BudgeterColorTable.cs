// This file is part of Budgeter project <https://github.com/adwitkow/Budgeter>
// Copyright (C) 2021  Adam Witkowski <https://github.com/adwitkow/>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System.Drawing;
using System.Windows.Forms;

namespace Budgeter.WinForms.Style
{
    public class BudgeterColorTable : ProfessionalColorTable
    {
        public override Color ButtonPressedBorder => Color.Transparent;

        public override Color ButtonPressedGradientBegin => Color.DarkGray;

        public override Color ButtonPressedGradientEnd => Color.DarkGray;

        public override Color ButtonPressedGradientMiddle => Color.DarkGray;

        public override Color ButtonSelectedBorder => Color.Transparent;

        public override Color ButtonSelectedGradientBegin => Color.LightGray;

        public override Color ButtonSelectedGradientEnd => Color.DarkGray;

#pragma warning disable S125 // Sections of code should not be commented out

        // public override Color MenuItemSelected => Color.Red;
        // public override Color ToolStripPanelGradientBegin => Color.Red;
        // public override Color ButtonCheckedGradientEnd => Color.Red;
        // public override Color ButtonCheckedGradientBegin => Color.Red;
        // public override Color ButtonCheckedGradientMiddle => Color.Red;
        // public override Color ButtonCheckedHighlight => Color.Red;
        // public override Color ButtonCheckedHighlightBorder => Color.Red;
        // public override Color ButtonPressedHighlight => Color.Red;
        // public override Color ButtonPressedHighlightBorder => Color.Red;
        // public override Color ButtonSelectedGradientMiddle => Color.Red;
        // public override Color ButtonSelectedHighlight => Color.Red;
        // public override Color ButtonSelectedHighlightBorder => Color.Red;
        // public override Color CheckBackground => Color.Red;
        // public override Color CheckPressedBackground => Color.Red;
        // public override Color CheckSelectedBackground => Color.Red;
        // public override Color GripDark => Color.Red;
        // public override Color GripLight => Color.Red;
        // public override Color ImageMarginGradientBegin => Color.Red;
        // public override Color ImageMarginGradientEnd => Color.Red;
        // public override Color ImageMarginGradientMiddle => Color.Red;
        // public override Color ImageMarginRevealedGradientBegin => Color.Red;
        // public override Color ImageMarginRevealedGradientEnd => Color.Red;
        // public override Color ImageMarginRevealedGradientMiddle => Color.Red;
        // public override Color MenuBorder => Color.Red;
        // public override Color MenuItemBorder => Color.Red;
        // public override Color MenuItemPressedGradientBegin => Color.Red;
        // public override Color MenuItemPressedGradientEnd => Color.Red;
        // public override Color MenuItemPressedGradientMiddle => Color.Red;
        // public override Color MenuItemSelectedGradientBegin => Color.Red;
        // public override Color MenuItemSelectedGradientEnd => Color.Red;
        // public override Color MenuStripGradientBegin => Color.Red;
        // public override Color MenuStripGradientEnd => Color.Red;
        // public override Color OverflowButtonGradientBegin => Color.Red;
        // public override Color OverflowButtonGradientEnd => Color.Red;
        // public override Color OverflowButtonGradientMiddle => Color.Red;
        // public override Color RaftingContainerGradientBegin => Color.Red;
        // public override Color RaftingContainerGradientEnd => Color.Red;
        // public override Color SeparatorDark => Color.Red;
        // public override Color SeparatorLight => Color.Red;
        // public override Color StatusStripGradientBegin => Color.Red;
        // public override Color StatusStripGradientEnd => Color.Red;
        // public override Color ToolStripBorder => Color.Red;
        // public override Color ToolStripContentPanelGradientBegin => Color.Red;
        // public override Color ToolStripContentPanelGradientEnd => Color.Red;
        // public override Color ToolStripDropDownBackground => Color.Red;
        // public override Color ToolStripGradientBegin => Color.Red;
        // public override Color ToolStripGradientEnd => Color.Red;
        // public override Color ToolStripGradientMiddle => Color.Red;
        // public override Color ToolStripPanelGradientEnd => Color.Red;
#pragma warning restore S125 // Sections of code should not be commented out
    }
}
