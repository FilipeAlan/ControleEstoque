using System;

namespace Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UserName { get; set; }
        public Entity() 
        {
            Id = Guid.NewGuid();
            //Acho que a data de criação pode ser feita aqui;
            CreationDate = DateTime.UtcNow;
            UpdateDate = DateTime.UtcNow;
        }
        public override bool Equals(object obj)
        {
            Entity entity = (Entity)obj;
            if (ReferenceEquals(entity, this))
                return true;
            if (ReferenceEquals(entity, null))
                return false;
            return Id.Equals(entity.Id);
        }
        public static bool operator ==(Entity entity1,Entity entity2) 
        {
            if (ReferenceEquals(entity1, null) && ReferenceEquals(entity2, null))
                return true;
            if (ReferenceEquals(entity1, null) || ReferenceEquals(entity2, null))
                return false;
            return entity1.Equals(entity2);
        }

        public static bool operator !=(Entity entity1,Entity entity2) 
        {
            return !(entity1 == entity2);
        }
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 913) * Id.GetHashCode();
        }
        public override string ToString()
        {
            return $"({GetType().Name} : Id = {Id})";
        }
    }
}
