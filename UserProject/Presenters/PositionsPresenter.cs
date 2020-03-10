using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Services;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class PositionsPresenter
    {
        IPositionsView view;
        private userProjectDBContext db = new userProjectDBContext();
        BindingList<position> bindingPositionList = new BindingList<position>();

        public PositionsPresenter(IPositionsView param)
        {            
            view = param;
            db.position.OrderBy(x => x.priority).Load();
            bindingPositionList = db.position.Local.ToBindingList();
        }
        public void getAllPositon() 
        {
            view.statPositionList = db.position.OrderBy(x => x.priority).ToList();  
            
        }
        public void getPermissions(position selectedItem)
        {
            
            if (!selectedItem.permission_ids.Equals(string.Empty))
            {
                string[] sPermissonons = selectedItem.permission_ids.Split(',');
                int[] perm = Array.ConvertAll(sPermissonons, s => int.Parse(s));
                view.availablePermissionsList = db.permission.Where(x => !perm.Contains(x.id)).ToList();
                view.positionPermissionsList = db.permission.Where(x => perm.Contains(x.id)).ToList();
            }
            else
            {
                view.availablePermissionsList = db.permission.ToList();
                view.positionPermissionsList = null;
            }
            



        }        
        public void upList(position selectedItem)
        {
            int tempIndex = view.statPositionList.IndexOf(selectedItem);
            if (tempIndex>0)
            {
                view.statPositionList.Remove(selectedItem);
                view.statPositionList.Insert(tempIndex - 1, selectedItem);
            }
        }
        public void downList(position selectedItem)
        {
            int tempIndex = view.statPositionList.IndexOf(selectedItem);
            if (tempIndex < view.statPositionList.Count-1)
            {
                view.statPositionList.Remove(selectedItem);
                view.statPositionList.Insert(tempIndex + 1, selectedItem);
            }
        }
        private void setPriority()
        {
            foreach (position item in bindingPositionList)
            {
                var temp = view.statPositionList.SingleOrDefault(x => x.id == item.id);
                item.priority = temp.priority;
            }
        }
        public void delete(position selectedItem)
        {
            if (selectedItem != null)
            {                
                bindingPositionList.Remove(selectedItem);
                view.statPositionList = bindingPositionList.ToList();                
                Debug.WriteLine("delete - presenter");                
            }
                    
        }        
        public void addPosition(position newPosition)
        {
            if (view.statPositionList.Any(x => x.position_name == newPosition.position_name))
            {
                Debug.WriteLine("Már létezik");
            }
            else
            {
                bindingPositionList.Add(newPosition);
                view.statPositionList = bindingPositionList.ToList();
                db.position.Add(newPosition);
            }
            
        }
        public void save() 
        {
            setPriority();
            db.SaveChanges();
        }
    }
}
