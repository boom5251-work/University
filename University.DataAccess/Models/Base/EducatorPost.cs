using System;

namespace University.DataAccess.Models.Base
{
    /// <summary>
    /// Должности преподавателей.
    /// </summary>
    [Flags]
    public enum EducatorPost
    {
        /// <summary>
        /// Должность не присвоена.
        /// </summary>
        None = 0,

        /// <summary>
        /// Директор.
        /// </summary>
        Director = 1,

        /// <summary>
        /// Первый заместитель директора.
        /// </summary>
        FirstDD = 2,

        /// <summary>
        /// Заместитель директора по учебной работе.
        /// </summary>
        AcademicAffairsDD = 4,

        /// <summary>
        /// Заместитель директора по методической работе.
        /// </summary>
        MethodologicalWorkDD = 8,

        /// <summary>
        /// Заместитель директора по научной работе.
        /// </summary>
        ScientificWorkDD = 16,

        /// <summary>
        /// Заместитель директора по учебно-методической работе.
        /// </summary>
        EducationalMethodologicalWorkDD = 32,

        /// <summary>
        /// Заместитель директора по общим вопросам.
        /// </summary>
        GeneralAffairsDD = 64
    }
}