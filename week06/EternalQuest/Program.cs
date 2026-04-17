using System;
/*
EXCEEDING REQUIREMENTS

Implemented the following enhancements to exceed requirements:

1. Recalculated the total score when loading frm file to ensure accuracy even if the file was manually edited.
2. Fail-safe file parsing (validation of line format and safe parsing to avoid crashes).
3. Improved user experience:
   - Friendly message when no goals exist.
   - Input validation for menu options and goal selection.
4. Encapsulation improvements using proper getters instead of direct field access.
5. Polymorphic design using abstract Goal class with overridden behavior in all derived goal types.

These improvements increase robustness, usability, and maintain data integrity.
*/


class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}